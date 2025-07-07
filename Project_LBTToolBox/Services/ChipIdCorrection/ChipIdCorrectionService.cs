using LoggingUtilities;
using Project_LBTToolBox.Services.ChipIdCorrection.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Project_LBTToolBox.Services.ChipIdCorrection
{
    public partial class ChipIdCorrectionService
    {
        private readonly IFileSystemProvider _fileSystem;
        private readonly ILotFileParser _lotFileParser;
        private readonly IDataFileEditor _dataEditor;
        private readonly ILoggerService _logger; // optional log hook
        private readonly IUIFeedback _ui; // 注入 UI 介面如顯示訊息、異常

        public ChipIdCorrectionService(
            IFileSystemProvider fileSystem,
            ILotFileParser lotFileParser,
            IDataFileEditor dataEditor,
            ILoggerService logger,
            IUIFeedback ui)
        {
            _fileSystem = fileSystem;
            _lotFileParser = lotFileParser;
            _dataEditor = dataEditor;
            _logger = logger;
            _ui = ui;
        }

        public void ApplyCorrection(string folderPath, int index, string correctOcr)
        {
            string lotFilePath = Directory
                    .GetFiles(folderPath, "*_lotFile.csv", SearchOption.TopDirectoryOnly)
                    .FirstOrDefault();
            string chipDataFolderPath = folderPath + @"\ChipData";

            // 1. 載入主 lotFile.csv 並找出該 Index 對應的 OCR (原始OCR)
            var mainLot = _lotFileParser.LoadLotFile(lotFilePath, 2);
            var originalRecord = mainLot.FindByIndex(index);
            var originalOcr = originalRecord.OCR;
            var barId = correctOcr.Substring(0, 2); // 例如 "0A"

            // 2. 找出該 Bar 下的所有 OCR，可能為遞增或遞減順序
            var (barGroup, subIndex) = LocateBarGroupByIndex(mainLot, index);
            string firstOcr = barGroup.First().OCR;
            string subFolder = _fileSystem.LocateBarFolder(chipDataFolderPath, firstOcr);
            if (subFolder == null)
            {
                _logger.Error($"無法定位子資料夾");
                _ui.ShowMessage($"無法定位子資料夾");
            }

            // 3. 進入子 lotFile.csv → 找到 index = N 的那筆 OCR
            string subLotFilePath = Directory
                    .GetFiles(subFolder, "*_lotFile.csv", SearchOption.TopDirectoryOnly)
                    .FirstOrDefault();

            var barLot = _lotFileParser.LoadLotFile(subLotFilePath, 1);
            var subRecord = barLot.FindByIndex(subIndex);
            int chipCountInSubLot = barLot.Records.Count;

            // 4. 用該筆資料比對數據檔案中對應的舊 OCR 位置
            var oldOcr = subRecord.OCR;

            // 5. 修改子資料夾下 6 個測試檔案中符合 criteria 的 OCR
            _dataEditor.ReplaceOcrInBarFolder_BySubIndex(subFolder, oldOcr, correctOcr, subIndex, chipCountInSubLot);

            // 7. 更新主 lotFile 中該筆 OCR
            mainLot.UpdateOcr(index, correctOcr);
            _lotFileParser.SaveLotFile(lotFilePath, mainLot);

            _logger.Error($"Index {index} OCR updated from {oldOcr} to {correctOcr}");
            //_ui.ShowMessage($"修正完成：Index {index} → {correctOcr}");
        }

        
    }

    public partial class ChipIdCorrectionService
    {
        private string TryLocateBarFolder(string root, List<string> ocrCandidates)
        {
            foreach (var ocr in ocrCandidates)
            {
                var path = _fileSystem.LocateBarFolder(root, ocr);
                if (Directory.Exists(path))
                    return path;
            }
            return null;
        }

        /// <summary>
        /// 從主 lotFile 中依照順序將資料分成多個 Bar 群組。
        /// 然後找出指定 index 屬於哪一個群組，並取得該群組與其在其中的 subIndex。
        /// </summary>
        /// <param name="lot">主 lotFile 資料</param>
        /// <param name="targetIndex">使用者輸入的 Index</param>
        /// <returns>回傳一個群組與其中的 subIndex</returns>
        private (List<ChipRecord> barGroup, int subIndexInBar) LocateBarGroupByIndex(LotFile lot, int targetIndex)
        {
            List<List<ChipRecord>> allGroups = new List<List<ChipRecord>>();
            List<ChipRecord> currentGroup = new List<ChipRecord>();
            string lastBarId = null;

            // 按 Index 排序，確保順序處理
            var sortedRecords = lot.Records.OrderBy(r => r.Index).ToList();

            foreach (var record in sortedRecords)
            {
                // 如果 BarId 變了，就切出一個新群組
                if (lastBarId != null && record.BarId != lastBarId)
                {
                    allGroups.Add(currentGroup);
                    currentGroup = new List<ChipRecord>();
                }

                currentGroup.Add(record);
                lastBarId = record.BarId;
            }

            // 加入最後一組
            if (currentGroup.Count > 0)
                allGroups.Add(currentGroup);

            // 逐組檢查哪一組包含目標 Index
            foreach (var group in allGroups)
            {
                for (int i = 0; i < group.Count; i++)
                {
                    if (group[i].Index == targetIndex)
                    {
                        return (group, i); // 傳回此組與在其中的 index
                    }
                }
            }

            throw new Exception($"找不到 index={targetIndex} 對應的 Bar 群組");
        }


    }
}


