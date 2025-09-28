using ScottPlot;              // v4.x
using ScottPlot.WinForms;    // 若你是先拖拉 FormsPlot 到設計器，通常不用特別加
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Project_LBTToolBox.Services.Alarms
{
    public static partial class AlarmChartsV4
    {

        // 1) Code → 次數（Bar）
        public static void PlotCodeBar(FormsPlot fp, Dictionary<string, int> countsByCode,
            int topN = 10, bool showValues = true, string title = "Code Frequency")
        {
            fp.Plot.Clear();
            if (countsByCode == null || countsByCode.Count == 0) { fp.Refresh(); return; }

            var items = countsByCode.OrderByDescending(kv => kv.Value).Take(topN).ToList();
            double[] values = items.Select(kv => (double)kv.Value).ToArray();
            string[] labels = items.Select(kv => kv.Key).ToArray();
            double[] xs = Enumerable.Range(0, values.Length).Select(i => (double)i).ToArray();

            var bar = fp.Plot.AddBar(values);
            bar.BarWidth = 0.8;

            fp.Plot.XTicks(xs, labels);
            fp.Plot.XAxis.TickLabelStyle(rotation: 45);
            fp.Plot.Title(title);
            fp.Plot.YLabel("Count");
            fp.Plot.SetAxisLimits(yMin: 0);

            if (showValues)
                AddBarValueLabels(fp, xs, values, "{0}");

            SetAxisFonts(fp, tickSize: 16, labelSize: 16, xTickRotation: 45);
            fp.Refresh();
        }

        // 2) 機台 → 次數（Bar）
        public static void PlotMachineBar(FormsPlot fp, Dictionary<string, int> countsByMachine,
            int topN = 20, bool showValues = true, string title = "Alarms by Machine")
        {
            fp.Plot.Clear();
            if (countsByMachine == null || countsByMachine.Count == 0) { fp.Refresh(); return; }

            var items = countsByMachine.OrderByDescending(kv => kv.Value).Take(topN).ToList();
            double[] values = items.Select(kv => (double)kv.Value).ToArray();
            string[] labels = items.Select(kv => kv.Key).ToArray();
            double[] xs = Enumerable.Range(0, values.Length).Select(i => (double)i).ToArray();

            var bar = fp.Plot.AddBar(values);
            bar.BarWidth = 0.8;

            fp.Plot.XTicks(xs, labels);
            fp.Plot.XAxis.TickLabelStyle(rotation: 45);
            fp.Plot.Title(title);
            fp.Plot.YLabel("Count");
            fp.Plot.SetAxisLimits(yMin: 0);

            if (showValues)
                AddBarValueLabels(fp, xs, values, "{0}");

            SetAxisFonts(fp, tickSize: 16, labelSize: 16, xTickRotation: 45);
            fp.Refresh();
        }

        // 3) 日趨勢（Line）＋可顯示數值標籤
        public static void PlotDailyTrend(
            FormsPlot fp,
            SortedDictionary<DateTime, int> dailyCounts,
            string title = "Daily Trend",
            bool showValues = true,
            string valueFormat = "{0}",  // 例："{0:N0}" 千分位
            int labelEvery = 0           // 0=自動取樣；1=每點都標；2=每2點標一次...
        )
        {
            fp.Plot.Clear();
            if (dailyCounts == null || dailyCounts.Count == 0) { fp.Refresh(); return; }

            double[] xs = dailyCounts.Keys.Select(d => d.ToOADate()).ToArray();
            double[] ys = dailyCounts.Values.Select(v => (double)v).ToArray();

            fp.Plot.AddScatter(xs, ys, markerSize: 4);
            fp.Plot.XAxis.DateTimeFormat(true);
            fp.Plot.Title(title);
            fp.Plot.YLabel("Count");

            // 預留上方空間，避免標籤被截掉
            double yMax = Math.Max(1, ys.Max());
            double pad = yMax * 0.06;
            fp.Plot.SetAxisLimits(yMin: 0, yMax: yMax + pad * 2);

            if (showValues)
            {
                // 若未指定，依點數自動稀釋（大約最多 30 個標籤）
                if (labelEvery <= 0)
                    labelEvery = Math.Max(1, xs.Length / 30);

                for (int i = 0; i < xs.Length; i += labelEvery)
                {
                    var t = fp.Plot.AddText(string.Format(valueFormat, ys[i]), xs[i], ys[i] + pad);
                    t.Alignment = Alignment.LowerCenter;
                    t.Color = Color.Black;
                    t.FontSize = 14;
                }

                // 確保最後一點一定有標籤
                if ((xs.Length - 1) % labelEvery != 0)
                {
                    int i = xs.Length - 1;
                    var t = fp.Plot.AddText(string.Format(valueFormat, ys[i]), xs[i], ys[i] + pad);
                    t.Alignment = Alignment.LowerCenter;
                    t.Color = Color.Black;
                    t.FontSize = 14;
                }
            }

            SetAxisFonts(fp, tickSize: 16, labelSize: 16);
            fp.Refresh();
        }


        // 4) 24 小時分佈（Bar）
        public static void PlotHourHistogram(FormsPlot fp, int[] hourCounts,
            bool showValues = true, string title = "Hour-of-Day Histogram")
        {
            fp.Plot.Clear();
            if (hourCounts == null || hourCounts.Length == 0) { fp.Refresh(); return; }

            double[] values = hourCounts.Select(c => (double)c).ToArray();
            string[] labels = Enumerable.Range(0, values.Length).Select(h => h.ToString("00")).ToArray();
            double[] xs = Enumerable.Range(0, values.Length).Select(i => (double)i).ToArray();

            var bar = fp.Plot.AddBar(values);
            bar.BarWidth = 0.8;

            fp.Plot.XTicks(xs, labels);
            fp.Plot.Title(title);
            fp.Plot.YLabel("Count");
            fp.Plot.SetAxisLimits(yMin: 0);

            if (showValues)
                AddBarValueLabels(fp, xs, values, "{0}");

            SetAxisFonts(fp, tickSize: 16, labelSize: 16, xTickRotation : 90);
            fp.Refresh();
        }
    }

    public static partial class AlarmChartsV4
    {
        // 共用：在每支柱子上方加數值
        private static void AddBarValueLabels(FormsPlot fp, double[] xs, double[] ys, string valueFormat = "{0}")
        {
            if (ys.Length == 0) return;

            double yMax = Math.Max(1, ys.Max());
            // 多留一點上方空間避免數字被截掉
            fp.Plot.SetAxisLimits(yMin: 0, yMax: yMax * 1.15);

            for (int i = 0; i < ys.Length; i++)
            {
                double x = xs[i];
                double y = ys[i] + yMax * 0.02;

                var txt = fp.Plot.AddText(string.Format(valueFormat, ys[i]), x, y);
                txt.Alignment = Alignment.LowerCenter; // 文字底部對齊柱頂
                txt.Color = Color.Black;
                txt.FontSize = 14;                     // v4 用 FontSize
                txt.FontBold = true;
            }
        }

        private static void SetAxisFonts(FormsPlot fp, float tickSize = 12, float labelSize = 14, float? xTickRotation = null)
        {
            // 刻度字
            if (xTickRotation.HasValue)
                fp.Plot.XAxis.TickLabelStyle(fontSize: tickSize, rotation: xTickRotation.Value);
            else
                fp.Plot.XAxis.TickLabelStyle(fontSize: tickSize);

            fp.Plot.YAxis.TickLabelStyle(fontSize: tickSize);

            // 軸標籤字
            fp.Plot.XAxis.LabelStyle(fontSize: labelSize);
            fp.Plot.YAxis.LabelStyle(fontSize: labelSize);
        }
    }
}
