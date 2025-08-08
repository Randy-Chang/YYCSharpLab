using Project_CurveFittingDemo.Interfaces;
using Project_CurveFittingDemo.Presenters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Project_CurveFittingDemo.Scopes
{
    public partial class Scope
    {
        public static MainForm MainForm { get; private set; }

        public void InitializeMainForm()
        {
            MainForm = new MainForm();
            MainForm.BtnRunDemo.Click += btnRunDemo_Click;
        }

        private void btnRunDemo_Click(object sender, EventArgs e)
        {
            var chartPresenter = new PanelChartWinFormsPresenter(MainForm.PanelChart);

            var result = MessageBox.Show("要執行 RunGaussianFittingDemo 嗎？\n" +
                                            "(選 NO 會執行 RunGaussianFittingByData)",
                                            "選擇執行方式",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                RunGaussianFittingDemo(chartPresenter);
            }
            else
            {
                RunGaussianFittingByData(chartPresenter);
            }
        }

        private void RunGaussianFittingByData(IPanelChartPresenter chart)
        {
            // 1. 選擇 csv 檔案
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
                ofd.Title = "選擇數據檔案";

                if (ofd.ShowDialog() != DialogResult.OK)
                    return; // 使用者取消

                // 2. 讀取資料
                List<double> xs = new List<double>();
                List<double> ys = new List<double>();

                foreach (var line in File.ReadLines(ofd.FileName))
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;
                    var parts = line.Split(',');

                    if (parts.Length < 2) continue;
                    if (!double.TryParse(parts[0], out double xVal)) continue;
                    if (!double.TryParse(parts[1], out double yVal)) continue;

                    xs.Add(xVal);
                    ys.Add(yVal);
                }

                double[] x = xs.ToArray();
                double[] y = ys.ToArray();

                // 3. 畫圖
                PlotFittingCurve(chart, x, y);
            }

        }
    }

    public interface IMainFormUI
    {
        Button BtnRunDemo { get; }
        Panel PanelChart { get; }
    }
}
