using System;

namespace Project_LBTToolBox.Services.AlarmsV2
{
    /// <summary>
    /// Alarm V2 匯入服務：負責觸發 schema 建立與資料匯入。
    /// </summary>
    public class AlarmIngestionService
    {
        private readonly IAlarmRepository _repository;

        /// <summary>
        /// 建立匯入服務。
        /// </summary>
        /// <param name="repository">資料存取實作。</param>
        public AlarmIngestionService(IAlarmRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        /// <summary>
        /// 執行匯入流程（先確保 schema，再匯入）。
        /// </summary>
        /// <param name="rootFolderPath">機台 log 主資料夾路徑。</param>
        public void Ingest(string rootFolderPath)
        {
            _repository.EnsureSchema();
            _repository.IngestFromFolder(rootFolderPath);
        }
    }
}
