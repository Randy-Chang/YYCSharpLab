using ScottPlot;
using System.Drawing;
using System.Windows.Forms;

namespace Project_LBTToolBox.Views.Alarms
{
    public partial class AlarmDashboardView3 : UserControl
    {
        private TableLayoutPanel sourceLayout;
        private FlowLayoutPanel sourceActionsPanel;
        private FlowLayoutPanel sourceModePanel;
        private Panel warnCodeSearchPanel;
        private Label lblWarnCodeSearch;
        private TextBox txtWarnCodeSearch;
        private Button btnWarnCodeSearchClear;

        public AlarmDashboardView3()
        {
            InitializeComponent();
            ConfigureVisualDefaults();
        }

        private void ConfigureVisualDefaults()
        {
            tlpRoot.RowStyles[0].Height = 156F;
            splitMain.SplitterWidth = 6;
            splitRight.SplitterWidth = 6;
            splitData.SplitterWidth = 6;
            gbSource.Padding = new Padding(10, 12, 10, 10);

            BuildAdaptiveSourceLayout();
            BuildWarnCodeDictionaryLayout();

            ConfigureGridAppearance(dgvWareCode);
            ConfigureGridAppearance(dgvAlarmTable);
            ConfigureKpiCards();
        }

        private void BuildAdaptiveSourceLayout()
        {
            sourceLayout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                Margin = new Padding(0),
                Padding = new Padding(0),
                ColumnCount = 5,
                RowCount = 3
            };
            sourceLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            sourceLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            sourceLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 92F));
            sourceLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 92F));
            sourceLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 324F));
            sourceLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            sourceLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            sourceLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));

            sourceModePanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = false,
                Margin = new Padding(0, 2, 8, 0),
                Padding = new Padding(0)
            };
            rdbRemote.Margin = new Padding(0, 2, 12, 0);
            rdbLocal.Margin = new Padding(0, 2, 0, 0);
            sourceModePanel.Controls.Add(rdbRemote);
            sourceModePanel.Controls.Add(rdbLocal);

            sourceActionsPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = true,
                Margin = new Padding(8, 0, 0, 0),
                Padding = new Padding(0)
            };

            ConfigureSourceButton(btnApply, 110);
            ConfigureSourceButton(btnExportWarnCodesCsv, 96);
            ConfigureSourceButton(btnExportAlarmsCsv, 96);
            ConfigureSourceButton(btnExportAllAlarmsCsv, 96);
            btnApply.Height = 34;
            btnExportWarnCodesCsv.Height = 32;
            btnExportAlarmsCsv.Height = 32;
            btnExportAllAlarmsCsv.Height = 32;
            sourceActionsPanel.Controls.Add(btnApply);
            sourceActionsPanel.Controls.Add(btnExportWarnCodesCsv);
            sourceActionsPanel.Controls.Add(btnExportAlarmsCsv);
            sourceActionsPanel.Controls.Add(btnExportAllAlarmsCsv);

            ConfigureSourceLabel(lblRemotePath, "Remote NAS");
            ConfigureSourceLabel(lblLocalPath, "Local Folder");
            txtRemotePath.Dock = DockStyle.Fill;
            txtLocalPath.Dock = DockStyle.Fill;
            txtRemotePath.Margin = new Padding(0, 1, 0, 1);
            txtLocalPath.Margin = new Padding(0, 1, 0, 1);
            btnBrowseRemote.Dock = DockStyle.Fill;
            btnBrowseLocal.Dock = DockStyle.Fill;
            btnTestRemote.Dock = DockStyle.Fill;
            btnBrowseRemote.Margin = new Padding(6, 0, 0, 0);
            btnBrowseLocal.Margin = new Padding(6, 0, 0, 0);
            btnTestRemote.Margin = new Padding(6, 0, 0, 0);

            var lblSourceMode = new Label
            {
                Text = "Source Mode",
                Dock = DockStyle.Fill,
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleLeft,
                Font = new Font("微軟正黑體", 10.2F, FontStyle.Bold),
                Margin = new Padding(0)
            };

            sourceLayout.Controls.Add(lblSourceMode, 0, 0);
            sourceLayout.Controls.Add(sourceModePanel, 1, 0);
            sourceLayout.SetColumnSpan(sourceModePanel, 3);
            sourceLayout.Controls.Add(sourceActionsPanel, 4, 0);
            sourceLayout.SetRowSpan(sourceActionsPanel, 3);

            sourceLayout.Controls.Add(lblRemotePath, 0, 1);
            sourceLayout.Controls.Add(txtRemotePath, 1, 1);
            sourceLayout.Controls.Add(btnBrowseRemote, 2, 1);
            sourceLayout.Controls.Add(btnTestRemote, 3, 1);

            sourceLayout.Controls.Add(lblLocalPath, 0, 2);
            sourceLayout.Controls.Add(txtLocalPath, 1, 2);
            sourceLayout.Controls.Add(btnBrowseLocal, 2, 2);

            gbSource.Controls.Clear();
            gbSource.Controls.Add(sourceLayout);
        }

        private void ConfigureSourceLabel(Label label, string text)
        {
            label.AutoSize = false;
            label.Text = text;
            label.Dock = DockStyle.Fill;
            label.TextAlign = ContentAlignment.MiddleLeft;
            label.Font = new Font("微軟正黑體", 10.2F, FontStyle.Bold);
            label.Margin = new Padding(0);
        }

        private void ConfigureSourceButton(Button button, int width)
        {
            button.Width = width;
            button.Margin = new Padding(0, 0, 6, 6);
        }

        private void BuildWarnCodeDictionaryLayout()
        {
            warnCodeSearchPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 40,
                Padding = new Padding(8, 6, 8, 4)
            };

            lblWarnCodeSearch = new Label
            {
                Text = "Search",
                AutoSize = false,
                Width = 58,
                Dock = DockStyle.Left,
                TextAlign = ContentAlignment.MiddleLeft,
                Font = new Font("微軟正黑體", 9.8F, FontStyle.Bold)
            };

            btnWarnCodeSearchClear = new Button
            {
                Text = "Clear",
                Dock = DockStyle.Right,
                Width = 64,
                Font = new Font("微軟正黑體", 9F)
            };
            btnWarnCodeSearchClear.Click += BtnWarnCodeSearchClear_Click;

            txtWarnCodeSearch = new TextBox
            {
                Dock = DockStyle.Fill,
                Font = new Font("微軟正黑體", 9.8F),
                BorderStyle = BorderStyle.FixedSingle
            };
            txtWarnCodeSearch.TextChanged += TxtWarnCodeSearch_TextChanged;

            warnCodeSearchPanel.Controls.Add(txtWarnCodeSearch);
            warnCodeSearchPanel.Controls.Add(btnWarnCodeSearchClear);
            warnCodeSearchPanel.Controls.Add(lblWarnCodeSearch);

            gbWarnCode.Controls.Clear();
            gbWarnCode.Controls.Add(dgvWareCode);
            gbWarnCode.Controls.Add(warnCodeSearchPanel);
            dgvWareCode.Dock = DockStyle.Fill;
            dgvWareCode.DataBindingComplete += DgvWareCode_DataBindingComplete;
        }

        private void TxtWarnCodeSearch_TextChanged(object sender, System.EventArgs e)
        {
            ApplyWarnCodeSearchFilter();
        }

        private void BtnWarnCodeSearchClear_Click(object sender, System.EventArgs e)
        {
            txtWarnCodeSearch.Text = string.Empty;
        }

        private void DgvWareCode_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ApplyWarnCodeSearchFilter();
        }

        private void ApplyWarnCodeSearchFilter()
        {
            if (dgvWareCode.Rows.Count == 0)
                return;

            string keyword = (txtWarnCodeSearch?.Text ?? string.Empty).Trim();
            bool hasKeyword = keyword.Length > 0;
            dgvWareCode.CurrentCell = null;

            foreach (DataGridViewRow row in dgvWareCode.Rows)
            {
                if (row.IsNewRow)
                    continue;

                string code = row.Cells.Count > 0 ? row.Cells[0].Value?.ToString() ?? string.Empty : string.Empty;
                string message = row.Cells.Count > 1 ? row.Cells[1].Value?.ToString() ?? string.Empty : string.Empty;
                bool visible = !hasKeyword
                    || code.IndexOf(keyword, System.StringComparison.OrdinalIgnoreCase) >= 0
                    || message.IndexOf(keyword, System.StringComparison.OrdinalIgnoreCase) >= 0;

                row.Visible = visible;
            }
        }

        private void ConfigureKpiCards()
        {
            gbTotalAlarms.BackColor = Color.FromArgb(244, 248, 252);
            gbMaxAlarm.BackColor = Color.FromArgb(254, 245, 244);
            gbMaxMachine.BackColor = Color.FromArgb(252, 249, 240);
            lblTotalAlarms.ForeColor = Color.FromArgb(28, 77, 123);
            lblMaxAlarmCode.ForeColor = Color.FromArgb(173, 51, 44);
            lblMaxAlarmCodeTimes.ForeColor = Color.FromArgb(173, 51, 44);
            lblMaxMachine.ForeColor = Color.FromArgb(145, 102, 18);
        }

        public void UpdateKpiEmphasis(int totalAlarms, int topProblemCount)
        {
            lblTotalAlarms.ForeColor = totalAlarms >= 500 ? Color.FromArgb(173, 51, 44) : Color.FromArgb(28, 77, 123);
            lblMaxAlarmCode.ForeColor = topProblemCount >= 100 ? Color.FromArgb(180, 36, 36) : Color.FromArgb(173, 51, 44);
            lblMaxAlarmCodeTimes.ForeColor = lblMaxAlarmCode.ForeColor;
            gbMaxAlarm.BackColor = topProblemCount >= 100
                ? Color.FromArgb(253, 236, 234)
                : Color.FromArgb(254, 245, 244);
            gbTotalAlarms.BackColor = totalAlarms >= 500
                ? Color.FromArgb(252, 239, 238)
                : Color.FromArgb(244, 248, 252);
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
        public TextBox TxtWarnCodeSearch => txtWarnCodeSearch;
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
