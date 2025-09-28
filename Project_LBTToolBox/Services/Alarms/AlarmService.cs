using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Project_LBTToolBox.Services.Alarms
{
    public partial class AlarmService
    {
        string _logMainFolderPath;

        public void SetLogMainFolderPath(string path)
        {
            _logMainFolderPath = path;
        }

        public List<AlarmRecord> GetAlarmRecords(bool isFilterDate, 
                                                DateTime dateTimeFrom, DateTime dateTimeTo,
                                                List<(string Name, bool IsChecked)> allMachines)
        {
            // Step 0：基本防呆
            List<AlarmRecord> allRecords = new List<AlarmRecord>();
            if (string.IsNullOrWhiteSpace(_logMainFolderPath) || 
                !Directory.Exists(_logMainFolderPath))
                return allRecords;

            // Step 1：取得所有子資料夾
            string[] subDirectories = System.IO.Directory.GetDirectories(_logMainFolderPath);

            // Step 2：遍歷每個子資料夾
            foreach (string dir in subDirectories)
            {
                string machineName = System.IO.Path.GetFileName(dir);

                // 檢查該機台是否在選單中，且被選中
                if (!allMachines.Any(m => m.Name == machineName && m.IsChecked))
                    continue; // 如果該機台未被選中，跳過

                // Step 3：取得該子資料夾下所有.log檔案
                string[] logFiles = System.IO.Directory.GetFiles(dir, "*.txt");

                // Step 4：遍歷每個.log檔案
                foreach (string logFile in logFiles)
                {
                    // Step 5：用串流逐行讀，避免一次載入整檔
                    using (var fs = new FileStream(logFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    using (var sr = new StreamReader(fs, DetectEncoding(fs) ?? Encoding.UTF8, true))
                    {
                        AlarmRecord current = null; // 目前正在累積的「一筆主行 + 多個續行」

                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            // Step 6：嘗試當作「主行」解析（[ts][level] ...)
                            if (TryParseHeader(line, out DateTime ts, out string level, out string msg))
                            {
                                // Step 6-1：收尾上一筆（若存在)
                                // 條件 : 符合等級 WARN & 符合日期
                                if (current != null && 
                                    IsWanted(current.Level) && 
                                    PassDate(current.Timestamp, isFilterDate, dateTimeFrom, dateTimeTo))
                                    allRecords.Add(current);

                                // Step 6-2：建立新主行
                                current = new AlarmRecord
                                {
                                    Timestamp = ts,
                                    Machine = machineName,
                                    Level = level,
                                    Module = "", // 需要的話再從 msg 裡用正則拆
                                    Code = "", // 需要的話再從 msg 裡用正則拆
                                    Message = msg?.Trim() ?? string.Empty,
                                    RawLine = line,
                                    FilePath = logFile
                                };

                                // (可選) Step 6-3：從主行訊息拆出 Module/Code/剩餘描述
                                //TryFillModuleCode(ref current);
                            }
                            else
                            {
                                // Step 7：不是主行 → 視為上一筆的續行，串接到 Message 末端
                                if (current != null)
                                {
                                    if (!string.IsNullOrWhiteSpace(line))
                                    {
                                        current.ContextLines.Add(line.Trim());
                                    }
                                }
                                // 若檔案一開始就是續行（理論上少見），就忽略
                            }
                        }

                        // Step 8：檔案讀完，收尾最後一筆
                        // 條件 : 符合等級 WARN & 符合日期
                        if (current != null && 
                            IsWanted(current.Level) && 
                            PassDate(current.Timestamp, isFilterDate, dateTimeFrom, dateTimeTo))
                            allRecords.Add(current);
                    }
                }
            }
            return allRecords;
        }
    }

    // 輔助靜態類別 - Helper
    public partial class AlarmService
    {

        // 判斷是否為主行：[yyyy-MM-dd HH:mm:ss] [LEVEL] 後接訊息
        // 用簡單正則；若格式較多可再擴充
        static readonly Regex _headerRx = new Regex(
            @"^\[(?<ts>[^\]]+)\]\s+\[(?<level>[A-Za-z]+)\]\s*(?<msg>.*)$",
            RegexOptions.Compiled);

        public static bool TryParseHeader(string line, out DateTime ts, out string level, out string msg)
        {
            ts = default;
            level = "";
            msg = "";

            if (string.IsNullOrEmpty(line) || line[0] != '[') return false;

            Match m = _headerRx.Match(line);
            if (!m.Success) return false;

            var tsStr = m.Groups["ts"].Value;
            if (!DateTime.TryParse(tsStr, out ts)) return false;

            level = m.Groups["level"].Value ?? "";
            msg = m.Groups["msg"].Value ?? "";
            return true;
        }

        // 只有 WARN 需要（你定義為「警報」）
        public static bool IsWanted(string level) =>
            string.Equals(level, "WARN", StringComparison.OrdinalIgnoreCase);

        // 日期篩選（含當日；用 Date 比較較直覺）
        public static bool PassDate(DateTime ts, bool useFilter, DateTime from, DateTime to)
        {
            if (!useFilter) return true;
            var d = ts.Date;
            return d >= from.Date && d <= to.Date;
        }

        // （可選）從主行訊息拆 Module/Code/Message
        // 例： "Main : TrayAndPP : 請確認輸入的產品資訊是否正確 ..."
        //static readonly Regex _moduleCodeRx = new Regex(@"^(?<module>[^:]+)\s*:\s*(?<code>[^:]+)\s*:\s*(?<rest>.*)$",
        //    RegexOptions.Compiled);

        //private static void TryFillModuleCode(ref AlarmRecord rec)
        //{
        //    var m = _moduleCodeRx.Match(rec.Message);
        //    if (!m.Success) return;
        //    rec.Module  = m.Groups["module"].Value.Trim();
        //    rec.Code    = m.Groups["code"].Value.Trim();
        //    rec.Message = m.Groups["rest"].Value.Trim();
        //}

        // 簡易 BOM 偵測（UTF8/UTF16）；沒抓到就交給 StreamReader 自動
        public static Encoding DetectEncoding(FileStream fs)
        {
            byte[] bom = new byte[4];
            int n = fs.Read(bom, 0, 4);
            fs.Position = 0;
            if (n >= 3 && bom[0] == 0xEF && bom[1] == 0xBB && bom[2] == 0xBF) return Encoding.UTF8;
            if (n >= 2)
            {
                if (bom[0] == 0xFF && bom[1] == 0xFE) return Encoding.Unicode;
                if (bom[0] == 0xFE && bom[1] == 0xFF) return Encoding.BigEndianUnicode;
            }
            return null;
        }
    }
}
