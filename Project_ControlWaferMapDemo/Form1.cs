using System.IO;
using System;
using System.Windows.Forms;
using YYControls.Controls.WaferMap;
using YYControls.Dialogs;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Project_ControlWaferMapDemo
{
    public partial class Form1 : Form
    {
        WaferMapControl waferMapControl;
        string _selectedPath;
        List<BPackData> bPackDatas = new List<BPackData>();

        public Form1()
        {
            InitializeComponent();
            InitializeWaferMapControl(out waferMapControl, panelWafer);

            btnLoadDatFile.Click += btnLoadDatFile_Click;
        }

        void InitializeWaferMapControl(out WaferMapControl wafer, Panel panel)
        {
            wafer = new WaferMapControl
            {
                Dock = DockStyle.Fill,
                ShowCellText = true,
                ShowGridLines = true
            };
            panel.Controls.Add(wafer);

            // 取得 bin/Debug/net48 等執行資料夾
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            // 回到專案根目錄（假設 csproj 在 bin 資料夾的上兩層）
            string projectDir = Directory.GetParent(baseDir).Parent.Parent.FullName;

            // 載入你的 BarOCRMap.csv / map.csv（矩陣：每列是 Row，每欄是 Col）
            wafer.LoadMapCsv($@"{projectDir}\BarOCRMap.csv");
            //wafer.LoadMapCsv($@"{projectDir}\BarOCRMap_Mini.csv");

            // 點擊回報
            wafer.DieClicked += (s, ev) =>
            {
                this.Text = $"Row={ev.Row}, Col={ev.Col}, Key={ev.CellText}";
            };
        }

        void btnLoadDatFile_Click(object sender, EventArgs e)
        {
            // 1) 選資料夾
            using (var dlg = new YYControls.Dialogs.FolderPickerDialog())
            {
                if (dlg.ShowDialog(this) != DialogResult.OK) return;
                _selectedPath = dlg.DirectoryPath;
            }

            // 2) 找出資料夾內所有 CSV
            var csvFiles = Directory.EnumerateFiles(_selectedPath, "*.csv", SearchOption.TopDirectoryOnly)
                                    .OrderBy(p => p, StringComparer.OrdinalIgnoreCase)
                                    .ToList();
            if (csvFiles.Count == 0)
            {
                MessageBox.Show("此資料夾沒有 .csv 檔。");
                return;
            }

            // 5) 讀取其他 CSV（非 map）→ 建立 ChipID→結果 的字典
            var status = new Dictionary<string, YYControls.Controls.WaferMap.DieStatus>(StringComparer.OrdinalIgnoreCase);
            
            foreach (var p in csvFiles)
            {
                var dt = LoadCsvToDataTable(p);        // 讀成 DataTable
                var partial = BuildStatusDictionary(dt); // 由 CHIP_ID / RESULT 產生映射
                foreach (var kv in partial) status[kv.Key] = kv.Value; // 後者覆蓋前者
            }

            // 6) 設定顏色偏好：Fail 紅、Pass 綠（你要更亮就換成 Color.Lime）
            waferMapControl.CellFillPass = Color.LimeGreen;
            waferMapControl.CellFillNg = Color.Red;

            // 7) 套用狀態 → 著色
            waferMapControl.SetStatus(status);
        }

        // 嘗試用檔名判斷 map；找不到時回 null
        private static string FindMapCsv(IEnumerable<string> csvs)
        {
            foreach (var p in csvs)
            {
                var name = Path.GetFileName(p);
                if (name.IndexOf("map", StringComparison.OrdinalIgnoreCase) >= 0
                 || name.IndexOf("ocr", StringComparison.OrdinalIgnoreCase) >= 0
                 || name.IndexOf("barocr", StringComparison.OrdinalIgnoreCase) >= 0)
                    return p;
            }
            return null;
        }

        private static DataTable LoadCsvToDataTable(string path)
        {
            var lines = ReadAllLinesWithEnc(path);
            var dt = new DataTable { TableName = Path.GetFileName(path) };
            if (lines.Length == 0) return dt;

            var header = SplitFlexible(lines[0]).Select(x => x.Trim()).ToArray();
            foreach (var h in header)
                dt.Columns.Add(string.IsNullOrWhiteSpace(h) ? $"COL_{dt.Columns.Count}" : h);

            for (int i = 1; i < lines.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lines[i])) continue;
                var cells = SplitFlexible(lines[i]).Select(x => (x ?? "").Trim()).ToArray();
                var row = dt.NewRow();
                for (int c = 0; c < dt.Columns.Count; c++)
                    row[c] = c < cells.Length ? cells[c] : "";
                dt.Rows.Add(row);
            }
            return dt;
        }

        private static string[] ReadAllLinesWithEnc(string path)
        {
            var encs = new[] { "utf-8-sig", "utf-8", "cp950", "big5", "latin1" };
            foreach (var name in encs)
            {
                try { return File.ReadAllLines(path, Encoding.GetEncoding(name)); }
                catch { /* try next */ }
            }
            return File.ReadAllLines(path, Encoding.UTF8);
        }

        private static string[] SplitFlexible(string line)
        {
            if (line.IndexOf('\t') >= 0) return line.Split('\t');
            if (line.IndexOf(';') >= 0) return line.Split(';');
            return line.Split(',');
        }

        // 從 DataTable 找出 "CHIP ID" 與 "RESULT" 欄位，組 chipID→狀態 的字典
        private static Dictionary<string, YYControls.Controls.WaferMap.DieStatus> BuildStatusDictionary(DataTable dt)
        {
            var map = new Dictionary<string, YYControls.Controls.WaferMap.DieStatus>(StringComparer.OrdinalIgnoreCase);
            if (dt.Columns.Count == 0) return map;

            // 正規化工具：移除底線與空白並轉大寫
            Func<string, string> norm = s =>
            {
                var sb = new StringBuilder();
                foreach (var ch in (s ?? ""))
                    if (ch != '_' && ch != ' ') sb.Append(char.ToUpperInvariant(ch));
                return sb.ToString();
            };

            // 欄位別名
            var idCandidates = new HashSet<string>(new[] { "CHIPID", "ChipID", "Chip_ID" });
            var resCandidates = new HashSet<string>(new[] { "RESULT"});

            string idCol = null, resCol = null;
            foreach (DataColumn col in dt.Columns)
            {
                var n = norm(col.ColumnName);
                if (idCol == null && idCandidates.Contains(n)) idCol = col.ColumnName;
                if (resCol == null && resCandidates.Contains(n)) resCol = col.ColumnName;
            }
            // 找不到就用第一欄當 id、最後一欄當 result（保守後備）
            if (idCol == null && dt.Columns.Count > 0) idCol = dt.Columns[0].ColumnName;
            if (resCol == null && dt.Columns.Count > 1) resCol = dt.Columns[dt.Columns.Count - 1].ColumnName;

            if (idCol == null || resCol == null) return map;

            foreach (DataRow row in dt.Rows)
            {
                var id = Convert.ToString(row[idCol]).Trim();
                var res = Convert.ToString(row[resCol]).Trim();
                if (id.Length == 0) continue;

                var status = ToStatus(res); // PASS/FAIL→顏色
                map[id] = status;
            }
            return map;
        }

        private static YYControls.Controls.WaferMap.DieStatus ToStatus(string res)
        {
            if (string.IsNullOrWhiteSpace(res))
                return YYControls.Controls.WaferMap.DieStatus.Unknown;

            var s = res.Trim().ToUpperInvariant();

            // 明確文字
            switch (s)
            {
                case "P":
                case "PASS":
                case "GOOD":
                case "OK":
                    return YYControls.Controls.WaferMap.DieStatus.Pass;
                case "F":
                case "FAIL":
                case "NG":
                case "BAD":
                    return YYControls.Controls.WaferMap.DieStatus.Ng;
            }

            // 如果 RESULT 是數字（如 BIN）：0/1 視為 Pass，其餘當 Fail（可依客戶調整）
            var digits = new string(s.Where(char.IsDigit).ToArray());
            int bin;
            if (digits.Length > 0 && int.TryParse(digits, out bin))
                return (bin == 0 || bin == 1) ? YYControls.Controls.WaferMap.DieStatus.Pass
                                              : YYControls.Controls.WaferMap.DieStatus.Ng;

            return YYControls.Controls.WaferMap.DieStatus.Unknown;
        }
    }

    class BPackData
    {
        public DataTable DataTable { get; }
        public string BPackName { get; }
        public string FilePath { get; }

        public BPackData(string filePath)
        {
            FilePath = filePath;
            BPackName = Path.GetFileNameWithoutExtension(filePath);
            DataTable = CsvUtil.LoadCsvToDataTable(filePath);
        }
    }

    static class CsvUtil
    {
        public static string[] ReadAllLinesWithEnc(string path)
        {
            foreach (var name in new[] { "utf-8-sig", "utf-8", "cp950", "big5", "latin1" })
            {
                try
                {
                    return File.ReadAllLines(path, Encoding.GetEncoding(name));
                }
                catch { /* try next */ }
            }
            return File.ReadAllLines(path, Encoding.UTF8);
        }

        public static string[] SplitFlexible(string line)
        {
            if (line.Contains("\t")) return line.Split('\t');
            if (line.Contains(";")) return line.Split(';');
            return line.Split(','); // 預設逗號
        }

        public static DataTable LoadCsvToDataTable(string path)
        {
            var lines = ReadAllLinesWithEnc(path);
            var dt = new DataTable { TableName = Path.GetFileName(path) };
            if (lines.Length == 0) return dt;

            var header = SplitFlexible(lines[0]).Select(x => x.Trim()).ToArray();
            foreach (var h in header)
                dt.Columns.Add(string.IsNullOrWhiteSpace(h) ? $"COL_{dt.Columns.Count}" : h);

            for (int i = 1; i < lines.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lines[i])) continue;
                var cells = SplitFlexible(lines[i]).Select(x => x.Trim()).ToArray();
                var row = dt.NewRow();
                for (int c = 0; c < dt.Columns.Count; c++)
                    row[c] = c < cells.Length ? cells[c] : "";
                dt.Rows.Add(row);
            }
            return dt;
        }
    }
}
