using ScottPlot;
using System.Drawing;
using System.Windows.Forms;

namespace Project_LBTToolBox.Views.Alarms
{
    public partial class AlarmDashboardView3 : UserControl
    {
        private TableLayoutPanel tlpLeft;
        private GroupBox gbSource;
        private RadioButton rdbRemote;
        private RadioButton rdbLocal;
        private Label lblRemotePath;
        private TextBox txtRemotePath;
        private Button btnBrowseRemote;
        private Button btnTestRemote;
        private Label lblLocalPath;
        private TextBox txtLocalPath;
        private Button btnBrowseLocal;
        private Label lblSourceStatusTitle;
        private Label lblSourceStatus;

        private GroupBox gbFilters;
        private TableLayoutPanel tlpFilters;
        private Panel panelDateFilter;
        private CheckBox ckbDateRangeEnable;
        private Label lblStartDate;
        private Label lblEndDate;
        private DateTimePicker dtpFrom;
        private DateTimePicker dtpTo;
        private Panel panelMachines;
        private Label lblMachines;
        private CheckedListBox clbMachines;
        private Button btnMachinesAll;
        private Button btnMachinesClear;
        private Panel panelCodeFilter;
        private Label lblWarnCodeFilter;
        private TextBox txtWarnCodeFilter;
        private GroupBox gbWarnCode;
        private DataGridView dgvWareCode;
        private Button btnApply;

        private Panel panelDashboard;
        private Panel panelStatus;
        private Label lblCurrentModeTitle;
        private Label lblCurrentMode;
        private Label lblDatabasePathTitle;
        private Label lblDatabasePath;
        private Button btnExportAllAlarmsCsv;
        private Button btnExportAlarmsCsv;
        private Button btnExportWarnCodesCsv;
        private TableLayoutPanel tlpKpi;
        private GroupBox gbTotalAlarms;
        private Label lblTotalAlarms;
        private GroupBox gbMaxAlarm;
        private Label lblMaxAlarmCode;
        private Label lblMaxAlarmCodeTimes;
        private GroupBox gbMaxMachine;
        private Label lblMaxMachine;
        private TableLayoutPanel tlpPlots;
        private FormsPlot fpCodeBar;
        private FormsPlot fpPareto;
        private FormsPlot fpMachineBar;
        private FormsPlot fpDailyTrend;
        private FormsPlot fpHourHistogram;
        private Panel panelPlotSpacer;
        private Panel panelPaging;
        private Button btnPrevPage;
        private Button btnNextPage;
        private TextBox txtJumpPage;
        private Button btnJumpPage;
        private Label lblPagingStatus;
        private DataGridView dgvAlarmTable;

        public AlarmDashboardView3()
        {
            InitializeComponent();
            BuildLayout();
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

        private void BuildLayout()
        {
            SuspendLayout();

            tlpLeft = new TableLayoutPanel
            {
                Dock = DockStyle.Left,
                Width = 340,
                ColumnCount = 1,
                RowCount = 2,
            };
            tlpLeft.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 230F));
            tlpLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            BuildSourceGroup();
            BuildFilterGroup();

            tlpLeft.Controls.Add(gbSource, 0, 0);
            tlpLeft.Controls.Add(gbFilters, 0, 1);

            panelDashboard = new Panel { Dock = DockStyle.Fill };
            BuildDashboard();

            Controls.Add(panelDashboard);
            Controls.Add(tlpLeft);

            ResumeLayout(false);
        }

