using Project_LBTToolBox.Services.Alarms;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Project_LBTToolBox.Services.AlarmsV2
{
    /// <summary>
    /// Alarm V2 查詢服務：
    /// 1) 將 repository 回傳的 AlarmEvent 轉成既有 AlarmRecord
    /// 2) 建立 WareCode 對應表給 UI 顯示
    /// </summary>
    public class AlarmQueryService
    {
        private readonly IAlarmRepository _repository;

        /// <summary>
        /// 建立查詢服務。
        /// </summary>
        /// <param name="repository">資料存取實作。</param>
        public AlarmQueryService(IAlarmRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        /// <summary>
        /// 查詢並轉換為舊版 UI 可直接使用的 AlarmRecord。
        /// </summary>
        /// <param name="query">查詢條件。</param>
        /// <returns>AlarmRecord 清單。</returns>
        public List<AlarmRecord> QueryAlarmRecords(AlarmQuery query)
        {
            List<AlarmEvent> events = _repository.QueryEvents(query);

            List<AlarmRecord> records = new List<AlarmRecord>(events.Count);
            foreach (AlarmEvent e in events)
            {
                records.Add(new AlarmRecord
                {
                    Timestamp = e.Timestamp,
                    Machine = e.Machine,
                    Level = e.Level,
                    Code = e.WareCode,
                    Message = e.Message,
                    RawLine = e.RawLine,
                    FilePath = e.FilePath,
                    Module = string.Empty
                });
            }

            return records;
        }

        /// <summary>
        /// 從查詢結果建立 WareCode -> Message 對照表（僅 WARN）。
        /// </summary>
        /// <param name="records">警報記錄。</param>
        /// <returns>WareCode 對應訊息內容。</returns>
        public Dictionary<string, string> BuildWareCodeMap(IEnumerable<AlarmRecord> records)
        {
            var map = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            if (records == null)
                return map;

            foreach (AlarmRecord r in records)
            {
                if (!string.Equals(r.Level, "WARN", StringComparison.OrdinalIgnoreCase))
                    continue;

                string code = r.Code ?? string.Empty;
                if (string.IsNullOrWhiteSpace(code))
                    continue;

                if (!map.ContainsKey(code))
                    map[code] = r.Message ?? string.Empty;
            }

            return map;
        }
    }
}
