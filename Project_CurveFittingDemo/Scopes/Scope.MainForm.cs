using Project_CurveFittingDemo.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            RunGaussianFittingDemo(chartPresenter);
        }
    }

    public interface IMainFormUI
    {
        Button BtnRunDemo { get; }
        Panel PanelChart { get; }
    }
}
