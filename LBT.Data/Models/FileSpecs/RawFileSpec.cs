using System.Collections.Generic;

namespace LBT.Data.Models.FileSpecs
{
    /// <summary>
    /// 描述一種 RawData 檔案的規格。
    /// 由 Profile 提供，IO Loader 依此讀取與解析。
    /// </summary>
    public class RawFileSpec
    {
        /// <summary>
        /// 用來尋找檔案的檔名模式（可用萬用字元或 Regex）。
        /// 例如 "*_0_LD_SweepI.csv"
        /// </summary>
        public string Pattern { get; set; } = string.Empty;

        /// <summary>
        /// 檔案類型（對應測試方法，如 LD Sweep、EA Sweep、OSA Sweep…）。
        /// </summary>
        public ERawDataType RawDataType { get; set; }

        /// <summary>
        /// 檔案應該出現的層級與數量（每 Lot / 每 Bar / 多份）。
        /// </summary>
        public FileScope Scope { get; set; }

        /// <summary>
        /// 原始欄位名稱對應到標準通道 (EChannel)。
        /// 例如 { "I(A)" → LD_Current, "V(V)" → LD_Voltage }。
        /// </summary>
        public Dictionary<string, EChannel> ColumnMappings { get; set; } = new Dictionary<string, EChannel>();
    }
}
