using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_LBTToolBox.Services.ChipIdCorrection
{
    /// <summary>
    /// 用來比對需要修正 OCR 的資料條件，避免誤傷其他晶粒。
    /// </summary>
    public class OcrMatchCriteria
    {
        public int Index { get; set; }
        public string TestTime { get; set; }
        public string BinX { get; set; }
        public string BinY { get; set; }
        public string TestSet { get; set; }

        /// <summary>
        /// 比對目標資料列是否符合條件（字串比對，可自行擴充模糊比對）。
        /// </summary>
        public bool IsMatch(string testTime, string binX, string binY, string testSet)
        {
            return string.Equals(TestTime, testTime)
                && string.Equals(BinX, binX)
                && string.Equals(BinY, binY)
                && string.Equals(TestSet, testSet);
        }
    }

}
