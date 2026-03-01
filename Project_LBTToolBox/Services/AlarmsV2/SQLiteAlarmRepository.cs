using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace Project_LBTToolBox.Services.AlarmsV2
{
    /// <summary>
    /// SQLite 實作的 Alarm Repository。
    /// 提供 schema 管理、log 匯入（檔案變更偵測）與查詢能力。
    /// </summary>
    public class SQLiteAlarmRepository : IAlarmRepository
    {
        private readonly string _dbPath;
        private readonly DbProviderFactory _factory;
        private readonly string _connectionString;

        /// <summary>
        /// 主行格式：[timestamp] [level] message
        /// </summary>
        private static readonly Regex HeaderRegex = new Regex(
            @"^\[(?<ts>[^\]]+)\]\s+\[(?<level>[A-Za-z]+)\]\s*(?<msg>.*)$",
            RegexOptions.Compiled);

        /// <summary>
        /// 建立 SQLite Repository。
        /// </summary>
        /// <param name="dbPath">SQLite 檔案完整路徑。</param>
        public SQLiteAlarmRepository(string dbPath)
        {
            _dbPath = dbPath ?? throw new ArgumentNullException(nameof(dbPath));

            string directory = Path.GetDirectoryName(_dbPath);
            if (!string.IsNullOrWhiteSpace(directory))
                Directory.CreateDirectory(directory);

            _factory = ResolveFactory();
            _connectionString = $"Data Source={_dbPath};Version=3;";
        }

        /// <summary>
        /// 建立/更新資料表與索引。
        /// </summary>
        public void EnsureSchema()
        {
            using (DbConnection conn = OpenConnection())
            using (DbCommand cmd = conn.CreateCommand())
            {
                // 核心結構：
                // machines（機台維表）
                // ware_codes（穩定碼維表）
                // log_files（匯入狀態）
                // alarm_events（事件事實表）
                cmd.CommandText = @"
PRAGMA journal_mode = WAL;
PRAGMA synchronous = NORMAL;

CREATE TABLE IF NOT EXISTS machines (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    name TEXT NOT NULL UNIQUE
);

CREATE TABLE IF NOT EXISTS ware_codes (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    code TEXT NOT NULL UNIQUE,
    normalized_message TEXT NOT NULL UNIQUE,
    sample_message TEXT NOT NULL,
    created_utc TEXT NOT NULL
);

CREATE TABLE IF NOT EXISTS log_files (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    file_path TEXT NOT NULL UNIQUE,
    last_size INTEGER NOT NULL,
    last_write_utc TEXT NOT NULL,
    last_ingested_utc TEXT NOT NULL
);

CREATE TABLE IF NOT EXISTS alarm_events (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    ts_local TEXT NOT NULL,
    day_local TEXT NOT NULL,
    hour_local INTEGER NOT NULL,
    machine_id INTEGER NOT NULL,
    level TEXT NOT NULL,
    ware_code_id INTEGER NOT NULL,
    message TEXT NOT NULL,
    raw_line TEXT NOT NULL,
    file_path TEXT NOT NULL,
    created_utc TEXT NOT NULL,
    FOREIGN KEY(machine_id) REFERENCES machines(id),
    FOREIGN KEY(ware_code_id) REFERENCES ware_codes(id)
);

CREATE INDEX IF NOT EXISTS idx_alarm_events_day ON alarm_events(day_local);
CREATE INDEX IF NOT EXISTS idx_alarm_events_level_day ON alarm_events(level, day_local);
CREATE INDEX IF NOT EXISTS idx_alarm_events_machine_day ON alarm_events(machine_id, day_local);
CREATE INDEX IF NOT EXISTS idx_alarm_events_warecode_day ON alarm_events(ware_code_id, day_local);
CREATE INDEX IF NOT EXISTS idx_alarm_events_file_path ON alarm_events(file_path);
";
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// 匯入資料夾下所有機台 log 檔。
        /// 若檔案大小與最後寫入時間都未改變，會跳過匯入。
        /// </summary>
        /// <param name="rootFolderPath">機台 log 主資料夾。</param>
        public void IngestFromFolder(string rootFolderPath)
        {
            if (string.IsNullOrWhiteSpace(rootFolderPath) || !Directory.Exists(rootFolderPath))
                return;

            EnsureSchema();

            string[] machineDirs = Directory.GetDirectories(rootFolderPath);
            using (DbConnection conn = OpenConnection())
            using (DbTransaction tx = conn.BeginTransaction())
            {
                foreach (string machineDir in machineDirs)
                {
                    string machineName = Path.GetFileName(machineDir);
                    long machineId = EnsureMachine(conn, tx, machineName);

                    string[] logFiles = Directory.GetFiles(machineDir, "*.txt");
                    foreach (string logFile in logFiles)
                    {
                        if (!ShouldIngestFile(conn, tx, logFile))
                            continue;

                        DeleteEventsByFile(conn, tx, logFile);
                        IngestSingleFile(conn, tx, logFile, machineId);
                        UpsertLogFileState(conn, tx, logFile);
                    }
                }

                tx.Commit();
            }
        }

        /// <summary>
        /// 依條件查詢 alarm_events 並回傳事件模型。
        /// </summary>
        /// <param name="query">查詢條件。</param>
        /// <returns>事件清單。</returns>
        public List<AlarmEvent> QueryEvents(AlarmQuery query)
        {
            if (query == null) throw new ArgumentNullException(nameof(query));

            EnsureSchema();
            List<AlarmEvent> result = new List<AlarmEvent>();

            using (DbConnection conn = OpenConnection())
            using (DbCommand cmd = conn.CreateCommand())
            {
                var sql = new StringBuilder();
                sql.Append(@"
SELECT
    e.ts_local,
    m.name AS machine_name,
    e.level,
    w.code AS ware_code,
    e.message,
    e.raw_line,
    e.file_path
FROM alarm_events e
INNER JOIN machines m ON m.id = e.machine_id
INNER JOIN ware_codes w ON w.id = e.ware_code_id
WHERE 1 = 1
");

                if (!string.IsNullOrWhiteSpace(query.Level))
                {
                    sql.Append(" AND e.level = @level");
                    AddParam(cmd, "@level", query.Level);
                }

                if (!string.IsNullOrWhiteSpace(query.WareCode))
                {
                    sql.Append(" AND w.code = @wareCode");
                    AddParam(cmd, "@wareCode", query.WareCode.Trim());
                }

                if (query.UseDateFilter)
                {
                    sql.Append(" AND e.day_local >= @dateFrom AND e.day_local <= @dateTo");
                    AddParam(cmd, "@dateFrom", query.DateFrom.Date.ToString("yyyy-MM-dd"));
                    AddParam(cmd, "@dateTo", query.DateTo.Date.ToString("yyyy-MM-dd"));
                }

                if (query.SelectedMachines != null && query.SelectedMachines.Count > 0)
                {
                    List<string> names = query.SelectedMachines
                        .Where(x => !string.IsNullOrWhiteSpace(x))
                        .Distinct(StringComparer.OrdinalIgnoreCase)
                        .ToList();

                    if (names.Count > 0)
                    {
                        var machineParamNames = new List<string>();
                        for (int i = 0; i < names.Count; i++)
                        {
                            string p = "@m" + i;
                            machineParamNames.Add(p);
                            AddParam(cmd, p, names[i]);
                        }

                        sql.Append(" AND m.name IN (" + string.Join(", ", machineParamNames) + ")");
                    }
                }

                sql.Append(" ORDER BY e.ts_local DESC");
                cmd.CommandText = sql.ToString();

                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(new AlarmEvent
                        {
                            Timestamp = ParseTs(reader.GetString(0)),
                            Machine = reader.GetString(1),
                            Level = reader.GetString(2),
                            WareCode = reader.GetString(3),
                            Message = reader.GetString(4),
                            RawLine = reader.GetString(5),
                            FilePath = reader.GetString(6)
                        });
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// 解析單一 log 檔，將主行與續行整合後寫入資料庫。
        /// </summary>
        /// <param name="conn">已開啟的資料庫連線。</param>
        /// <param name="tx">目前交易。</param>
        /// <param name="logFilePath">來源 log 檔案路徑。</param>
        /// <param name="machineId">機台維表 ID。</param>
        private void IngestSingleFile(DbConnection conn, DbTransaction tx, string logFilePath, long machineId)
        {
            using (var fs = new FileStream(logFilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (var sr = new StreamReader(fs, DetectEncoding(fs) ?? Encoding.UTF8, true))
            {
                ParsedEvent current = null;
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    if (TryParseHeader(line, out DateTime ts, out string level, out string msg))
                    {
                        if (current != null)
                            InsertParsedEvent(conn, tx, machineId, logFilePath, current);

                        current = new ParsedEvent
                        {
                            Timestamp = ts,
                            Level = (level ?? string.Empty).Trim(),
                            Message = (msg ?? string.Empty).Trim(),
                            RawLine = line
                        };
                    }
                    else if (current != null)
                    {
                        if (!string.IsNullOrWhiteSpace(line))
                            current.ContextLines.Add(line.Trim());
                    }
                }

                if (current != null)
                    InsertParsedEvent(conn, tx, machineId, logFilePath, current);
            }
        }

        /// <summary>
        /// 將一筆解析後的事件寫入 alarm_events。
        /// </summary>
        /// <param name="conn">已開啟的資料庫連線。</param>
        /// <param name="tx">目前交易。</param>
        /// <param name="machineId">機台維表 ID。</param>
        /// <param name="filePath">來源 log 檔案路徑。</param>
        /// <param name="parsed">解析後事件。</param>
        private void InsertParsedEvent(DbConnection conn, DbTransaction tx, long machineId, string filePath, ParsedEvent parsed)
        {
            string fullMessage = parsed.ContextLines.Count == 0
                ? parsed.Message
                : parsed.Message + Environment.NewLine + string.Join(Environment.NewLine, parsed.ContextLines);

            string normalized = NormalizeMessage(fullMessage);
            long wareCodeId = EnsureWareCode(conn, tx, normalized, fullMessage);

            using (DbCommand cmd = conn.CreateCommand())
            {
                cmd.Transaction = tx;
                cmd.CommandText = @"
INSERT INTO alarm_events
(
    ts_local, day_local, hour_local, machine_id, level, ware_code_id, message, raw_line, file_path, created_utc
)
VALUES
(
    @tsLocal, @dayLocal, @hourLocal, @machineId, @level, @wareCodeId, @message, @rawLine, @filePath, @createdUtc
);";
                AddParam(cmd, "@tsLocal", parsed.Timestamp.ToString("yyyy-MM-dd HH:mm:ss"));
                AddParam(cmd, "@dayLocal", parsed.Timestamp.ToString("yyyy-MM-dd"));
                AddParam(cmd, "@hourLocal", parsed.Timestamp.Hour);
                AddParam(cmd, "@machineId", machineId);
                AddParam(cmd, "@level", parsed.Level);
                AddParam(cmd, "@wareCodeId", wareCodeId);
                AddParam(cmd, "@message", fullMessage);
                AddParam(cmd, "@rawLine", parsed.RawLine ?? string.Empty);
                AddParam(cmd, "@filePath", filePath);
                AddParam(cmd, "@createdUtc", DateTime.UtcNow.ToString("o"));
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// 取得或建立 machine 維表 ID。
        /// </summary>
        /// <param name="conn">已開啟的資料庫連線。</param>
        /// <param name="tx">目前交易。</param>
        /// <param name="machineName">機台名稱。</param>
        /// <returns>machine 維表 ID。</returns>
        private long EnsureMachine(DbConnection conn, DbTransaction tx, string machineName)
        {
            using (DbCommand check = conn.CreateCommand())
            {
                check.Transaction = tx;
                check.CommandText = "SELECT id FROM machines WHERE name = @name LIMIT 1;";
                AddParam(check, "@name", machineName);
                object id = check.ExecuteScalar();
                if (id != null && id != DBNull.Value)
                    return Convert.ToInt64(id, CultureInfo.InvariantCulture);
            }

            using (DbCommand insert = conn.CreateCommand())
            {
                insert.Transaction = tx;
                insert.CommandText = "INSERT INTO machines(name) VALUES(@name); SELECT last_insert_rowid();";
                AddParam(insert, "@name", machineName);
                return Convert.ToInt64(insert.ExecuteScalar(), CultureInfo.InvariantCulture);
            }
        }

        /// <summary>
        /// 取得或建立 WareCode 維表 ID。
        /// 新訊息會依自增 ID 產生穩定碼（E0001...）。
        /// </summary>
        /// <param name="conn">已開啟的資料庫連線。</param>
        /// <param name="tx">目前交易。</param>
        /// <param name="normalizedMessage">正規化後訊息。</param>
        /// <param name="sampleMessage">樣本訊息（原文）。</param>
        /// <returns>ware_code 維表 ID。</returns>
        private long EnsureWareCode(DbConnection conn, DbTransaction tx, string normalizedMessage, string sampleMessage)
        {
            using (DbCommand check = conn.CreateCommand())
            {
                check.Transaction = tx;
                check.CommandText = "SELECT id FROM ware_codes WHERE normalized_message = @normalized LIMIT 1;";
                AddParam(check, "@normalized", normalizedMessage);
                object id = check.ExecuteScalar();
                if (id != null && id != DBNull.Value)
                    return Convert.ToInt64(id, CultureInfo.InvariantCulture);
            }

            long newId;
            using (DbCommand insert = conn.CreateCommand())
            {
                insert.Transaction = tx;
                insert.CommandText = @"
INSERT INTO ware_codes(code, normalized_message, sample_message, created_utc)
VALUES(@code, @normalized, @sample, @createdUtc);
SELECT last_insert_rowid();";
                AddParam(insert, "@code", "__PENDING__");
                AddParam(insert, "@normalized", normalizedMessage);
                AddParam(insert, "@sample", sampleMessage ?? string.Empty);
                AddParam(insert, "@createdUtc", DateTime.UtcNow.ToString("o"));
                newId = Convert.ToInt64(insert.ExecuteScalar(), CultureInfo.InvariantCulture);
            }

            string generatedCode = "E" + newId.ToString("D4", CultureInfo.InvariantCulture);
            using (DbCommand update = conn.CreateCommand())
            {
                update.Transaction = tx;
                update.CommandText = "UPDATE ware_codes SET code = @code WHERE id = @id;";
                AddParam(update, "@code", generatedCode);
                AddParam(update, "@id", newId);
                update.ExecuteNonQuery();
            }

            return newId;
        }

        /// <summary>
        /// 判斷檔案是否需要重新匯入。
        /// </summary>
        /// <param name="conn">已開啟的資料庫連線。</param>
        /// <param name="tx">目前交易。</param>
        /// <param name="filePath">來源 log 檔案路徑。</param>
        /// <returns>需要匯入為 true。</returns>
        private bool ShouldIngestFile(DbConnection conn, DbTransaction tx, string filePath)
        {
            FileInfo info = new FileInfo(filePath);
            long size = info.Exists ? info.Length : 0L;
            string writeUtc = (info.Exists ? info.LastWriteTimeUtc : DateTime.MinValue).ToString("o");

            using (DbCommand cmd = conn.CreateCommand())
            {
                cmd.Transaction = tx;
                cmd.CommandText = "SELECT last_size, last_write_utc FROM log_files WHERE file_path = @filePath LIMIT 1;";
                AddParam(cmd, "@filePath", filePath);

                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    if (!reader.Read())
                        return true;

                    long lastSize = reader.GetInt64(0);
                    string lastWriteUtc = reader.GetString(1);

                    return !(lastSize == size && string.Equals(lastWriteUtc, writeUtc, StringComparison.Ordinal));
                }
            }
        }

        /// <summary>
        /// 更新或新增 log_files 匯入狀態。
        /// </summary>
        /// <param name="conn">已開啟的資料庫連線。</param>
        /// <param name="tx">目前交易。</param>
        /// <param name="filePath">來源 log 檔案路徑。</param>
        private void UpsertLogFileState(DbConnection conn, DbTransaction tx, string filePath)
        {
            FileInfo info = new FileInfo(filePath);
            long size = info.Exists ? info.Length : 0L;
            string writeUtc = (info.Exists ? info.LastWriteTimeUtc : DateTime.MinValue).ToString("o");
            string ingestedUtc = DateTime.UtcNow.ToString("o");

            int affected;
            using (DbCommand update = conn.CreateCommand())
            {
                update.Transaction = tx;
                update.CommandText = @"
UPDATE log_files
SET last_size = @lastSize,
    last_write_utc = @lastWriteUtc,
    last_ingested_utc = @lastIngestedUtc
WHERE file_path = @filePath;";
                AddParam(update, "@lastSize", size);
                AddParam(update, "@lastWriteUtc", writeUtc);
                AddParam(update, "@lastIngestedUtc", ingestedUtc);
                AddParam(update, "@filePath", filePath);
                affected = update.ExecuteNonQuery();
            }

            if (affected > 0)
                return;

            using (DbCommand insert = conn.CreateCommand())
            {
                insert.Transaction = tx;
                insert.CommandText = @"
INSERT INTO log_files(file_path, last_size, last_write_utc, last_ingested_utc)
VALUES(@filePath, @lastSize, @lastWriteUtc, @lastIngestedUtc);";
                AddParam(insert, "@filePath", filePath);
                AddParam(insert, "@lastSize", size);
                AddParam(insert, "@lastWriteUtc", writeUtc);
                AddParam(insert, "@lastIngestedUtc", ingestedUtc);
                insert.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// 先清除同來源檔案的舊資料，再寫入新內容。
        /// </summary>
        /// <param name="conn">已開啟的資料庫連線。</param>
        /// <param name="tx">目前交易。</param>
        /// <param name="filePath">來源 log 檔案路徑。</param>
        private void DeleteEventsByFile(DbConnection conn, DbTransaction tx, string filePath)
        {
            using (DbCommand cmd = conn.CreateCommand())
            {
                cmd.Transaction = tx;
                cmd.CommandText = "DELETE FROM alarm_events WHERE file_path = @filePath;";
                AddParam(cmd, "@filePath", filePath);
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// 開啟 SQLite 連線。
        /// </summary>
        private DbConnection OpenConnection()
        {
            DbConnection conn = _factory.CreateConnection();
            conn.ConnectionString = _connectionString;
            conn.Open();
            return conn;
        }

        /// <summary>
        /// 解析並取得 SQLite Provider Factory。
        /// </summary>
        private static DbProviderFactory ResolveFactory()
        {
            DbProviderFactory factory = TryGetFactoryFromLoadedAssembly();
            if (factory != null)
                return factory;

            TryLoadSQLiteAssemblyFromRuntimeBase();
            factory = TryGetFactoryFromLoadedAssembly();
            if (factory != null)
                return factory;

            TryLoadSQLiteAssemblyFromPackages();

            factory = TryGetFactoryFromLoadedAssembly();
            if (factory != null)
                return factory;

            throw new InvalidOperationException(
                "System.Data.SQLite provider not found. Please install NuGet package 'System.Data.SQLite.Core' for Project_LBTToolBox.");
        }

        /// <summary>
        /// 從已載入的 System.Data.SQLite assembly 取得 factory（同時支援 Instance 屬性與欄位）。
        /// </summary>
        private static DbProviderFactory TryGetFactoryFromLoadedAssembly()
        {
            Type sqliteFactoryType = Type.GetType("System.Data.SQLite.SQLiteFactory, System.Data.SQLite", throwOnError: false);
            if (sqliteFactoryType == null)
            {
                Assembly loaded = AppDomain.CurrentDomain
                    .GetAssemblies()
                    .FirstOrDefault(a => string.Equals(a.GetName().Name, "System.Data.SQLite", StringComparison.OrdinalIgnoreCase));
                if (loaded != null)
                    sqliteFactoryType = loaded.GetType("System.Data.SQLite.SQLiteFactory", throwOnError: false);
            }

            if (sqliteFactoryType == null)
                return null;

            object instance = null;

            PropertyInfo prop = sqliteFactoryType.GetProperty("Instance", BindingFlags.Public | BindingFlags.Static);
            if (prop != null)
                instance = prop.GetValue(null, null);

            if (instance == null)
            {
                FieldInfo field = sqliteFactoryType.GetField("Instance", BindingFlags.Public | BindingFlags.Static);
                if (field != null)
                    instance = field.GetValue(null);
            }

            if (instance is DbProviderFactory f)
                return f;

            return null;
        }

        /// <summary>
        /// 嘗試從方案 packages 路徑動態載入 System.Data.SQLite。
        /// </summary>
        private static void TryLoadSQLiteAssemblyFromPackages()
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            if (string.IsNullOrWhiteSpace(baseDir))
                return;

            string current = baseDir;
            for (int i = 0; i < 8; i++)
            {
                string packagesDir = Path.Combine(current, "packages");
                if (Directory.Exists(packagesDir))
                {
                    string[] candidates = Directory.GetFiles(packagesDir, "System.Data.SQLite.dll", SearchOption.AllDirectories);
                    if (candidates.Length > 0)
                    {
                        string dll = candidates
                            .OrderByDescending(x => x.IndexOf("net48", StringComparison.OrdinalIgnoreCase) >= 0 ? 1 : 0)
                            .ThenBy(x => x, StringComparer.OrdinalIgnoreCase)
                            .FirstOrDefault();

                        if (!string.IsNullOrWhiteSpace(dll))
                        {
                            try
                            {
                                Assembly.LoadFrom(dll);
                            }
                            catch
                            {
                                // ignore and fallback to old flow in caller
                            }
                        }
                    }

                    return;
                }

                DirectoryInfo parent = Directory.GetParent(current);
                if (parent == null)
                    return;
                current = parent.FullName;
            }
        }

        /// <summary>
        /// 嘗試從執行檔目錄載入 System.Data.SQLite。
        /// </summary>
        private static void TryLoadSQLiteAssemblyFromRuntimeBase()
        {
            try
            {
                Assembly.Load("System.Data.SQLite");
                return;
            }
            catch
            {
                // ignore and continue
            }

            try
            {
                string baseDir = AppDomain.CurrentDomain.BaseDirectory;
                if (string.IsNullOrWhiteSpace(baseDir))
                    return;

                string candidate = Path.Combine(baseDir, "System.Data.SQLite.dll");
                if (File.Exists(candidate))
                    Assembly.LoadFrom(candidate);
            }
            catch
            {
                // ignore and continue
            }
        }

        /// <summary>
        /// 建立並加入 SQL 參數（避免 SQL injection）。
        /// </summary>
        /// <param name="cmd">目標 command。</param>
        /// <param name="name">參數名稱。</param>
        /// <param name="value">參數值。</param>
        private static void AddParam(DbCommand cmd, string name, object value)
        {
            DbParameter p = cmd.CreateParameter();
            p.ParameterName = name;
            p.Value = value ?? DBNull.Value;
            cmd.Parameters.Add(p);
        }

        /// <summary>
        /// 解析資料庫儲存的時間字串。
        /// </summary>
        /// <param name="text">時間字串。</param>
        /// <returns>解析結果。</returns>
        private static DateTime ParseTs(string text)
        {
            if (DateTime.TryParseExact(
                text,
                "yyyy-MM-dd HH:mm:ss",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out DateTime dt))
                return dt;

            DateTime.TryParse(text, out dt);
            return dt;
        }

        /// <summary>
        /// 嘗試解析主行內容。
        /// </summary>
        /// <param name="line">原始行文字。</param>
        /// <param name="ts">解析出的時間。</param>
        /// <param name="level">解析出的等級。</param>
        /// <param name="msg">解析出的訊息。</param>
        /// <returns>成功解析主行為 true。</returns>
        private static bool TryParseHeader(string line, out DateTime ts, out string level, out string msg)
        {
            ts = default(DateTime);
            level = string.Empty;
            msg = string.Empty;

            if (string.IsNullOrEmpty(line) || line[0] != '[')
                return false;

            Match m = HeaderRegex.Match(line);
            if (!m.Success)
                return false;

            if (!DateTime.TryParse(m.Groups["ts"].Value, out ts))
                return false;

            level = m.Groups["level"].Value ?? string.Empty;
            msg = m.Groups["msg"].Value ?? string.Empty;
            return true;
        }

        /// <summary>
        /// 以 BOM 進行簡單編碼判斷。
        /// </summary>
        /// <param name="fs">檔案串流。</param>
        /// <returns>偵測出的編碼；無法判斷時回傳 null。</returns>
        private static Encoding DetectEncoding(FileStream fs)
        {
            byte[] bom = new byte[4];
            int n = fs.Read(bom, 0, 4);
            fs.Position = 0;

            if (n >= 3 && bom[0] == 0xEF && bom[1] == 0xBB && bom[2] == 0xBF)
                return Encoding.UTF8;

            if (n >= 2)
            {
                if (bom[0] == 0xFF && bom[1] == 0xFE) return Encoding.Unicode;
                if (bom[0] == 0xFE && bom[1] == 0xFF) return Encoding.BigEndianUnicode;
            }

            return null;
        }

        /// <summary>
        /// 正規化訊息文字，用於 WareCode 去重與穩定映射。
        /// </summary>
        /// <param name="message">原始訊息。</param>
        /// <returns>正規化後訊息。</returns>
        private static string NormalizeMessage(string message)
        {
            if (string.IsNullOrWhiteSpace(message))
                return string.Empty;

            string normalized = Regex.Replace(message.Trim(), @"\s+", " ");
            return normalized;
        }

        /// <summary>
        /// 解析過程中的暫存模型（主行 + 續行）。
        /// </summary>
        private sealed class ParsedEvent
        {
            public DateTime Timestamp { get; set; }
            public string Level { get; set; }
            public string Message { get; set; }
            public string RawLine { get; set; }
            public List<string> ContextLines { get; } = new List<string>();
        }
    }
}
