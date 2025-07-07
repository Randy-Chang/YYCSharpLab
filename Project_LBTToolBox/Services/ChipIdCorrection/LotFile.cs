using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_LBTToolBox.Services.ChipIdCorrection
{
    /// <summary>
    /// 封裝一份 lotFile.csv 的所有晶粒資料紀錄，提供查詢與 OCR 更新功能。
    /// </summary>
    public class LotFile
    {
        /// <summary>產品資訊列（例如機種/批號說明），通常為第一列</summary>
        public string InfoLine { get; set; }

        /// <summary>欄位標頭（通常第二列）</summary>
        public string HeaderLine { get; set; }

        /// <summary>晶粒資料列（從第 3 列開始）</summary>
        public List<ChipRecord> Records { get; set; }

        public LotFile()
        {
            Records = new List<ChipRecord>();
        }

        public ChipRecord FindByIndex(int index) =>
            Records.FirstOrDefault(r => r.Index == index);

        public List<ChipRecord> FindAllByBarId(string barId) =>
            Records.Where(r => !string.IsNullOrEmpty(r.OCR) && r.OCR.StartsWith(barId)).ToList();

        public void UpdateOcr(int index, string newOcr)
        {
            var target = FindByIndex(index);
            if (target != null) target.OCR = newOcr;
        }
    }

}
