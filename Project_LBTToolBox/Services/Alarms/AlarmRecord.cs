using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_LBTToolBox.Services.Alarms
{
    public class AlarmRecord
    {
        public DateTime Timestamp { get; set; } // 時間戳
        public string Machine { get; set; }     // 子資料夾名
        public string Level { get; set; }       // INFO/WARN/ERROR...
        public string Module { get; set; }      // 暫時無
        public string Code { get; set; }        // 暫時無
        public string Message { get; set; }     // 中文描述
        public string RawLine { get; set; }     // 原始行
        public string FilePath { get; set; }    // 來源檔案
    }

}
