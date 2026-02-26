using System.Collections.Generic;

namespace Project_LBTToolBox.Services.AlarmsV2
{
    /// <summary>
    /// Alarm V2 的資料存取抽象。
    /// 目前由 SQLite 實作，後續可替換成其他 DB。
    /// </summary>
    public interface IAlarmRepository
    {
        /// <summary>
        /// 建立或更新資料表與索引結構。
        /// </summary>
        void EnsureSchema();

        /// <summary>
        /// 從指定資料夾匯入 log 檔資料至資料庫（含增量判斷）。
        /// </summary>
        /// <param name="rootFolderPath">機台 log 主資料夾路徑。</param>
        void IngestFromFolder(string rootFolderPath);

        /// <summary>
        /// 依條件查詢警報事件。
        /// </summary>
        /// <param name="query">查詢條件。</param>
        /// <returns>事件清單。</returns>
        List<AlarmEvent> QueryEvents(AlarmQuery query);
    }
}
