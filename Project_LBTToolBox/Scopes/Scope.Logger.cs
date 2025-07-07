using LoggingUtilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_LBTToolBox.Scopes
{
    public partial class Scope
    {
        void InitializeLogger()
        {
            string logPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logs");
            LoggerService.Instance.Initialize(logPath, writeToConsole: true);
            LoggerService.Instance.Info("Logger 初始化完成");
        }
    }
    
}
