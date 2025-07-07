using System.Collections.Generic;
using System.Linq;

namespace Project_LBTToolBox.Services.ChipIdCorrection
{

    /// <summary>
    /// 表示一筆晶粒的資料記錄（對應 lotFile.csv 一行）。
    /// </summary>
    public class ChipRecord
    {
        public int Index { get; set; }
        public string OCR { get; set; } // 例如 0A66
        public string TestTime { get; set; }
        public string BinX { get; set; }
        public string BinY { get; set; }
        public string TestSet { get; set; }

        public string RawLine { get; set; } // 原始資料行，用於還原與覆寫

        /// <summary>
        /// Bar ID 是 OCR 的前兩碼。
        /// </summary>
        public string BarId
        {
            get
            {
                return !string.IsNullOrEmpty(OCR) && OCR.Length >= 2
                    ? OCR.Substring(0, 2)
                    : string.Empty;
            }
        }

        /// <summary>
        /// Chip ID 是 OCR 的後兩碼。
        /// </summary>
        public string ChipId
        {
            get
            {
                return !string.IsNullOrEmpty(OCR) && OCR.Length >= 4
                    ? OCR.Substring(2, 2)
                    : string.Empty;
            }
        }

        /// <summary>
        /// 轉換為比對 OCR 的條件資訊物件，用於資料檔案比對。
        /// </summary>
        public OcrMatchCriteria ToMatchCriteria()
        {
            return new OcrMatchCriteria
            {
                Index = this.Index,
                TestTime = this.TestTime,
                BinX = this.BinX,
                BinY = this.BinY,
                TestSet = this.TestSet
            };
        }

    }



}