        private void BuildSourceGroup()
        {
            gbSource = new GroupBox
            {
                Dock = DockStyle.Fill,
                Text = "Source",
                Font = new Font("微軟正黑體", 13.8F, FontStyle.Bold),
            };

            rdbRemote = new RadioButton { Text = "Remote", Location = new Point(13, 34), AutoSize = true, Font = new Font("微軟正黑體", 12F) };
            rdbLocal = new RadioButton { Text = "Local", Location = new Point(124, 34), AutoSize = true, Font = new Font("微軟正黑體", 12F) };

            lblRemotePath = new Label { Text = "NAS Log", Location = new Point(9, 71), AutoSize = true, Font = new Font("微軟正黑體", 10.2F) };
            txtRemotePath = new TextBox { Location = new Point(97, 68), Size = new Size(143, 67), Multiline = true, Font = new Font("微軟正黑體", 10.2F) };
            btnBrowseRemote = new Button { Text = "Browse", Location = new Point(246, 67), Size = new Size(75, 32), Font = new Font("微軟正黑體", 10.2F) };
            btnTestRemote = new Button { Text = "Test", Location = new Point(246, 103), Size = new Size(75, 32), Font = new Font("微軟正黑體", 10.2F) };

            lblLocalPath = new Label { Text = "Local Log", Location = new Point(9, 150), AutoSize = true, Font = new Font("微軟正黑體", 10.2F) };
            txtLocalPath = new TextBox { Location = new Point(97, 147), Size = new Size(143, 30), Font = new Font("微軟正黑體", 10.2F) };
            btnBrowseLocal = new Button { Text = "Browse", Location = new Point(246, 144), Size = new Size(75, 32), Font = new Font("微軟正黑體", 10.2F) };

            lblSourceStatusTitle = new Label { Text = "Status:", Location = new Point(9, 189), AutoSize = true, Font = new Font("微軟正黑體", 10.2F, FontStyle.Bold) };
            lblSourceStatus = new Label { Text = "Idle", Location = new Point(93, 189), Size = new Size(228, 24), Font = new Font("微軟正黑體", 10.2F), AutoEllipsis = true };

            gbSource.Controls.AddRange(new Control[]
            {
                rdbRemote, rdbLocal,
                lblRemotePath, txtRemotePath, btnBrowseRemote, btnTestRemote,
                lblLocalPath, txtLocalPath, btnBrowseLocal,
                lblSourceStatusTitle, lblSourceStatus
            });
        }

