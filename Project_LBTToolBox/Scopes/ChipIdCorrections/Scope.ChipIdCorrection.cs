using LoggingUtilities;
using Project_LBTToolBox.Services.ChipIdCorrection;
using Project_LBTToolBox.Services.ChipIdCorrection.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static Project_LBTToolBox.Scopes.Scope;

namespace Project_LBTToolBox.Scopes
{
    public partial class Scope
    {
        ChipIdCorrectionService chipIdCorrectionService;
        FileSystemProvider fileSystemProvider;
        LotFileParserCsv lotFileParserCsv;
        CsvDataFileEditor csvDataFileEditor;
        UIFeedbackWinForms uIFeedbackWinForms;

        void InitializeChipIdCorrectionService()
        {
            fileSystemProvider = new FileSystemProvider();
            lotFileParserCsv = new LotFileParserCsv();
            csvDataFileEditor = new CsvDataFileEditor();

            chipIdCorrectionService = new ChipIdCorrectionService(fileSystemProvider,
                                                                    lotFileParserCsv,
                                                                    csvDataFileEditor,
                                                                    LoggerService.Instance,
                                                                    uIFeedbackWinForms
                                                                    );

            LoggerService.Instance.Info("芯片ID校正服務初始化完成");
        }
    }

    public partial class Scope
    {
        public class FileSystemProvider : IFileSystemProvider
        {
            public string LocateBarFolder(string projectRootPath, string firstOcr)
            {
                var dirs = Directory.GetDirectories(projectRootPath, "*", SearchOption.AllDirectories);
                return dirs.FirstOrDefault(dir => dir.Contains($"_{firstOcr}_"));
            }

            public string[] GetAllLotFilePaths(string rootPath)
            {
                return Directory.GetFiles(rootPath, "*lotFile.csv", SearchOption.AllDirectories);
            }

            public string[] GetDataFilesInBarFolder(string barFolderPath)
            {
                return Directory.GetFiles(barFolderPath, "*.csv")
                                .Where(f => !f.EndsWith("lotFile.csv", StringComparison.OrdinalIgnoreCase))
                                .ToArray();
            }
        }

        /// <summary>
        /// 以 CSV 檔案為基礎的 lotFile 解析與儲存實作，只關注 Index 與 OCR 欄位，保留其餘欄位原樣。
        /// </summary>
        public class LotFileParserCsv : ILotFileParser
        {
            /// <summary>
            /// 從檔案載入 lotFile，並解析為 LotFile 資料模型。
            /// </summary>
            /// <param name="filePath">檔案路徑</param>
            /// <param name="skipHeaderCount">要略過的前幾行（主 lotFile 通常為 2）</param>
            public LotFile LoadLotFile(string filePath, int skipHeaderCount = 0)
            {
                var lines = File.ReadAllLines(filePath).ToList();
                var lotFile = new LotFile();

                if (skipHeaderCount >= 1 && lines.Count >= 1)
                    lotFile.InfoLine = lines[0];

                if (skipHeaderCount >= 2 && lines.Count >= 2)
                    lotFile.HeaderLine = lines[1];

                for (int i = skipHeaderCount; i < lines.Count; i++)
                {
                    var line = lines[i];
                    var parts = line.Split(',');
                    if (parts.Length < 2) continue;

                    lotFile.Records.Add(new ChipRecord
                    {
                        Index = i - skipHeaderCount,
                        OCR = parts[0],
                        RawLine = line
                    });
                }

                return lotFile;
            }

            public void SaveLotFile(string filePath, LotFile lotFile)
            {
                var lines = new List<string>();

                if (!string.IsNullOrWhiteSpace(lotFile.InfoLine)) lines.Add(lotFile.InfoLine);
                if (!string.IsNullOrWhiteSpace(lotFile.HeaderLine)) lines.Add(lotFile.HeaderLine);

                lines.AddRange(lotFile.Records.Select(r =>
                {
                    var parts = r.RawLine.Split(',');
                    if (parts.Length > 1)
                        parts[0] = r.OCR;
                    return string.Join(",", parts);
                }));

                File.WriteAllLines(filePath, lines);
            }
        }



        /// <summary>
        /// 根據條件比對，在 CSV 資料檔案中替換 OCR（ChipID）欄位內容。
        /// </summary>
        public class CsvDataFileEditor : IDataFileEditor
        {
            public void ReplaceOcrInBarFolder_BySubIndex(
    string barFolderPath,
    string oldOcr,
    string newOcr,
    int subIndex,
    int chipCountInSubLot)
            {
                var allCsvFiles = Directory.GetFiles(barFolderPath, "*.csv");

                foreach (var file in allCsvFiles)
                {
                    var lines = File.ReadAllLines(file).ToList();
                    if (lines.Count < 2) continue;

                    var header = lines[0];
                    var headerParts = header.Split(',');
                    int chipIdIndex = Array.IndexOf(headerParts, "ChipID");
                    if (chipIdIndex < 0) continue;

                    int totalDataRows = lines.Count - 1;
                    int rowsPerChip = totalDataRows / chipCountInSubLot;

                    if (rowsPerChip * chipCountInSubLot != totalDataRows)
                    {
                        // 不整除，顯示警告
                        Console.WriteLine($"⚠️ 警告：{Path.GetFileName(file)} 行數與晶粒數不整除。請確認資料正確性。");
                    }

                    // 計算本次要修改的起訖範圍
                    int startRow = 1 + subIndex * rowsPerChip;
                    int endRow = Math.Min(startRow + rowsPerChip, lines.Count);

                    for (int i = startRow; i < endRow; i++)
                    {
                        var parts = lines[i].Split(',');
                        if (parts.Length > chipIdIndex && parts[chipIdIndex] == oldOcr)
                        {
                            parts[chipIdIndex] = newOcr;
                            lines[i] = string.Join(",", parts);
                        }
                    }

                    // 寫回檔案（保留標頭）
                    File.WriteAllLines(file, lines);
                }
            }




        }

        public class UIFeedbackWinForms : IUIFeedback
        {
            private readonly DataGridView _grid;
            private readonly Control _owner;

            public UIFeedbackWinForms(Control owner, DataGridView grid)
            {
                _owner = owner;
                _grid = grid;
            }

            public void ShowMessage(string message)
            {
                MessageBox.Show(_owner, message, "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            public void ShowError(string message)
            {
                MessageBox.Show(_owner, message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            public void HighlightRow(int index)
            {
                foreach (DataGridViewRow row in _grid.Rows)
                {
                    if (row.Index == index)
                    {
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.Yellow;
                        row.Selected = true;
                        _grid.FirstDisplayedScrollingRowIndex = index;
                        break;
                    }
                }
            }
        }

    }
}
