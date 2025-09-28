using System;
using System.Collections.Generic;
using System.Linq;

namespace Project_LBTToolBox.Services.Alarms
{
    public class AlarmStatistics
    {
        // 原始資料（如不想保存可移除）
        private readonly List<AlarmRecord> _records;

        // ── 基本統計 ──────────────────────────────────────────────
        public int TotalCount { get; private set; }
        public Dictionary<string, int> CountsByLevel { get; private set; }
        public Dictionary<string, int> CountsByCode { get; private set; }
        public Dictionary<string, int> CountsByMachine { get; private set; }
        public SortedDictionary<DateTime, int> DailyCounts { get; private set; } // date-only

        // ── 進一步切片 ────────────────────────────────────────────
        public Dictionary<string, SortedDictionary<DateTime, int>> MachineDailyCounts { get; private set; }
        public Dictionary<string, Dictionary<string, int>> MachineCodeCounts { get; private set; }
        public Dictionary<string, SortedDictionary<DateTime, int>> CodeDailyCounts { get; private set; }

        // ── 時段統計 ──────────────────────────────────────────────
        public int[] HourOfDayHistogram { get; private set; } = new int[24];

        // （可選）模組/矩陣
        public Dictionary<string, int> ModuleCounts { get; private set; }
        public Dictionary<string, Dictionary<string, int>> ModuleCodeMatrix { get; private set; }

        private AlarmStatistics(List<AlarmRecord> records)
        {
            _records = records;
        }

        /// <summary>
        /// 建立統計結果。預設會把 Timestamp 轉成 Date（不含時分秒）來做日統計。
        /// 你可以在呼叫前就先把 records 過濾成「只包含 WARN」或特定機台/日期區間。
        /// </summary>
        public static AlarmStatistics Build(IEnumerable<AlarmRecord> records)
        {
            var list = records?.ToList() ?? new List<AlarmRecord>();
            var stats = new AlarmStatistics(list);

            // ── 基本統計 ──────────────────────────────────────────
            stats.TotalCount = list.Count;

            stats.CountsByLevel = list
                .GroupBy(r => r.Level ?? string.Empty)
                .ToDictionary(g => g.Key, g => g.Count(), StringComparer.OrdinalIgnoreCase);

            stats.CountsByCode = list
                .GroupBy(r => r.Code ?? string.Empty)
                .ToDictionary(g => g.Key, g => g.Count(), StringComparer.OrdinalIgnoreCase);

            stats.CountsByMachine = list
                .GroupBy(r => r.Machine ?? string.Empty)
                .ToDictionary(g => g.Key, g => g.Count(), StringComparer.OrdinalIgnoreCase);

            stats.DailyCounts = new SortedDictionary<DateTime, int>(
                list.GroupBy(r => r.Timestamp.Date)
                    .OrderBy(g => g.Key)
                    .ToDictionary(g => g.Key, g => g.Count())
            );

            // ── 機台 × 日 ─────────────────────────────────────────
            stats.MachineDailyCounts = list
                .GroupBy(r => r.Machine ?? string.Empty)
                .ToDictionary(
                    mg => mg.Key,
                    mg => new SortedDictionary<DateTime, int>(
                        mg.GroupBy(r => r.Timestamp.Date)
                          .OrderBy(g => g.Key)
                          .ToDictionary(g => g.Key, g => g.Count())
                    ),
                    StringComparer.OrdinalIgnoreCase
                );

            // ── 機台 × 代碼 ────────────────────────────────────────
            stats.MachineCodeCounts = list
                .GroupBy(r => r.Machine ?? string.Empty)
                .ToDictionary(
                    mg => mg.Key,
                    mg => mg.GroupBy(r => r.Code ?? string.Empty)
                            .ToDictionary(g => g.Key, g => g.Count(), StringComparer.OrdinalIgnoreCase),
                    StringComparer.OrdinalIgnoreCase
                );

            // ── 代碼 × 日（看單一 Code 是否升溫） ───────────────────
            stats.CodeDailyCounts = list
                .GroupBy(r => r.Code ?? string.Empty)
                .ToDictionary(
                    cg => cg.Key,
                    cg => new SortedDictionary<DateTime, int>(
                        cg.GroupBy(r => r.Timestamp.Date)
                          .OrderBy(g => g.Key)
                          .ToDictionary(g => g.Key, g => g.Count())
                    ),
                    StringComparer.OrdinalIgnoreCase
                );

            // ── 24 小時分佈（看高發時段） ──────────────────────────
            var hourHist = new int[24];
            foreach (var r in list)
                hourHist[r.Timestamp.Hour]++;
            stats.HourOfDayHistogram = hourHist;

            // （可選）模組/矩陣：如果你有填 Module/Code
            stats.ModuleCounts = list
                .GroupBy(r => r.Module ?? string.Empty)
                .ToDictionary(g => g.Key, g => g.Count(), StringComparer.OrdinalIgnoreCase);

            stats.ModuleCodeMatrix = list
                .GroupBy(r => r.Module ?? string.Empty)
                .ToDictionary(
                    mg => mg.Key,
                    mg => mg.GroupBy(r => r.Code ?? string.Empty)
                            .ToDictionary(g => g.Key, g => g.Count(), StringComparer.OrdinalIgnoreCase),
                    StringComparer.OrdinalIgnoreCase
                );

            return stats;
        }

        public string GetMaxCountMachineNumber()
        {
            string maxMachine = "";

            if (CountsByMachine != null && CountsByMachine.Count > 0)
            {
                int maxCount = CountsByMachine.Values.Max();
                maxMachine = CountsByMachine.First(kv => kv.Value == maxCount).Key;
            }

            return maxMachine;
        }

        // ── 便利方法（給 UI 用） ──────────────────────────────────

        public List<KeyValuePair<string, int>> GetTopCodes(int n)
        {
            return CountsByCode
                .OrderByDescending(kv => kv.Value)
                .ThenBy(kv => kv.Key)
                .Take(n)
                .ToList();
        }

        public List<KeyValuePair<string, int>> GetTopMachines(int n)
        {
            return CountsByMachine
                .OrderByDescending(kv => kv.Value)
                .ThenBy(kv => kv.Key)
                .Take(n)
                .ToList();
        }

        public SortedDictionary<DateTime, int> GetTrendForMachine(string machine)
        {
            if (string.IsNullOrEmpty(machine)) return new SortedDictionary<DateTime, int>();
            return MachineDailyCounts.TryGetValue(machine, out var dict) ? dict : new SortedDictionary<DateTime, int>();
        }

        public Dictionary<string, int> GetCodesForMachine(string machine)
        {
            if (string.IsNullOrEmpty(machine)) return new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            return MachineCodeCounts.TryGetValue(machine, out var dict) ? dict : new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
        }

        public SortedDictionary<DateTime, int> GetTrendForCode(string code)
        {
            if (string.IsNullOrEmpty(code)) return new SortedDictionary<DateTime, int>();
            return CodeDailyCounts.TryGetValue(code, out var dict) ? dict : new SortedDictionary<DateTime, int>();
        }
    }
}
