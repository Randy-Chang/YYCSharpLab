using System;

namespace Project_LBTToolBox.Services.AlarmsV2
{
    /// <summary>
    /// Alarm V2 查詢回傳的事件資料模型。
    /// </summary>
    public class AlarmEvent
    {
        /// <summary>事件時間（local）。</summary>
        public DateTime Timestamp { get; set; }

        /// <summary>機台名稱。</summary>
        public string Machine { get; set; }

        /// <summary>等級（例如 WARN/INFO）。</summary>
        public string Level { get; set; }

        /// <summary>穩定 WareCode（例如 E0001）。</summary>
        public string WareCode { get; set; }

        /// <summary>完整訊息（含續行合併內容）。</summary>
        public string Message { get; set; }

        /// <summary>原始主行。</summary>
        public string RawLine { get; set; }

        /// <summary>來源檔案路徑。</summary>
        public string FilePath { get; set; }
    }
}
