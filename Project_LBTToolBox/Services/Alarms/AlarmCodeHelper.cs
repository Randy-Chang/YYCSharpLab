using ScottPlot.Drawing.Colormaps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_LBTToolBox.Services.Alarms
{
    public static class AlarmCodeHelper
    {
        public static void AttachedWarnCode(ref List<AlarmRecord> alarmRecords, 
                                            out Dictionary<string, string> warnCodeWithMessage)
        {
            warnCodeWithMessage = new Dictionary<string, string>();

            if (alarmRecords == null || alarmRecords.Count == 0) return;

            List<string> messageType = new List<string>();

            foreach (var record in alarmRecords)
            {
                if(record.Level != "WARN") continue;

                string msg = record.Message ?? string.Empty;

                if(messageType.Contains(msg) == false)
                    messageType.Add(msg);
            }

            foreach (var record in alarmRecords)
            {
                if (record.Level != "WARN") continue;

                string msg = record.Message ?? string.Empty;

                if(messageType.Contains(msg))
                {
                    int index = messageType.IndexOf(msg);
                    record.Code = $"E{index + 1:D3}";
                    warnCodeWithMessage[record.Code] = msg;
                }
                else
                {
                    record.Code = "E999";
                    warnCodeWithMessage[record.Code] = msg;
                }
            }
        }
    }
}
