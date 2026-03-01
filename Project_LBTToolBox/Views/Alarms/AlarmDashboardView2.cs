using ScottPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_LBTToolBox.Views.Alarms
{
    public partial class AlarmDashboardView2 : UserControl
    {
        #region 屬性存取 - Controls
        public Button BtnBrowseFolder => btnBrowseFolder;
        public TextBox TxtPath => txtPath;

        public CheckBox CkbDateRangeEnable => ckbDateRangeEnable;
        public DateTime dateTimeFrom => dtpFrom.Value;
        public DateTime dateTimeTo => dtpTo.Value;

        public CheckedListBox ClbMachines => clbMachines;
        public Button BtnMachinesAll => btnMachinesAll;
        public Button BtnMachinesClear => btnMachinesClear;
        public TextBox TxtWareCodeFilter => txtWareCodeFilter;
        public GroupBox GbWarnCode => gbWarnCode;

        public Button BtnApply => btnApply;


        // Dashboard - Display
        public Label LblTotalAlarms => lblTotalAlarms;
        public Label LblMaxAlarmCode => lblMaxAlarmCode;
        public Label LblMaxAlarmCodeTimes => lblMaxAlarmCodeTimes;
        public Label LblMaxMachine => lblMaxMachine;

        public FormsPlot FpCodeBar => fpCodeBar;
        public FormsPlot FpMachineBar => fpMachineBar;
        public FormsPlot FpDailyTrend => fpDailyTrend;
        public FormsPlot FpHourHistogram => fpHourHistogram;

        public DataGridView DgvWareCode => dgvWareCode;
        public DataGridView DgvAlarmTable => dgvAlarmTable;
        #endregion

        public AlarmDashboardView2()
        {
            InitializeComponent();
        }
    }
}
