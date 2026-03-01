using System;
using System.Collections.Generic;

namespace Project_LBTToolBox.Services.AlarmsV2
{
    /// <summary>
    /// Alarm V2 查詢條件。
    /// </summary>
    public class AlarmQuery
    {
        /// <summary>是否啟用日期區間過濾。</summary>
        public bool UseDateFilter { get; set; }

        /// <summary>日期區間起始（含當日）。</summary>
        public DateTime DateFrom { get; set; }

        /// <summary>日期區間結束（含當日）。</summary>
        public DateTime DateTo { get; set; }

        /// <summary>機台名稱清單；空集合代表不限制。</summary>
        public List<string> SelectedMachines { get; set; } = new List<string>();

        /// <summary>等級過濾，預設 WARN。</summary>
        public string Level { get; set; } = "WARN";

        /// <summary>指定 WareCode；空字串代表不限制。</summary>
        public string WareCode { get; set; }
    }
}
