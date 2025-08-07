using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Project_CurveFittingDemo.Interfaces;

namespace Project_CurveFittingDemo.Presenters
{
    public class PanelChartWinFormsPresenter : IPanelChartPresenter
    {
        private readonly Panel _panel;
        private readonly Chart _chart;

        public PanelChartWinFormsPresenter(Panel panel)
        {
            _panel = panel ?? throw new ArgumentNullException(nameof(panel));

            _chart = new Chart
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                BorderlineDashStyle = ChartDashStyle.Solid,
                BorderlineColor = Color.Gray
            };

            var area = new ChartArea("MainArea")
            {
                AxisX = { Title = "Angle (°)", TitleFont = new Font("Segoe UI", 10), IntervalAutoMode = IntervalAutoMode.VariableCount },
                AxisY = { Title = "Intensity", TitleFont = new Font("Segoe UI", 10) },
            };
            _chart.ChartAreas.Add(area);

            var legend = new Legend("MainLegend")
            {
                Docking = Docking.Top,
                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                Alignment = StringAlignment.Center
            };

            _chart.Legends.Add(legend);
            _panel.Controls.Clear();
            _panel.Controls.Add(_chart);
        }

        public void Clear()
        {
            _chart.Series.Clear();
        }

        public void AddCurve(string name, double[] x, double[] y, bool isScatter = false)
        {
            var series = new Series(name)
            {
                ChartType = isScatter ? SeriesChartType.Point : SeriesChartType.Line,
                BorderWidth = isScatter ? 1 : 2,
                MarkerStyle = isScatter ? MarkerStyle.Circle : MarkerStyle.None,
                MarkerSize = isScatter ? 4 : 0,
            };

            for (int i = 0; i < x.Length; i++)
            {
                series.Points.AddXY(x[i], y[i]);
            }

            _chart.Series.Add(series);
        }
    }
}
