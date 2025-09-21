using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBT.Data.Models.FileSpecs
{
    /// <summary>
    /// 描述一種 Lot 級檔案的規格。
    /// 例如 lotFile.csv 或 ModuleFileByBroadcom.csv。
    /// </summary>
    public class LotFileSpec
    {
        /// <summary>
        /// 用來尋找檔案的檔名模式（可用萬用字元或 Regex）。
        /// 例如 "*_lotFile.csv"。
        /// </summary>
        public string Pattern { get; set; } = string.Empty;

        /// <summary>
        /// 檔案應該出現的層級與數量。
        /// 通常是 OnePerLot。
        /// </summary>
        public FileScope Scope { get; set; }

        /// <summary>
        /// 原始欄位名稱對應到標準欄名（字串，而不是 EChannel）。
        /// 例如 { "ChipID" → "ChipId", "Index" → "DieIndex" }。
        /// </summary>
        public Dictionary<string, string> ColumnMappings { get; set; } = new Dictionary<string, string>();
        
    }
}

