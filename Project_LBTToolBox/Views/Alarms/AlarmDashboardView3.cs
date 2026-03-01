using ScottPlot;
using System.Drawing;
using System.Windows.Forms;

namespace Project_LBTToolBox.Views.Alarms
{
    public partial class AlarmDashboardView3 : UserControl
    {
        public AlarmDashboardView3()
        {
            InitializeComponent();
            ConfigureVisualDefaults();
        }

        private void ConfigureVisualDefaults()
        {
            splitMain.SplitterWidth = 6;
            splitRight.SplitterWidth = 6;
            splitData.SplitterWidth = 6;

            ConfigureGridAppearance(dgvWareCode);
            ConfigureGridAppearance(dgvAlarmTable);
        }

        private void ConfigureGridAppearance(DataGridView grid)
        {
            if (grid == null)
                return;

            grid.BorderStyle = BorderStyle.None;
            grid.BackgroundColor = Color.White;
            grid.GridColor = Color.FromArgb(223, 228, 235);
            grid.EnableHeadersVisualStyles = false;
            grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(244, 247, 250);
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(35, 45, 55);
            grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(230, 236, 242);
            grid.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(35, 45, 55);
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("微軟正黑體", 10.2F, FontStyle.Bold);
            grid.DefaultCellStyle.BackColor = Color.White;
            grid.DefaultCellStyle.ForeColor = Color.FromArgb(45, 55, 65);
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 234, 248);
            grid.DefaultCellStyle.SelectionForeColor = Color.FromArgb(20, 25, 30);
            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(249, 251, 252);
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.MultiSelect = false;
        }

        public RadioButton RdbRemote => rdbRemote;
        public RadioButton RdbLocal => rdbLocal;
        public TextBox TxtRemotePath => txtRemotePath;
        public TextBox TxtLocalPath => txtLocalPath;
        public Button BtnBrowseRemote => btnBrowseRemote;
        public Button BtnBrowseLocal => btnBrowseLocal;
        public Button BtnTestRemote => btnTestRemote;
        public Button BtnApply => btnApply;
        public Button BtnExportAllAlarmsCsv => btnExportAllAlarmsCsv;
        public Button BtnExportAlarmsCsv => btnExportAlarmsCsv;
        public Button BtnExportWarnCodesCsv => btnExportWarnCodesCsv;
        public Button BtnPrevPage => btnPrevPage;
        public Button BtnNextPage => btnNextPage;
        public TextBox TxtJumpPage => txtJumpPage;
        public Button BtnJumpPage => btnJumpPage;
        public CheckBox CkbDateRangeEnable => ckbDateRangeEnable;
        public System.DateTime DateTimeFrom => dtpFrom.Value;
        public System.DateTime DateTimeTo => dtpTo.Value;
        public CheckedListBox ClbMachines => clbMachines;
        public Button BtnMachinesAll => btnMachinesAll;
        public Button BtnMachinesClear => btnMachinesClear;
        public TextBox TxtWarnCodeFilter => txtWarnCodeFilter;
        public GroupBox GbWarnCode => gbWarnCode;
        public DataGridView DgvWareCode => dgvWareCode;
        public DataGridView DgvAlarmTable => dgvAlarmTable;
        public Label LblSourceStatus => lblSourceStatus;
        public Label LblCurrentMode => lblCurrentMode;
        public Label LblDatabasePath => lblDatabasePath;
        public Label LblTotalAlarms => lblTotalAlarms;
        public Label LblMaxAlarmCode => lblMaxAlarmCode;
        public Label LblMaxAlarmCodeTimes => lblMaxAlarmCodeTimes;
        public Label LblMaxMachine => lblMaxMachine;
        public Label LblPagingStatus => lblPagingStatus;
        public FormsPlot FpCodeBar => fpCodeBar;
        public FormsPlot FpPareto => fpPareto;
        public FormsPlot FpMachineBar => fpMachineBar;
        public FormsPlot FpDailyTrend => fpDailyTrend;
        public FormsPlot FpHourHistogram => fpHourHistogram;
    }
}
