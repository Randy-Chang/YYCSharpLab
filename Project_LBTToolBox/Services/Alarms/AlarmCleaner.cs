using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Project_LBTToolBox.Services.Alarms
{
    public static class AlarmCleaner
    {
        public static List<AlarmRecord> FilterRecordByIgnoreMessage(
            List<AlarmRecord> records,
            List<string> ignorePatterns)
        {
            if (records == null || records.Count == 0)
                return new List<AlarmRecord>();

            if (ignorePatterns == null || ignorePatterns.Count == 0)
                return new List<AlarmRecord>(records);

            List<AlarmRecord> filteredRecords = new List<AlarmRecord>();

            foreach (AlarmRecord alarmRecord in records)
            {
                // Step 1: 只保留 WARN
                if (alarmRecord.Level != "WARN")
                    continue;

                string message = alarmRecord.Message ?? string.Empty;

                bool shouldIgnore = false;

                // Step 2: 比對是否包含忽略關鍵字
                foreach (string pattern in ignorePatterns)
                {
                    if (!string.IsNullOrWhiteSpace(pattern) &&
                        message.Contains(pattern))
                    {
                        shouldIgnore = true;
                        break; // 命中就不用再比對其他規則
                    }
                }

                // Step 3: 沒有命中忽略規則 → 加入結果清單
                if (!shouldIgnore)
                    filteredRecords.Add(alarmRecord);
            }

            return filteredRecords;
        }


    }
}
