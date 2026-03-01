using ScottPlot;
using System;
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
            splitMain.SplitterDistance = 300;
            splitRight.SplitterDistance = 302;
            splitData.SplitterDistance = 350;
            ConfigureGridAppearance(dgvWareCode);
            ConfigureGridAppearance(dgvAlarmTable);
            ConfigureKpiCards();
            HookDictionarySearchEvents();
        }

        private void HookDictionarySearchEvents()
        {
            pbWarnCodeFilterClear.Click += PbWarnCodeFilterClear_Click;
            pbWarnCodeSearchClear.Click += PbWarnCodeSearchClear_Click;
            txtWarnCodeSearch.TextChanged += TxtWarnCodeSearch_TextChanged;
            dgvWareCode.DataBindingComplete += DgvWareCode_DataBindingComplete;
            ConfigureClearIcon(pbWarnCodeFilterClear);
            ConfigureClearIcon(pbWarnCodeSearchClear);
        }

        private void ConfigureClearIcon(PictureBox pictureBox)
        {
            if (pictureBox == null)
                return;

            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.BackColor = Color.White;
            pictureBox.Cursor = Cursors.Hand;
        }

        private void PbWarnCodeFilterClear_Click(object sender, System.EventArgs e)
        {
            txtWarnCodeFilter.Text = string.Empty;
            txtWarnCodeFilter.Focus();
        }

        private void TxtWarnCodeSearch_TextChanged(object sender, System.EventArgs e)
        {
            ApplyWarnCodeSearchFilter();
        }

        private void PbWarnCodeSearchClear_Click(object sender, System.EventArgs e)
        {
            txtWarnCodeSearch.Text = string.Empty;
            txtWarnCodeSearch.Focus();
        }

        private void DgvWareCode_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ApplyWarnCodeSearchFilter();
        }

        private void ApplyWarnCodeSearchFilter()
        {
            if (dgvWareCode.Rows.Count == 0 || txtWarnCodeSearch == null)
                return;

            string keyword = (txtWarnCodeSearch.Text ?? string.Empty).Trim();
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
        public PictureBox PbxWarnCodeFilterClear => pbWarnCodeFilterClear;
        public TextBox TxtWarnCodeSearch => txtWarnCodeSearch;
        public PictureBox PbxWarnCodeSearchClear => pbWarnCodeSearchClear;
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
