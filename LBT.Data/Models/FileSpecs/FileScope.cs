using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBT.Data.Models.FileSpecs
{
    /// <summary>
    /// 描述檔案應該出現的範圍與數量。
    /// </summary>
    public enum FileScope
    {
        /// <summary>
        /// 整個 Lot 一份。
        /// </summary>
        OnePerLot,

        /// <summary>
        /// 每個 Bar 一份。
        /// </summary>
        OnePerBar,

        /// <summary>
        /// 每個 Bar 可能有多份（例如不同條件下重複 Sweep）。
        /// </summary>
        ManyPerBar,

        /// <summary>
        /// 非必需，有就讀，沒有也可接受。
        /// </summary>
        Optional
    }
}

