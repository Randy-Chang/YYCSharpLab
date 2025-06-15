using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingUtilities
{
    /// <summary>
    /// Global logger service (thread-safe singleton).
    /// Provides file-based and optional console logging. Supports info, error, and debug logs.
    /// 全域日誌記錄服務（執行緒安全單例）。
    /// 提供檔案與（可選）Console 輸出，支援 Info/Error/Debug 分級。
    /// </summary>
    public sealed partial class LoggerService
    {
        private static readonly Lazy<LoggerService> _instance = new Lazy<LoggerService>(() => new LoggerService());
        public static LoggerService Instance { get { return _instance.Value; } }

        private string _logFolder; // 日誌檔案存放資料夾
        private bool _writeToConsole; // 是否同步在 Console 顯示 log
        private readonly object _fileLock = new object(); // 寫檔鎖，多執行緒下避免檔案寫入競爭

        private LoggerService() { } // 私有建構函式，確保單例模式

        /// <summary>
        /// Initialize logger with folder path and console option.
        /// 初始化日誌記錄器。
        /// </summary>
        /// <param name="logFolderPath">Folder to save log files.</param>
        /// <param name="writeToConsole">Write to console also?</param>
        public void Initialize(string logFolderPath, bool writeToConsole = false)
        {
            _logFolder = logFolderPath;
            _writeToConsole = writeToConsole;
            if (!Directory.Exists(_logFolder))
                Directory.CreateDirectory(_logFolder);
        }

        /// <summary>
        /// Ensure the logger is initialized before writing logs.
        /// 在寫入日誌之前，請確保日誌記錄器已經初始化。
        /// </summary>
        /// <exception cref="InvalidOperationException"></exception>
        private void EnsureInitialized()
        {
            if (string.IsNullOrWhiteSpace(_logFolder))
                throw new InvalidOperationException("LoggerService not initialized. Please call Initialize() first.");
        }

        private void Write(LogLevel level, string message)
        {
            EnsureInitialized();
            string path = Path.Combine(_logFolder, "log_" + DateTime.Now.ToString("yyyyMMdd") + ".txt");
            string levelStr = level.ToString().ToUpper();
            string content = "[" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "] [" + levelStr + "] " + message;

            lock (_fileLock)
            {
                try
                {
                    File.AppendAllText(path, content + Environment.NewLine);
                }
                catch (Exception ex)
                {
                    if (_writeToConsole)
                        Console.WriteLine("[LOGGER ERROR] " + ex.Message);
                }
            }
            if (_writeToConsole)
                Console.WriteLine(content);
        }

    }

    public sealed partial class LoggerService : ILoggerService
    {
        /// <summary>
        /// Write an info log.
        /// </summary>
        public void Info(string message) { Write(LogLevel.Info, message); }

        /// <summary>
        /// Write an error log.
        /// </summary>
        public void Error(string message) { Write(LogLevel.Error, message); }

        /// <summary>
        /// Write an exception as error log.
        /// </summary>
        public void Error(Exception ex) { Write(LogLevel.Error, ex.Message + "\n" + ex.StackTrace); }

        /// <summary>
        /// Write a debug log.
        /// </summary>
        public void Debug(string message) { Write(LogLevel.Debug, message); }
    }
}
