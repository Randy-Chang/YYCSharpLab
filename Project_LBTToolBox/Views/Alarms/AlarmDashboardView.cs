using ScottPlot;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Project_LBTToolBox.Views.Alarms
{
    public partial class AlarmDashboardView : UserControl
    {
        public AlarmDashboardView()
        {
            InitializeComponent();
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;

            var fpTrend = new FormsPlot { Dock = DockStyle.Fill };
            var fpByMachine = new FormsPlot { Dock = DockStyle.Fill };
            var fpByCode = new FormsPlot { Dock = DockStyle.Fill };
            pnlTrendHost.Controls.Add(fpTrend);
            pnlByMachineHost.Controls.Add(fpByMachine);
            pnlByCodeHost.Controls.Add(fpByCode);

            // Demo
            fpTrend.Plot.AddSignal(new double[] { 1, 3, 2, 5, 4, 6, 3 });
            fpTrend.Plot.Title("每日 WARN 趨勢"); fpTrend.Refresh();
            fpByMachine.Plot.AddBar(new double[] { 5, 9, 2, 7, 3 }); fpByMachine.Plot.Title("各機台 WARN 次數"); fpByMachine.Refresh();
            fpByCode.Plot.AddBar(new double[] { 8, 4, 6 }); fpByCode.Plot.Title("各警報代碼 WARN 次數"); fpByCode.Refresh();
        }
    }
}
