using System.Drawing;
using System.Windows.Forms;

namespace Project_LBTToolBox.Views.Alarms
{
    partial class AlarmDashboardView
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private TableLayoutPanel tlpRoot;

        private Panel pnlToolbar;
        private FlowLayoutPanel flToolbar;
        private Label lblTitle, lblDate, lblTo;
        public DateTimePicker dtpFrom, dtpTo;
        public TextBox txtSearch;
        public ComboBox cboLevel;
        public Button btnApply, btnReset, btnRescan, btnExport;

        private TableLayoutPanel tlpTopRow;
        private TableLayoutPanel tlpKpi;
        private Panel cardK1, cardK2, cardK3, cardK4;
        public Label lblKpi1Title, lblKpi1Value;
        public Label lblKpi2Title, lblKpi2Value;
        public Label lblKpi3Title, lblKpi3Value;
        public Label lblKpi4Title, lblKpi4Value;

        private GroupBox gbTrend; public Panel pnlTrendHost;

        private TableLayoutPanel tlpBottomRow;
        private GroupBox gbByMachine; public Panel pnlByMachineHost;
        private GroupBox gbByCode; public Panel pnlByCodeHost;

        private GroupBox gbDetails; public DataGridView dgvDetails;

        private void InitializeComponent()
        {
            this.tlpRoot = new System.Windows.Forms.TableLayoutPanel();
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.flToolbar = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cboLevel = new System.Windows.Forms.ComboBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRescan = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.tlpTopRow = new System.Windows.Forms.TableLayoutPanel();
            this.tlpKpi = new System.Windows.Forms.TableLayoutPanel();
            this.cardK1 = new System.Windows.Forms.Panel();
            this.lblKpi1Value = new System.Windows.Forms.Label();
            this.lblKpi1Title = new System.Windows.Forms.Label();
            this.cardK2 = new System.Windows.Forms.Panel();
            this.lblKpi2Value = new System.Windows.Forms.Label();
            this.lblKpi2Title = new System.Windows.Forms.Label();
            this.cardK3 = new System.Windows.Forms.Panel();
            this.lblKpi3Value = new System.Windows.Forms.Label();
            this.lblKpi3Title = new System.Windows.Forms.Label();
            this.cardK4 = new System.Windows.Forms.Panel();
            this.lblKpi4Value = new System.Windows.Forms.Label();
            this.lblKpi4Title = new System.Windows.Forms.Label();
            this.gbTrend = new System.Windows.Forms.GroupBox();
            this.pnlTrendHost = new System.Windows.Forms.Panel();
            this.tlpBottomRow = new System.Windows.Forms.TableLayoutPanel();
            this.gbByMachine = new System.Windows.Forms.GroupBox();
            this.pnlByMachineHost = new System.Windows.Forms.Panel();
            this.gbByCode = new System.Windows.Forms.GroupBox();
            this.pnlByCodeHost = new System.Windows.Forms.Panel();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.tlpRoot.SuspendLayout();
            this.pnlToolbar.SuspendLayout();
            this.flToolbar.SuspendLayout();
            this.tlpTopRow.SuspendLayout();
            this.tlpKpi.SuspendLayout();
            this.cardK1.SuspendLayout();
            this.cardK2.SuspendLayout();
            this.cardK3.SuspendLayout();
            this.cardK4.SuspendLayout();
            this.gbTrend.SuspendLayout();
            this.tlpBottomRow.SuspendLayout();
            this.gbByMachine.SuspendLayout();
            this.gbByCode.SuspendLayout();
            this.gbDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpRoot
            // 
            this.tlpRoot.ColumnCount = 1;
            this.tlpRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpRoot.Controls.Add(this.pnlToolbar, 0, 0);
            this.tlpRoot.Controls.Add(this.tlpTopRow, 0, 1);
            this.tlpRoot.Controls.Add(this.tlpBottomRow, 0, 2);
            this.tlpRoot.Controls.Add(this.gbDetails, 0, 3);
            this.tlpRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRoot.Location = new System.Drawing.Point(0, 0);
            this.tlpRoot.Name = "tlpRoot";
            this.tlpRoot.RowCount = 4;
            this.tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tlpRoot.Size = new System.Drawing.Size(1182, 773);
            this.tlpRoot.TabIndex = 0;
            // 
            // pnlToolbar
            // 
            this.pnlToolbar.Controls.Add(this.flToolbar);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Location = new System.Drawing.Point(3, 3);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Size = new System.Drawing.Size(1176, 56);
            this.pnlToolbar.TabIndex = 0;
            // 
            // flToolbar
            // 
            this.flToolbar.Controls.Add(this.lblTitle);
            this.flToolbar.Controls.Add(this.lblDate);
            this.flToolbar.Controls.Add(this.dtpFrom);
            this.flToolbar.Controls.Add(this.lblTo);
            this.flToolbar.Controls.Add(this.dtpTo);
            this.flToolbar.Controls.Add(this.txtSearch);
            this.flToolbar.Controls.Add(this.cboLevel);
            this.flToolbar.Controls.Add(this.btnApply);
            this.flToolbar.Controls.Add(this.btnReset);
            this.flToolbar.Controls.Add(this.btnRescan);
            this.flToolbar.Controls.Add(this.btnExport);
            this.flToolbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flToolbar.Location = new System.Drawing.Point(0, 0);
            this.flToolbar.Name = "flToolbar";
            this.flToolbar.Size = new System.Drawing.Size(1176, 56);
            this.flToolbar.TabIndex = 0;
            this.flToolbar.WrapContents = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(0, 4);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0, 4, 16, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(149, 22);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Alarm Dashboard";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(168, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(44, 22);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "日期";
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "yyyy-MM-dd";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(218, 3);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 29);
            this.dtpFrom.TabIndex = 2;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(424, 0);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(28, 22);
            this.lblTo.TabIndex = 3;
            this.lblTo.Text = "—";
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "yyyy-MM-dd";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(458, 3);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 29);
            this.dtpTo.TabIndex = 4;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(664, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(220, 29);
            this.txtSearch.TabIndex = 5;
            // 
            // cboLevel
            // 
            this.cboLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLevel.Location = new System.Drawing.Point(890, 3);
            this.cboLevel.Name = "cboLevel";
            this.cboLevel.Size = new System.Drawing.Size(100, 30);
            this.cboLevel.TabIndex = 6;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(996, 3);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 7;
            this.btnApply.Text = "套用";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(1077, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "重置";
            // 
            // btnRescan
            // 
            this.btnRescan.Location = new System.Drawing.Point(1158, 3);
            this.btnRescan.Name = "btnRescan";
            this.btnRescan.Size = new System.Drawing.Size(75, 23);
            this.btnRescan.TabIndex = 9;
            this.btnRescan.Text = "重新掃描";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(1239, 3);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 10;
            this.btnExport.Text = "匯出 CSV";
            // 
            // tlpTopRow
            // 
            this.tlpTopRow.ColumnCount = 2;
            this.tlpTopRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTopRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTopRow.Controls.Add(this.tlpKpi, 0, 0);
            this.tlpTopRow.Controls.Add(this.gbTrend, 1, 0);
            this.tlpTopRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTopRow.Location = new System.Drawing.Point(3, 65);
            this.tlpTopRow.Name = "tlpTopRow";
            this.tlpTopRow.RowCount = 1;
            this.tlpTopRow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpTopRow.Size = new System.Drawing.Size(1176, 114);
            this.tlpTopRow.TabIndex = 1;
            // 
            // tlpKpi
            // 
            this.tlpKpi.ColumnCount = 4;
            this.tlpKpi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpKpi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpKpi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpKpi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpKpi.Controls.Add(this.cardK1, 0, 0);
            this.tlpKpi.Controls.Add(this.cardK2, 1, 0);
            this.tlpKpi.Controls.Add(this.cardK3, 2, 0);
            this.tlpKpi.Controls.Add(this.cardK4, 3, 0);
            this.tlpKpi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpKpi.Location = new System.Drawing.Point(3, 3);
            this.tlpKpi.Name = "tlpKpi";
            this.tlpKpi.RowCount = 1;
            this.tlpKpi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpKpi.Size = new System.Drawing.Size(582, 108);
            this.tlpKpi.TabIndex = 0;
            // 
            // cardK1
            // 
            this.cardK1.Controls.Add(this.lblKpi1Value);
            this.cardK1.Controls.Add(this.lblKpi1Title);
            this.cardK1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardK1.Location = new System.Drawing.Point(3, 3);
            this.cardK1.Name = "cardK1";
            this.cardK1.Size = new System.Drawing.Size(139, 102);
            this.cardK1.TabIndex = 0;
            // 
            // lblKpi1Value
            // 
            this.lblKpi1Value.AutoSize = true;
            this.lblKpi1Value.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblKpi1Value.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblKpi1Value.Location = new System.Drawing.Point(0, 22);
            this.lblKpi1Value.Name = "lblKpi1Value";
            this.lblKpi1Value.Size = new System.Drawing.Size(56, 43);
            this.lblKpi1Value.TabIndex = 0;
            this.lblKpi1Value.Text = "—";
            // 
            // lblKpi1Title
            // 
            this.lblKpi1Title.AutoSize = true;
            this.lblKpi1Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblKpi1Title.Location = new System.Drawing.Point(0, 0);
            this.lblKpi1Title.Name = "lblKpi1Title";
            this.lblKpi1Title.Size = new System.Drawing.Size(78, 22);
            this.lblKpi1Title.TabIndex = 1;
            this.lblKpi1Title.Text = "本期警報";
            // 
            // cardK2
            // 
            this.cardK2.Controls.Add(this.lblKpi2Value);
            this.cardK2.Controls.Add(this.lblKpi2Title);
            this.cardK2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardK2.Location = new System.Drawing.Point(148, 3);
            this.cardK2.Name = "cardK2";
            this.cardK2.Size = new System.Drawing.Size(139, 102);
            this.cardK2.TabIndex = 1;
            // 
            // lblKpi2Value
            // 
            this.lblKpi2Value.AutoSize = true;
            this.lblKpi2Value.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblKpi2Value.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblKpi2Value.Location = new System.Drawing.Point(0, 22);
            this.lblKpi2Value.Name = "lblKpi2Value";
            this.lblKpi2Value.Size = new System.Drawing.Size(56, 43);
            this.lblKpi2Value.TabIndex = 0;
            this.lblKpi2Value.Text = "—";
            // 
            // lblKpi2Title
            // 
            this.lblKpi2Title.AutoSize = true;
            this.lblKpi2Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblKpi2Title.Location = new System.Drawing.Point(0, 0);
            this.lblKpi2Title.Name = "lblKpi2Title";
            this.lblKpi2Title.Size = new System.Drawing.Size(78, 22);
            this.lblKpi2Title.TabIndex = 1;
            this.lblKpi2Title.Text = "影響機台";
            // 
            // cardK3
            // 
            this.cardK3.Controls.Add(this.lblKpi3Value);
            this.cardK3.Controls.Add(this.lblKpi3Title);
            this.cardK3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardK3.Location = new System.Drawing.Point(293, 3);
            this.cardK3.Name = "cardK3";
            this.cardK3.Size = new System.Drawing.Size(139, 102);
            this.cardK3.TabIndex = 2;
            // 
            // lblKpi3Value
            // 
            this.lblKpi3Value.AutoSize = true;
            this.lblKpi3Value.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblKpi3Value.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblKpi3Value.Location = new System.Drawing.Point(0, 22);
            this.lblKpi3Value.Name = "lblKpi3Value";
            this.lblKpi3Value.Size = new System.Drawing.Size(56, 43);
            this.lblKpi3Value.TabIndex = 0;
            this.lblKpi3Value.Text = "—";
            // 
            // lblKpi3Title
            // 
            this.lblKpi3Title.AutoSize = true;
            this.lblKpi3Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblKpi3Title.Location = new System.Drawing.Point(0, 0);
            this.lblKpi3Title.Name = "lblKpi3Title";
            this.lblKpi3Title.Size = new System.Drawing.Size(80, 22);
            this.lblKpi3Title.TabIndex = 1;
            this.lblKpi3Title.Text = "Top 代碼";
            // 
            // cardK4
            // 
            this.cardK4.Controls.Add(this.lblKpi4Value);
            this.cardK4.Controls.Add(this.lblKpi4Title);
            this.cardK4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardK4.Location = new System.Drawing.Point(438, 3);
            this.cardK4.Name = "cardK4";
            this.cardK4.Size = new System.Drawing.Size(141, 102);
            this.cardK4.TabIndex = 3;
            // 
            // lblKpi4Value
            // 
            this.lblKpi4Value.AutoSize = true;
            this.lblKpi4Value.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblKpi4Value.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblKpi4Value.Location = new System.Drawing.Point(0, 22);
            this.lblKpi4Value.Name = "lblKpi4Value";
            this.lblKpi4Value.Size = new System.Drawing.Size(56, 43);
            this.lblKpi4Value.TabIndex = 0;
            this.lblKpi4Value.Text = "—";
            // 
            // lblKpi4Title
            // 
            this.lblKpi4Title.AutoSize = true;
            this.lblKpi4Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblKpi4Title.Location = new System.Drawing.Point(0, 0);
            this.lblKpi4Title.Name = "lblKpi4Title";
            this.lblKpi4Title.Size = new System.Drawing.Size(61, 22);
            this.lblKpi4Title.TabIndex = 1;
            this.lblKpi4Title.Text = "較上期";
            // 
            // gbTrend
            // 
            this.gbTrend.Controls.Add(this.pnlTrendHost);
            this.gbTrend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTrend.Location = new System.Drawing.Point(591, 3);
            this.gbTrend.Name = "gbTrend";
            this.gbTrend.Size = new System.Drawing.Size(582, 108);
            this.gbTrend.TabIndex = 1;
            this.gbTrend.TabStop = false;
            this.gbTrend.Text = "每日 WARN 趨勢";
            // 
            // pnlTrendHost
            // 
            this.pnlTrendHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTrendHost.Location = new System.Drawing.Point(3, 25);
            this.pnlTrendHost.Name = "pnlTrendHost";
            this.pnlTrendHost.Size = new System.Drawing.Size(576, 80);
            this.pnlTrendHost.TabIndex = 0;
            // 
            // tlpBottomRow
            // 
            this.tlpBottomRow.ColumnCount = 2;
            this.tlpBottomRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBottomRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBottomRow.Controls.Add(this.gbByMachine, 0, 0);
            this.tlpBottomRow.Controls.Add(this.gbByCode, 1, 0);
            this.tlpBottomRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBottomRow.Location = new System.Drawing.Point(3, 185);
            this.tlpBottomRow.Name = "tlpBottomRow";
            this.tlpBottomRow.RowCount = 1;
            this.tlpBottomRow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpBottomRow.Size = new System.Drawing.Size(1176, 319);
            this.tlpBottomRow.TabIndex = 2;
            // 
            // gbByMachine
            // 
            this.gbByMachine.Controls.Add(this.pnlByMachineHost);
            this.gbByMachine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbByMachine.Location = new System.Drawing.Point(3, 3);
            this.gbByMachine.Name = "gbByMachine";
            this.gbByMachine.Size = new System.Drawing.Size(582, 313);
            this.gbByMachine.TabIndex = 0;
            this.gbByMachine.TabStop = false;
            this.gbByMachine.Text = "各機台 WARN 次數";
            // 
            // pnlByMachineHost
            // 
            this.pnlByMachineHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlByMachineHost.Location = new System.Drawing.Point(3, 25);
            this.pnlByMachineHost.Name = "pnlByMachineHost";
            this.pnlByMachineHost.Size = new System.Drawing.Size(576, 285);
            this.pnlByMachineHost.TabIndex = 0;
            // 
            // gbByCode
            // 
            this.gbByCode.Controls.Add(this.pnlByCodeHost);
            this.gbByCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbByCode.Location = new System.Drawing.Point(591, 3);
            this.gbByCode.Name = "gbByCode";
            this.gbByCode.Size = new System.Drawing.Size(582, 313);
            this.gbByCode.TabIndex = 1;
            this.gbByCode.TabStop = false;
            this.gbByCode.Text = "各警報代碼 WARN 次數";
            // 
            // pnlByCodeHost
            // 
            this.pnlByCodeHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlByCodeHost.Location = new System.Drawing.Point(3, 25);
            this.pnlByCodeHost.Name = "pnlByCodeHost";
            this.pnlByCodeHost.Size = new System.Drawing.Size(576, 285);
            this.pnlByCodeHost.TabIndex = 0;
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.dgvDetails);
            this.gbDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDetails.Location = new System.Drawing.Point(3, 510);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(1176, 260);
            this.gbDetails.TabIndex = 3;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "明細";
            // 
            // dgvDetails
            // 
            this.dgvDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetails.ColumnHeadersHeight = 29;
            this.dgvDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetails.Location = new System.Drawing.Point(3, 25);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.RowHeadersWidth = 51;
            this.dgvDetails.Size = new System.Drawing.Size(1170, 232);
            this.dgvDetails.TabIndex = 0;
            // 
            // AlarmDashboardView
            // 
            this.Controls.Add(this.tlpRoot);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F);
            this.Name = "AlarmDashboardView";
            this.Size = new System.Drawing.Size(1182, 773);
            this.tlpRoot.ResumeLayout(false);
            this.pnlToolbar.ResumeLayout(false);
            this.flToolbar.ResumeLayout(false);
            this.flToolbar.PerformLayout();
            this.tlpTopRow.ResumeLayout(false);
            this.tlpKpi.ResumeLayout(false);
            this.cardK1.ResumeLayout(false);
            this.cardK1.PerformLayout();
            this.cardK2.ResumeLayout(false);
            this.cardK2.PerformLayout();
            this.cardK3.ResumeLayout(false);
            this.cardK3.PerformLayout();
            this.cardK4.ResumeLayout(false);
            this.cardK4.PerformLayout();
            this.gbTrend.ResumeLayout(false);
            this.tlpBottomRow.ResumeLayout(false);
            this.gbByMachine.ResumeLayout(false);
            this.gbByCode.ResumeLayout(false);
            this.gbDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