        private void BuildFilterGroup()
        {
            gbFilters = new GroupBox
            {
                Dock = DockStyle.Fill,
                Text = "Filters",
                Font = new Font("微軟正黑體", 13.8F, FontStyle.Bold),
            };

            tlpFilters = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 1, RowCount = 5 };
            tlpFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpFilters.RowStyles.Add(new RowStyle(SizeType.Absolute, 140F));
            tlpFilters.RowStyles.Add(new RowStyle(SizeType.Absolute, 260F));
            tlpFilters.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpFilters.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpFilters.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));

            panelDateFilter = new Panel { Dock = DockStyle.Fill };
            ckbDateRangeEnable = new CheckBox { Text = "Date Range", Location = new Point(3, 3), AutoSize = true };
            lblStartDate = new Label { Text = "From:", Location = new Point(8, 51), AutoSize = true, Font = new Font("微軟正黑體", 13.8F) };
            dtpFrom = new DateTimePicker { Location = new Point(89, 45), Size = new Size(196, 38), Format = DateTimePickerFormat.Custom, CustomFormat = "yyyy-MM-dd", Font = new Font("微軟正黑體", 13.8F) };
            lblEndDate = new Label { Text = "To:", Location = new Point(35, 95), AutoSize = true, Font = new Font("微軟正黑體", 13.8F) };
            dtpTo = new DateTimePicker { Location = new Point(89, 89), Size = new Size(196, 38), Format = DateTimePickerFormat.Custom, CustomFormat = "yyyy-MM-dd", Font = new Font("微軟正黑體", 13.8F) };
            panelDateFilter.Controls.AddRange(new Control[] { ckbDateRangeEnable, lblStartDate, dtpFrom, lblEndDate, dtpTo });

            panelMachines = new Panel { Dock = DockStyle.Fill };
            lblMachines = new Label { Text = "Machines", Location = new Point(3, 8), AutoSize = true };
            clbMachines = new CheckedListBox { Location = new Point(8, 41), Size = new Size(301, 160), Font = new Font("微軟正黑體", 13.8F) };
            btnMachinesAll = new Button { Text = "All", Location = new Point(8, 207), Size = new Size(144, 40), Font = new Font("微軟正黑體", 13.8F) };
            btnMachinesClear = new Button { Text = "Clear", Location = new Point(165, 207), Size = new Size(144, 40), Font = new Font("微軟正黑體", 13.8F) };
            panelMachines.Controls.AddRange(new Control[] { lblMachines, clbMachines, btnMachinesAll, btnMachinesClear });

            panelCodeFilter = new Panel { Dock = DockStyle.Fill };
            lblWarnCodeFilter = new Label { Text = "WarnCode", Location = new Point(3, 8), AutoSize = true, Font = new Font("微軟正黑體", 12F) };
            txtWarnCodeFilter = new TextBox { Location = new Point(117, 5), Size = new Size(192, 34), Font = new Font("微軟正黑體", 12F) };
            panelCodeFilter.Controls.AddRange(new Control[] { lblWarnCodeFilter, txtWarnCodeFilter });

            gbWarnCode = new GroupBox { Dock = DockStyle.Fill, Text = "Warn Code" };
            dgvWareCode = new DataGridView { Dock = DockStyle.Fill };
            gbWarnCode.Controls.Add(dgvWareCode);

            btnApply = new Button { Dock = DockStyle.Fill, Text = "Apply", Font = new Font("微軟正黑體", 13.8F) };

            tlpFilters.Controls.Add(panelDateFilter, 0, 0);
            tlpFilters.Controls.Add(panelMachines, 0, 1);
            tlpFilters.Controls.Add(panelCodeFilter, 0, 2);
            tlpFilters.Controls.Add(gbWarnCode, 0, 3);
            tlpFilters.Controls.Add(btnApply, 0, 4);
            gbFilters.Controls.Add(tlpFilters);
        }

        private void BuildDashboard()
        {
            panelStatus = new Panel { Dock = DockStyle.Top, Height = 44 };
            lblCurrentModeTitle = new Label { Text = "Run Mode:", Location = new Point(12, 10), AutoSize = true, Font = new Font("微軟正黑體", 10.2F, FontStyle.Bold) };
            lblCurrentMode = new Label { Text = "Remote", Location = new Point(114, 10), AutoSize = true, Font = new Font("微軟正黑體", 10.2F) };
            lblDatabasePathTitle = new Label { Text = "DB Path:", Location = new Point(359, 10), AutoSize = true, Font = new Font("微軟正黑體", 10.2F, FontStyle.Bold) };
            lblDatabasePath = new Label { Text = "-", Location = new Point(467, 10), Size = new Size(290, 22), AutoEllipsis = true, Font = new Font("微軟正黑體", 10.2F) };
            btnExportWarnCodesCsv = new Button { Text = "Export Codes", Location = new Point(764, 6), Size = new Size(108, 30), Font = new Font("微軟正黑體", 9.2F) };
            btnExportAlarmsCsv = new Button { Text = "Export Page", Location = new Point(878, 6), Size = new Size(108, 30), Font = new Font("微軟正黑體", 9.2F) };
            btnExportAllAlarmsCsv = new Button { Text = "Export All", Location = new Point(992, 6), Size = new Size(108, 30), Font = new Font("微軟正黑體", 9.2F) };
            panelStatus.Controls.AddRange(new Control[] { lblCurrentModeTitle, lblCurrentMode, lblDatabasePathTitle, lblDatabasePath, btnExportWarnCodesCsv, btnExportAlarmsCsv, btnExportAllAlarmsCsv });

            tlpKpi = new TableLayoutPanel { Dock = DockStyle.Top, Height = 100, ColumnCount = 3 };
            tlpKpi.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
            tlpKpi.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
            tlpKpi.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
            gbTotalAlarms = new GroupBox { Dock = DockStyle.Fill, Text = "Total Alarms" };
            lblTotalAlarms = new Label { Text = "----", Location = new Point(6, 32), AutoSize = true, Font = new Font("微軟正黑體", 19.8F, FontStyle.Bold) };
            gbTotalAlarms.Controls.Add(lblTotalAlarms);
            gbMaxAlarm = new GroupBox { Dock = DockStyle.Fill, Text = "Max Code" };
            lblMaxAlarmCode = new Label { Text = "----", Location = new Point(6, 29), AutoSize = true, Font = new Font("微軟正黑體", 19.8F, FontStyle.Bold) };
            lblMaxAlarmCodeTimes = new Label { Text = "(Times ---)", Location = new Point(7, 69), AutoSize = true, Font = new Font("微軟正黑體", 10.8F, FontStyle.Bold) };
            gbMaxAlarm.Controls.AddRange(new Control[] { lblMaxAlarmCode, lblMaxAlarmCodeTimes });
            gbMaxMachine = new GroupBox { Dock = DockStyle.Fill, Text = "Max Machine" };
            lblMaxMachine = new Label { Text = "----", Location = new Point(6, 32), AutoSize = true, Font = new Font("微軟正黑體", 19.8F, FontStyle.Bold) };
            gbMaxMachine.Controls.Add(lblMaxMachine);
            tlpKpi.Controls.Add(gbTotalAlarms, 0, 0);
            tlpKpi.Controls.Add(gbMaxAlarm, 1, 0);
            tlpKpi.Controls.Add(gbMaxMachine, 2, 0);

            tlpPlots = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 2, RowCount = 3 };
            tlpPlots.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpPlots.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpPlots.RowStyles.Add(new RowStyle(SizeType.Percent, 33.34F));
            tlpPlots.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
            tlpPlots.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
            fpCodeBar = new FormsPlot { Dock = DockStyle.Fill, Margin = new Padding(16, 12, 16, 12) };
            fpPareto = new FormsPlot { Dock = DockStyle.Fill, Margin = new Padding(16, 12, 16, 12) };
            fpMachineBar = new FormsPlot { Dock = DockStyle.Fill, Margin = new Padding(16, 12, 16, 12) };
            fpDailyTrend = new FormsPlot { Dock = DockStyle.Fill, Margin = new Padding(16, 12, 16, 12) };
            fpHourHistogram = new FormsPlot { Dock = DockStyle.Fill, Margin = new Padding(16, 12, 16, 12) };
            panelPlotSpacer = new Panel { Dock = DockStyle.Fill };
            tlpPlots.Controls.Add(fpCodeBar, 0, 0);
            tlpPlots.Controls.Add(fpMachineBar, 1, 0);
            tlpPlots.Controls.Add(fpPareto, 0, 1);
            tlpPlots.Controls.Add(fpDailyTrend, 1, 1);
            tlpPlots.Controls.Add(fpHourHistogram, 0, 2);
            tlpPlots.Controls.Add(panelPlotSpacer, 1, 2);

            panelPaging = new Panel { Dock = DockStyle.Bottom, Height = 38 };
            btnPrevPage = new Button { Text = "Prev", Location = new Point(16, 4), Size = new Size(85, 30), Font = new Font("微軟正黑體", 9.5F) };
            btnNextPage = new Button { Text = "Next", Location = new Point(107, 4), Size = new Size(85, 30), Font = new Font("微軟正黑體", 9.5F) };
            lblPagingStatus = new Label { Text = "Page 0 / 0", Location = new Point(208, 8), Size = new Size(240, 22), Font = new Font("微軟正黑體", 10.2F) };
            txtJumpPage = new TextBox { Location = new Point(458, 4), Size = new Size(70, 30), Font = new Font("微軟正黑體", 10.2F) };
            btnJumpPage = new Button { Text = "Go", Location = new Point(535, 4), Size = new Size(65, 30), Font = new Font("微軟正黑體", 9.5F) };
            panelPaging.Controls.AddRange(new Control[] { btnPrevPage, btnNextPage, lblPagingStatus, txtJumpPage, btnJumpPage });

            dgvAlarmTable = new DataGridView { Dock = DockStyle.Bottom, Height = 220 };

            panelDashboard.Controls.Add(tlpPlots);
            panelDashboard.Controls.Add(panelPaging);
            panelDashboard.Controls.Add(dgvAlarmTable);
            panelDashboard.Controls.Add(tlpKpi);
            panelDashboard.Controls.Add(panelStatus);
        }
    }
}
