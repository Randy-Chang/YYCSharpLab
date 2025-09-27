using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Project_LBTToolBox.Views;          // UiHelpers
using Project_LBTToolBox.Controls;       // DarkColors
using ScottPlot.WinForms;                // NuGet: ScottPlot.WinForms (5.x)

namespace Project_LBTToolBox.Views.Alarms
{
    public partial class AlarmDashboardView : UserControl
    {
        // 執行期才建立的控制項
        private FormsPlot fpByMachine, fpByCode, fpTrend;

        public AlarmDashboardView()
        {
            InitializeComponent();

        }
    }
}
