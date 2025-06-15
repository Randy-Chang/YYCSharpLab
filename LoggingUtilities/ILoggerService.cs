using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingUtilities
{
    public enum LogLevel
    {
        Info,
        Error,
        Debug,
        Warn,    // 之後有需要可繼續加
        Trace
    }

    /// <summary>
    /// 日誌記錄服務介面。
    /// Logger service interface for abstraction and testing.
    /// </summary>
    public interface ILoggerService
    {
        /// <summary>紀錄資訊。</summary>
        void Info(string message);

        /// <summary>紀錄錯誤。</summary>
        void Error(string message);

        /// <summary>紀錄例外。</summary>
        void Error(Exception ex);

        /// <summary>紀錄除錯訊息。</summary>
        void Debug(string message);
    }

}
