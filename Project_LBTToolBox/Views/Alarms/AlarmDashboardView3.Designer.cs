namespace Project_LBTToolBox.Views.Alarms
{
    partial class AlarmDashboardView3
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tlpRoot = new System.Windows.Forms.TableLayoutPanel();
            this.gbSource = new System.Windows.Forms.GroupBox();
            this.tlpSource = new System.Windows.Forms.TableLayoutPanel();
            this.flpSourceMode = new System.Windows.Forms.FlowLayoutPanel();
            this.rdbRemote = new System.Windows.Forms.RadioButton();
            this.rdbLocal = new System.Windows.Forms.RadioButton();
            this.btnApply = new System.Windows.Forms.Button();
            this.gbExportActions = new System.Windows.Forms.GroupBox();
            this.flpExportButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnExportWarnCodesCsv = new System.Windows.Forms.Button();
            this.btnExportAlarmsCsv = new System.Windows.Forms.Button();
            this.btnExportAllAlarmsCsv = new System.Windows.Forms.Button();
            this.lblSourceMode = new System.Windows.Forms.Label();
            this.lblRemotePath = new System.Windows.Forms.Label();
            this.txtRemotePath = new System.Windows.Forms.TextBox();
            this.btnBrowseRemote = new System.Windows.Forms.Button();
            this.btnTestRemote = new System.Windows.Forms.Button();
            this.lblLocalPath = new System.Windows.Forms.Label();
            this.txtLocalPath = new System.Windows.Forms.TextBox();
            this.btnBrowseLocal = new System.Windows.Forms.Button();
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.gbFilters = new System.Windows.Forms.GroupBox();
            this.tlpFilters = new System.Windows.Forms.TableLayoutPanel();
            this.panelDateFilter = new System.Windows.Forms.Panel();
            this.ckbDateRangeEnable = new System.Windows.Forms.CheckBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.panelMachines = new System.Windows.Forms.Panel();
            this.lblMachines = new System.Windows.Forms.Label();
            this.clbMachines = new System.Windows.Forms.CheckedListBox();
            this.panelMachineActions = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMachinesAll = new System.Windows.Forms.Button();
            this.btnMachinesClear = new System.Windows.Forms.Button();
            this.panelCodeFilter = new System.Windows.Forms.Panel();
            this.lblWarnCodeFilter = new System.Windows.Forms.Label();
            this.panelWarnCodeFilterInput = new System.Windows.Forms.Panel();
            this.txtWarnCodeFilter = new System.Windows.Forms.TextBox();
            this.pbWarnCodeFilterClear = new System.Windows.Forms.PictureBox();
            this.panelFilterHint = new System.Windows.Forms.Panel();
            this.lblFilterHint = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.tlpRight = new System.Windows.Forms.TableLayoutPanel();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.tlpStatus = new System.Windows.Forms.TableLayoutPanel();
            this.lblCurrentModeTitle = new System.Windows.Forms.Label();
            this.lblCurrentMode = new System.Windows.Forms.Label();
            this.lblDatabasePathTitle = new System.Windows.Forms.Label();
            this.lblDatabasePath = new System.Windows.Forms.Label();
            this.lblSourceStatusTitle = new System.Windows.Forms.Label();
            this.lblSourceStatus = new System.Windows.Forms.Label();
            this.tlpKpi = new System.Windows.Forms.TableLayoutPanel();
            this.gbTotalAlarms = new System.Windows.Forms.GroupBox();
            this.lblTotalAlarms = new System.Windows.Forms.Label();
            this.gbMaxAlarm = new System.Windows.Forms.GroupBox();
            this.lblMaxAlarmCode = new System.Windows.Forms.Label();
            this.lblMaxAlarmCodeTimes = new System.Windows.Forms.Label();
            this.gbMaxMachine = new System.Windows.Forms.GroupBox();
            this.lblMaxMachine = new System.Windows.Forms.Label();
            this.splitRight = new System.Windows.Forms.SplitContainer();
            this.tcCharts = new System.Windows.Forms.TabControl();
            this.tpOverview = new System.Windows.Forms.TabPage();
            this.tlpCharts = new System.Windows.Forms.TableLayoutPanel();
            this.fpCodeBar = new ScottPlot.FormsPlot();
            this.fpPareto = new ScottPlot.FormsPlot();
            this.fpMachineBar = new ScottPlot.FormsPlot();
            this.fpDailyTrend = new ScottPlot.FormsPlot();
            this.tpPattern = new System.Windows.Forms.TabPage();
            this.fpHourHistogram = new ScottPlot.FormsPlot();
            this.splitData = new System.Windows.Forms.SplitContainer();
            this.gbWarnCode = new System.Windows.Forms.GroupBox();
            this.tlpWarnCode = new System.Windows.Forms.TableLayoutPanel();
            this.panelWarnCodeSearch = new System.Windows.Forms.Panel();
            this.lblWarnCodeSearch = new System.Windows.Forms.Label();
            this.panelWarnCodeSearchInput = new System.Windows.Forms.Panel();
            this.txtWarnCodeSearch = new System.Windows.Forms.TextBox();
            this.pbWarnCodeSearchClear = new System.Windows.Forms.PictureBox();
            this.dgvWareCode = new System.Windows.Forms.DataGridView();
            this.gbAlarmDetails = new System.Windows.Forms.GroupBox();
            this.panelDetails = new System.Windows.Forms.Panel();
            this.dgvAlarmTable = new System.Windows.Forms.DataGridView();
            this.panelPaging = new System.Windows.Forms.Panel();
            this.tlpPaging = new System.Windows.Forms.TableLayoutPanel();
            this.btnPrevPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.lblPagingStatus = new System.Windows.Forms.Label();
            this.txtJumpPage = new System.Windows.Forms.TextBox();
            this.btnJumpPage = new System.Windows.Forms.Button();
            this.tlpRoot.SuspendLayout();
            this.gbSource.SuspendLayout();
            this.tlpSource.SuspendLayout();
            this.flpSourceMode.SuspendLayout();
            this.gbExportActions.SuspendLayout();
            this.flpExportButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.gbFilters.SuspendLayout();
            this.tlpFilters.SuspendLayout();
            this.panelDateFilter.SuspendLayout();
            this.panelMachines.SuspendLayout();
            this.panelMachineActions.SuspendLayout();
            this.panelCodeFilter.SuspendLayout();
            this.panelWarnCodeFilterInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarnCodeFilterClear)).BeginInit();
            this.panelFilterHint.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.tlpRight.SuspendLayout();
            this.panelStatus.SuspendLayout();
            this.tlpStatus.SuspendLayout();
            this.tlpKpi.SuspendLayout();
            this.gbTotalAlarms.SuspendLayout();
            this.gbMaxAlarm.SuspendLayout();
            this.gbMaxMachine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitRight)).BeginInit();
            this.splitRight.Panel1.SuspendLayout();
            this.splitRight.Panel2.SuspendLayout();
            this.splitRight.SuspendLayout();
            this.tcCharts.SuspendLayout();
            this.tpOverview.SuspendLayout();
            this.tlpCharts.SuspendLayout();
            this.tpPattern.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitData)).BeginInit();
            this.splitData.Panel1.SuspendLayout();
            this.splitData.Panel2.SuspendLayout();
            this.splitData.SuspendLayout();
            this.gbWarnCode.SuspendLayout();
            this.tlpWarnCode.SuspendLayout();
            this.panelWarnCodeSearch.SuspendLayout();
            this.panelWarnCodeSearchInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarnCodeSearchClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWareCode)).BeginInit();
            this.gbAlarmDetails.SuspendLayout();
            this.panelDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlarmTable)).BeginInit();
            this.panelPaging.SuspendLayout();
            this.tlpPaging.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpRoot
            // 
            this.tlpRoot.ColumnCount = 1;
            this.tlpRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRoot.Controls.Add(this.gbSource, 0, 0);
            this.tlpRoot.Controls.Add(this.splitMain, 0, 1);
            this.tlpRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRoot.Location = new System.Drawing.Point(0, 0);
            this.tlpRoot.Margin = new System.Windows.Forms.Padding(0);
            this.tlpRoot.Name = "tlpRoot";
            this.tlpRoot.RowCount = 2;
            this.tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRoot.Size = new System.Drawing.Size(1400, 900);
            this.tlpRoot.TabIndex = 0;
            // 
            // gbSource
            // 
            this.gbSource.Controls.Add(this.tlpSource);
            this.gbSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSource.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold);
            this.gbSource.Location = new System.Drawing.Point(8, 6);
            this.gbSource.Margin = new System.Windows.Forms.Padding(8, 6, 8, 4);
            this.gbSource.Name = "gbSource";
            this.gbSource.Padding = new System.Windows.Forms.Padding(12, 12, 12, 10);
            this.gbSource.Size = new System.Drawing.Size(1384, 154);
            this.gbSource.TabIndex = 0;
            this.gbSource.TabStop = false;
            this.gbSource.Text = "Analysis Source";
            // 
            // tlpSource
            // 
            this.tlpSource.ColumnCount = 6;
            this.tlpSource.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tlpSource.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSource.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tlpSource.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tlpSource.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tlpSource.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 264F));
            this.tlpSource.Controls.Add(this.lblSourceMode, 0, 0);
            this.tlpSource.Controls.Add(this.flpSourceMode, 1, 0);
            this.tlpSource.Controls.Add(this.lblRemotePath, 0, 1);
            this.tlpSource.Controls.Add(this.txtRemotePath, 1, 1);
            this.tlpSource.Controls.Add(this.btnBrowseRemote, 2, 1);
            this.tlpSource.Controls.Add(this.btnTestRemote, 3, 1);
            this.tlpSource.Controls.Add(this.lblLocalPath, 0, 2);
            this.tlpSource.Controls.Add(this.txtLocalPath, 1, 2);
            this.tlpSource.Controls.Add(this.btnBrowseLocal, 2, 2);
            this.tlpSource.Controls.Add(this.btnApply, 4, 0);
            this.tlpSource.Controls.Add(this.gbExportActions, 5, 0);
            this.tlpSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSource.Location = new System.Drawing.Point(12, 43);
            this.tlpSource.Margin = new System.Windows.Forms.Padding(0);
            this.tlpSource.Name = "tlpSource";
            this.tlpSource.RowCount = 3;
            this.tlpSource.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tlpSource.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpSource.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpSource.Size = new System.Drawing.Size(1360, 101);
            this.tlpSource.TabIndex = 0;
            // 
            // flpSourceMode
            // 
            this.tlpSource.SetColumnSpan(this.flpSourceMode, 3);
            this.flpSourceMode.Controls.Add(this.rdbRemote);
            this.flpSourceMode.Controls.Add(this.rdbLocal);
            this.flpSourceMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpSourceMode.Location = new System.Drawing.Point(122, 0);
            this.flpSourceMode.Margin = new System.Windows.Forms.Padding(0);
            this.flpSourceMode.Name = "flpSourceMode";
            this.flpSourceMode.Size = new System.Drawing.Size(842, 34);
            this.flpSourceMode.TabIndex = 1;
            this.flpSourceMode.WrapContents = false;
            // 
            // rdbRemote
            // 
            this.rdbRemote.AutoSize = true;
            this.rdbRemote.Font = new System.Drawing.Font("微軟正黑體", 10.8F);
            this.rdbRemote.Location = new System.Drawing.Point(0, 2);
            this.rdbRemote.Margin = new System.Windows.Forms.Padding(0, 2, 14, 0);
            this.rdbRemote.Name = "rdbRemote";
            this.rdbRemote.Size = new System.Drawing.Size(98, 27);
            this.rdbRemote.TabIndex = 0;
            this.rdbRemote.Text = "Remote";
            this.rdbRemote.UseVisualStyleBackColor = true;
            // 
            // rdbLocal
            // 
            this.rdbLocal.AutoSize = true;
            this.rdbLocal.Font = new System.Drawing.Font("微軟正黑體", 10.8F);
            this.rdbLocal.Location = new System.Drawing.Point(112, 2);
            this.rdbLocal.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.rdbLocal.Name = "rdbLocal";
            this.rdbLocal.Size = new System.Drawing.Size(75, 27);
            this.rdbLocal.TabIndex = 1;
            this.rdbLocal.Text = "Local";
            this.rdbLocal.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            this.btnApply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnApply.Font = new System.Drawing.Font("微軟正黑體", 11.5F, System.Drawing.FontStyle.Bold);
            this.btnApply.Location = new System.Drawing.Point(980, 6);
            this.btnApply.Margin = new System.Windows.Forms.Padding(16, 6, 10, 6);
            this.btnApply.Name = "btnApply";
            this.tlpSource.SetRowSpan(this.btnApply, 3);
            this.btnApply.Size = new System.Drawing.Size(106, 94);
            this.btnApply.TabIndex = 9;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            // 
            // gbExportActions
            // 
            this.gbExportActions.Controls.Add(this.flpExportButtons);
            this.gbExportActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbExportActions.Font = new System.Drawing.Font("微軟正黑體", 9.8F, System.Drawing.FontStyle.Bold);
            this.gbExportActions.Location = new System.Drawing.Point(1096, 3);
            this.gbExportActions.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.gbExportActions.Name = "gbExportActions";
            this.tlpSource.SetRowSpan(this.gbExportActions, 3);
            this.gbExportActions.Size = new System.Drawing.Size(264, 100);
            this.gbExportActions.TabIndex = 10;
            this.gbExportActions.TabStop = false;
            this.gbExportActions.Text = "Export";
            // 
            // flpExportButtons
            // 
            this.flpExportButtons.Controls.Add(this.btnExportWarnCodesCsv);
            this.flpExportButtons.Controls.Add(this.btnExportAlarmsCsv);
            this.flpExportButtons.Controls.Add(this.btnExportAllAlarmsCsv);
            this.flpExportButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpExportButtons.Location = new System.Drawing.Point(3, 25);
            this.flpExportButtons.Name = "flpExportButtons";
            this.flpExportButtons.Padding = new System.Windows.Forms.Padding(10, 4, 10, 4);
            this.flpExportButtons.Size = new System.Drawing.Size(258, 72);
            this.flpExportButtons.TabIndex = 0;
            this.flpExportButtons.WrapContents = false;
            // 
            // btnExportWarnCodesCsv
            // 
            this.btnExportWarnCodesCsv.Font = new System.Drawing.Font("微軟正黑體", 9.2F);
            this.btnExportWarnCodesCsv.Location = new System.Drawing.Point(10, 4);
            this.btnExportWarnCodesCsv.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnExportWarnCodesCsv.Name = "btnExportWarnCodesCsv";
            this.btnExportWarnCodesCsv.Size = new System.Drawing.Size(70, 29);
            this.btnExportWarnCodesCsv.TabIndex = 0;
            this.btnExportWarnCodesCsv.Text = "Codes";
            this.btnExportWarnCodesCsv.UseVisualStyleBackColor = true;
            // 
            // btnExportAlarmsCsv
            // 
            this.btnExportAlarmsCsv.Font = new System.Drawing.Font("微軟正黑體", 9.2F);
            this.btnExportAlarmsCsv.Location = new System.Drawing.Point(88, 4);
            this.btnExportAlarmsCsv.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnExportAlarmsCsv.Name = "btnExportAlarmsCsv";
            this.btnExportAlarmsCsv.Size = new System.Drawing.Size(70, 29);
            this.btnExportAlarmsCsv.TabIndex = 1;
            this.btnExportAlarmsCsv.Text = "Page";
            this.btnExportAlarmsCsv.UseVisualStyleBackColor = true;
            // 
            // btnExportAllAlarmsCsv
            // 
            this.btnExportAllAlarmsCsv.Font = new System.Drawing.Font("微軟正黑體", 9.2F);
            this.btnExportAllAlarmsCsv.Location = new System.Drawing.Point(166, 4);
            this.btnExportAllAlarmsCsv.Margin = new System.Windows.Forms.Padding(0);
            this.btnExportAllAlarmsCsv.Name = "btnExportAllAlarmsCsv";
            this.btnExportAllAlarmsCsv.Size = new System.Drawing.Size(70, 29);
            this.btnExportAllAlarmsCsv.TabIndex = 2;
            this.btnExportAllAlarmsCsv.Text = "All";
            this.btnExportAllAlarmsCsv.UseVisualStyleBackColor = true;
            // 
            // lblSourceMode
            // 
            this.lblSourceMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSourceMode.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblSourceMode.Location = new System.Drawing.Point(0, 0);
            this.lblSourceMode.Margin = new System.Windows.Forms.Padding(0);
            this.lblSourceMode.Name = "lblSourceMode";
            this.lblSourceMode.Size = new System.Drawing.Size(122, 34);
            this.lblSourceMode.TabIndex = 0;
            this.lblSourceMode.Text = "Source Mode";
            this.lblSourceMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRemotePath
            // 
            this.lblRemotePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRemotePath.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblRemotePath.Location = new System.Drawing.Point(0, 34);
            this.lblRemotePath.Margin = new System.Windows.Forms.Padding(0);
            this.lblRemotePath.Name = "lblRemotePath";
            this.lblRemotePath.Size = new System.Drawing.Size(122, 36);
            this.lblRemotePath.TabIndex = 2;
            this.lblRemotePath.Text = "Remote NAS";
            this.lblRemotePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRemotePath
            // 
            this.txtRemotePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRemotePath.Font = new System.Drawing.Font("微軟正黑體", 10.2F);
            this.txtRemotePath.Location = new System.Drawing.Point(122, 37);
            this.txtRemotePath.Margin = new System.Windows.Forms.Padding(0, 3, 6, 3);
            this.txtRemotePath.Name = "txtRemotePath";
            this.txtRemotePath.Size = new System.Drawing.Size(644, 30);
            this.txtRemotePath.TabIndex = 3;
            // 
            // btnBrowseRemote
            // 
            this.btnBrowseRemote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBrowseRemote.Font = new System.Drawing.Font("微軟正黑體", 9.8F);
            this.btnBrowseRemote.Location = new System.Drawing.Point(772, 36);
            this.btnBrowseRemote.Margin = new System.Windows.Forms.Padding(0, 2, 6, 2);
            this.btnBrowseRemote.Name = "btnBrowseRemote";
            this.btnBrowseRemote.Size = new System.Drawing.Size(90, 32);
            this.btnBrowseRemote.TabIndex = 4;
            this.btnBrowseRemote.Text = "Browse";
            this.btnBrowseRemote.UseVisualStyleBackColor = true;
            // 
            // btnTestRemote
            // 
            this.btnTestRemote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTestRemote.Font = new System.Drawing.Font("微軟正黑體", 9.8F);
            this.btnTestRemote.Location = new System.Drawing.Point(868, 36);
            this.btnTestRemote.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.btnTestRemote.Name = "btnTestRemote";
            this.btnTestRemote.Size = new System.Drawing.Size(96, 32);
            this.btnTestRemote.TabIndex = 5;
            this.btnTestRemote.Text = "Check";
            this.btnTestRemote.UseVisualStyleBackColor = true;
            // 
            // lblLocalPath
            // 
            this.lblLocalPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLocalPath.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblLocalPath.Location = new System.Drawing.Point(0, 70);
            this.lblLocalPath.Margin = new System.Windows.Forms.Padding(0);
            this.lblLocalPath.Name = "lblLocalPath";
            this.lblLocalPath.Size = new System.Drawing.Size(122, 36);
            this.lblLocalPath.TabIndex = 6;
            this.lblLocalPath.Text = "Local Folder";
            this.lblLocalPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLocalPath
            // 
            this.txtLocalPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLocalPath.Font = new System.Drawing.Font("微軟正黑體", 10.2F);
            this.txtLocalPath.Location = new System.Drawing.Point(122, 73);
            this.txtLocalPath.Margin = new System.Windows.Forms.Padding(0, 3, 6, 3);
            this.txtLocalPath.Name = "txtLocalPath";
            this.txtLocalPath.Size = new System.Drawing.Size(644, 30);
            this.txtLocalPath.TabIndex = 7;
            // 
            // btnBrowseLocal
            // 
            this.btnBrowseLocal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBrowseLocal.Font = new System.Drawing.Font("微軟正黑體", 9.8F);
            this.btnBrowseLocal.Location = new System.Drawing.Point(772, 72);
            this.btnBrowseLocal.Margin = new System.Windows.Forms.Padding(0, 2, 6, 2);
            this.btnBrowseLocal.Name = "btnBrowseLocal";
            this.btnBrowseLocal.Size = new System.Drawing.Size(90, 32);
            this.btnBrowseLocal.TabIndex = 8;
            this.btnBrowseLocal.Text = "Browse";
            this.btnBrowseLocal.UseVisualStyleBackColor = true;
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitMain.Location = new System.Drawing.Point(8, 168);
            this.splitMain.Margin = new System.Windows.Forms.Padding(8, 4, 8, 8);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.gbFilters);
            this.splitMain.Panel1MinSize = 284;
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.panelRight);
            this.splitMain.Panel2MinSize = 780;
            this.splitMain.Size = new System.Drawing.Size(1384, 724);
            this.splitMain.SplitterDistance = 300;
            this.splitMain.TabIndex = 1;
            // 
            // gbFilters
            // 
            this.gbFilters.Controls.Add(this.tlpFilters);
            this.gbFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFilters.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold);
            this.gbFilters.Location = new System.Drawing.Point(0, 0);
            this.gbFilters.Name = "gbFilters";
            this.gbFilters.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.gbFilters.Size = new System.Drawing.Size(300, 724);
            this.gbFilters.TabIndex = 0;
            this.gbFilters.TabStop = false;
            this.gbFilters.Text = "Focus Filters";
            // 
            // tlpFilters
            // 
            this.tlpFilters.ColumnCount = 1;
            this.tlpFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFilters.Controls.Add(this.panelDateFilter, 0, 0);
            this.tlpFilters.Controls.Add(this.panelMachines, 0, 1);
            this.tlpFilters.Controls.Add(this.panelCodeFilter, 0, 2);
            this.tlpFilters.Controls.Add(this.panelFilterHint, 0, 3);
            this.tlpFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFilters.Location = new System.Drawing.Point(12, 41);
            this.tlpFilters.Name = "tlpFilters";
            this.tlpFilters.RowCount = 4;
            this.tlpFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 178F));
            this.tlpFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tlpFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tlpFilters.Size = new System.Drawing.Size(276, 673);
            this.tlpFilters.TabIndex = 0;
            // 
            // panelDateFilter
            // 
            this.panelDateFilter.Controls.Add(this.ckbDateRangeEnable);
            this.panelDateFilter.Controls.Add(this.lblStartDate);
            this.panelDateFilter.Controls.Add(this.dtpFrom);
            this.panelDateFilter.Controls.Add(this.lblEndDate);
            this.panelDateFilter.Controls.Add(this.dtpTo);
            this.panelDateFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDateFilter.Location = new System.Drawing.Point(0, 0);
            this.panelDateFilter.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.panelDateFilter.Name = "panelDateFilter";
            this.panelDateFilter.Size = new System.Drawing.Size(276, 168);
            this.panelDateFilter.TabIndex = 0;
            // 
            // ckbDateRangeEnable
            // 
            this.ckbDateRangeEnable.AutoSize = true;
            this.ckbDateRangeEnable.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold);
            this.ckbDateRangeEnable.Location = new System.Drawing.Point(0, 4);
            this.ckbDateRangeEnable.Name = "ckbDateRangeEnable";
            this.ckbDateRangeEnable.Size = new System.Drawing.Size(179, 26);
            this.ckbDateRangeEnable.TabIndex = 0;
            this.ckbDateRangeEnable.Text = "Enable Date Filter";
            this.ckbDateRangeEnable.UseVisualStyleBackColor = true;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblStartDate.Location = new System.Drawing.Point(0, 44);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(51, 22);
            this.lblStartDate.TabIndex = 1;
            this.lblStartDate.Text = "Start";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFrom.Font = new System.Drawing.Font("微軟正黑體", 10.2F);
            this.dtpFrom.Location = new System.Drawing.Point(0, 69);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(346, 30);
            this.dtpFrom.TabIndex = 2;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblEndDate.Location = new System.Drawing.Point(0, 110);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(41, 22);
            this.lblEndDate.TabIndex = 3;
            this.lblEndDate.Text = "End";
            // 
            // dtpTo
            // 
            this.dtpTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpTo.Font = new System.Drawing.Font("微軟正黑體", 10.2F);
            this.dtpTo.Location = new System.Drawing.Point(0, 135);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(346, 30);
            this.dtpTo.TabIndex = 4;
            // 
            // panelMachines
            // 
            this.panelMachines.Controls.Add(this.lblMachines);
            this.panelMachines.Controls.Add(this.clbMachines);
            this.panelMachines.Controls.Add(this.panelMachineActions);
            this.panelMachines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMachines.Location = new System.Drawing.Point(0, 178);
            this.panelMachines.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.panelMachines.Name = "panelMachines";
            this.panelMachines.Size = new System.Drawing.Size(276, 301);
            this.panelMachines.TabIndex = 1;
            // 
            // lblMachines
            // 
            this.lblMachines.AutoSize = true;
            this.lblMachines.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblMachines.Location = new System.Drawing.Point(0, 2);
            this.lblMachines.Name = "lblMachines";
            this.lblMachines.Size = new System.Drawing.Size(91, 22);
            this.lblMachines.TabIndex = 0;
            this.lblMachines.Text = "Machines";
            // 
            // clbMachines
            // 
            this.clbMachines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clbMachines.CheckOnClick = true;
            this.clbMachines.Font = new System.Drawing.Font("微軟正黑體", 10.2F);
            this.clbMachines.IntegralHeight = false;
            this.clbMachines.Location = new System.Drawing.Point(0, 31);
            this.clbMachines.Name = "clbMachines";
            this.clbMachines.Size = new System.Drawing.Size(352, 427);
            this.clbMachines.TabIndex = 1;
            // 
            // panelMachineActions
            // 
            this.panelMachineActions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelMachineActions.Controls.Add(this.btnMachinesAll);
            this.panelMachineActions.Controls.Add(this.btnMachinesClear);
            this.panelMachineActions.Location = new System.Drawing.Point(0, 465);
            this.panelMachineActions.Name = "panelMachineActions";
            this.panelMachineActions.Size = new System.Drawing.Size(184, 34);
            this.panelMachineActions.TabIndex = 2;
            this.panelMachineActions.WrapContents = false;
            // 
            // btnMachinesAll
            // 
            this.btnMachinesAll.Font = new System.Drawing.Font("微軟正黑體", 9.8F);
            this.btnMachinesAll.Location = new System.Drawing.Point(0, 0);
            this.btnMachinesAll.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnMachinesAll.Name = "btnMachinesAll";
            this.btnMachinesAll.Size = new System.Drawing.Size(88, 30);
            this.btnMachinesAll.TabIndex = 0;
            this.btnMachinesAll.Text = "Select All";
            this.btnMachinesAll.UseVisualStyleBackColor = true;
            // 
            // btnMachinesClear
            // 
            this.btnMachinesClear.Font = new System.Drawing.Font("微軟正黑體", 9.8F);
            this.btnMachinesClear.Location = new System.Drawing.Point(96, 0);
            this.btnMachinesClear.Margin = new System.Windows.Forms.Padding(0);
            this.btnMachinesClear.Name = "btnMachinesClear";
            this.btnMachinesClear.Size = new System.Drawing.Size(88, 30);
            this.btnMachinesClear.TabIndex = 1;
            this.btnMachinesClear.Text = "Clear";
            this.btnMachinesClear.UseVisualStyleBackColor = true;
            // 
            // panelCodeFilter
            // 
            this.panelCodeFilter.Controls.Add(this.lblWarnCodeFilter);
            this.panelCodeFilter.Controls.Add(this.panelWarnCodeFilterInput);
            this.panelCodeFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCodeFilter.Location = new System.Drawing.Point(0, 489);
            this.panelCodeFilter.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.panelCodeFilter.Name = "panelCodeFilter";
            this.panelCodeFilter.Size = new System.Drawing.Size(276, 82);
            this.panelCodeFilter.TabIndex = 2;
            // 
            // lblWarnCodeFilter
            // 
            this.lblWarnCodeFilter.AutoSize = true;
            this.lblWarnCodeFilter.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblWarnCodeFilter.Location = new System.Drawing.Point(0, 3);
            this.lblWarnCodeFilter.Name = "lblWarnCodeFilter";
            this.lblWarnCodeFilter.Size = new System.Drawing.Size(151, 22);
            this.lblWarnCodeFilter.TabIndex = 0;
            this.lblWarnCodeFilter.Text = "WarnCode Focus";
            // 
            // panelWarnCodeFilterInput
            // 
            this.panelWarnCodeFilterInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelWarnCodeFilterInput.BackColor = System.Drawing.Color.White;
            this.panelWarnCodeFilterInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWarnCodeFilterInput.Controls.Add(this.txtWarnCodeFilter);
            this.panelWarnCodeFilterInput.Controls.Add(this.pbWarnCodeFilterClear);
            this.panelWarnCodeFilterInput.Location = new System.Drawing.Point(0, 35);
            this.panelWarnCodeFilterInput.Name = "panelWarnCodeFilterInput";
            this.panelWarnCodeFilterInput.Padding = new System.Windows.Forms.Padding(8, 7, 4, 7);
            this.panelWarnCodeFilterInput.Size = new System.Drawing.Size(346, 36);
            this.panelWarnCodeFilterInput.TabIndex = 1;
            // 
            // txtWarnCodeFilter
            // 
            this.txtWarnCodeFilter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWarnCodeFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtWarnCodeFilter.Font = new System.Drawing.Font("微軟正黑體", 10.2F);
            this.txtWarnCodeFilter.Location = new System.Drawing.Point(8, 7);
            this.txtWarnCodeFilter.Name = "txtWarnCodeFilter";
            this.txtWarnCodeFilter.Size = new System.Drawing.Size(310, 23);
            this.txtWarnCodeFilter.TabIndex = 0;
            // 
            // pbWarnCodeFilterClear
            // 
            this.pbWarnCodeFilterClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbWarnCodeFilterClear.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbWarnCodeFilterClear.Image = global::Project_LBTToolBox.Properties.Resources.Cross_mark_icon_in_red;
            this.pbWarnCodeFilterClear.Location = new System.Drawing.Point(318, 7);
            this.pbWarnCodeFilterClear.Name = "pbWarnCodeFilterClear";
            this.pbWarnCodeFilterClear.Size = new System.Drawing.Size(22, 20);
            this.pbWarnCodeFilterClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbWarnCodeFilterClear.TabIndex = 1;
            this.pbWarnCodeFilterClear.TabStop = false;
            // 
            // panelFilterHint
            // 
            this.panelFilterHint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.panelFilterHint.Controls.Add(this.lblFilterHint);
            this.panelFilterHint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFilterHint.Location = new System.Drawing.Point(3, 584);
            this.panelFilterHint.Name = "panelFilterHint";
            this.panelFilterHint.Padding = new System.Windows.Forms.Padding(10);
            this.panelFilterHint.Size = new System.Drawing.Size(270, 86);
            this.panelFilterHint.TabIndex = 3;
            // 
            // lblFilterHint
            // 
            this.lblFilterHint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFilterHint.Font = new System.Drawing.Font("微軟正黑體", 9.2F);
            this.lblFilterHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.lblFilterHint.Location = new System.Drawing.Point(10, 10);
            this.lblFilterHint.Name = "lblFilterHint";
            this.lblFilterHint.Size = new System.Drawing.Size(250, 66);
            this.lblFilterHint.TabIndex = 0;
            this.lblFilterHint.Text = "Tip: double-click a code in the dictionary or the chart to focus that warn code i" +
    "mmediately.";
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.tlpRight);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(0, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(1080, 724);
            this.panelRight.TabIndex = 0;
            // 
            // tlpRight
            // 
            this.tlpRight.ColumnCount = 1;
            this.tlpRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRight.Controls.Add(this.panelStatus, 0, 0);
            this.tlpRight.Controls.Add(this.tlpKpi, 0, 1);
            this.tlpRight.Controls.Add(this.splitRight, 0, 2);
            this.tlpRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRight.Location = new System.Drawing.Point(0, 0);
            this.tlpRight.Name = "tlpRight";
            this.tlpRight.RowCount = 3;
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tlpRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRight.Size = new System.Drawing.Size(1080, 724);
            this.tlpRight.TabIndex = 0;
            // 
            // panelStatus
            // 
            this.panelStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.panelStatus.Controls.Add(this.tlpStatus);
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStatus.Location = new System.Drawing.Point(0, 0);
            this.panelStatus.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.panelStatus.Size = new System.Drawing.Size(1080, 44);
            this.panelStatus.TabIndex = 0;
            // 
            // tlpStatus
            // 
            this.tlpStatus.ColumnCount = 6;
            this.tlpStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.tlpStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tlpStatus.Controls.Add(this.lblCurrentModeTitle, 0, 0);
            this.tlpStatus.Controls.Add(this.lblCurrentMode, 1, 0);
            this.tlpStatus.Controls.Add(this.lblDatabasePathTitle, 2, 0);
            this.tlpStatus.Controls.Add(this.lblDatabasePath, 3, 0);
            this.tlpStatus.Controls.Add(this.lblSourceStatusTitle, 4, 0);
            this.tlpStatus.Controls.Add(this.lblSourceStatus, 5, 0);
            this.tlpStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpStatus.Location = new System.Drawing.Point(12, 8);
            this.tlpStatus.Name = "tlpStatus";
            this.tlpStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpStatus.Size = new System.Drawing.Size(1056, 28);
            this.tlpStatus.TabIndex = 0;
            // 
            // lblCurrentModeTitle
            // 
            this.lblCurrentModeTitle.AutoSize = true;
            this.lblCurrentModeTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCurrentModeTitle.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblCurrentModeTitle.Location = new System.Drawing.Point(0, 0);
            this.lblCurrentModeTitle.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.lblCurrentModeTitle.Name = "lblCurrentModeTitle";
            this.lblCurrentModeTitle.Size = new System.Drawing.Size(100, 28);
            this.lblCurrentModeTitle.TabIndex = 0;
            this.lblCurrentModeTitle.Text = "Run Mode:";
            this.lblCurrentModeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCurrentMode
            // 
            this.lblCurrentMode.AutoEllipsis = true;
            this.lblCurrentMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCurrentMode.Font = new System.Drawing.Font("微軟正黑體", 10.2F);
            this.lblCurrentMode.Location = new System.Drawing.Point(108, 0);
            this.lblCurrentMode.Margin = new System.Windows.Forms.Padding(0, 0, 14, 0);
            this.lblCurrentMode.Name = "lblCurrentMode";
            this.lblCurrentMode.Size = new System.Drawing.Size(104, 28);
            this.lblCurrentMode.TabIndex = 1;
            this.lblCurrentMode.Text = "Remote";
            this.lblCurrentMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDatabasePathTitle
            // 
            this.lblDatabasePathTitle.AutoSize = true;
            this.lblDatabasePathTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDatabasePathTitle.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblDatabasePathTitle.Location = new System.Drawing.Point(226, 0);
            this.lblDatabasePathTitle.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.lblDatabasePathTitle.Name = "lblDatabasePathTitle";
            this.lblDatabasePathTitle.Size = new System.Drawing.Size(81, 28);
            this.lblDatabasePathTitle.TabIndex = 2;
            this.lblDatabasePathTitle.Text = "DB Path:";
            this.lblDatabasePathTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDatabasePath
            // 
            this.lblDatabasePath.AutoEllipsis = true;
            this.lblDatabasePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDatabasePath.Font = new System.Drawing.Font("微軟正黑體", 10.2F);
            this.lblDatabasePath.Location = new System.Drawing.Point(315, 0);
            this.lblDatabasePath.Margin = new System.Windows.Forms.Padding(0, 0, 14, 0);
            this.lblDatabasePath.Name = "lblDatabasePath";
            this.lblDatabasePath.Size = new System.Drawing.Size(402, 28);
            this.lblDatabasePath.TabIndex = 3;
            this.lblDatabasePath.Text = "-";
            this.lblDatabasePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSourceStatusTitle
            // 
            this.lblSourceStatusTitle.AutoSize = true;
            this.lblSourceStatusTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSourceStatusTitle.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblSourceStatusTitle.Location = new System.Drawing.Point(731, 0);
            this.lblSourceStatusTitle.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.lblSourceStatusTitle.Name = "lblSourceStatusTitle";
            this.lblSourceStatusTitle.Size = new System.Drawing.Size(67, 28);
            this.lblSourceStatusTitle.TabIndex = 4;
            this.lblSourceStatusTitle.Text = "Status:";
            this.lblSourceStatusTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSourceStatus
            // 
            this.lblSourceStatus.AutoEllipsis = true;
            this.lblSourceStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSourceStatus.Font = new System.Drawing.Font("微軟正黑體", 10.2F);
            this.lblSourceStatus.Location = new System.Drawing.Point(809, 0);
            this.lblSourceStatus.Name = "lblSourceStatus";
            this.lblSourceStatus.Size = new System.Drawing.Size(244, 28);
            this.lblSourceStatus.TabIndex = 5;
            this.lblSourceStatus.Text = "Idle";
            this.lblSourceStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpKpi
            // 
            this.tlpKpi.ColumnCount = 3;
            this.tlpKpi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpKpi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpKpi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpKpi.Controls.Add(this.gbTotalAlarms, 0, 0);
            this.tlpKpi.Controls.Add(this.gbMaxAlarm, 1, 0);
            this.tlpKpi.Controls.Add(this.gbMaxMachine, 2, 0);
            this.tlpKpi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpKpi.Location = new System.Drawing.Point(0, 52);
            this.tlpKpi.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.tlpKpi.Name = "tlpKpi";
            this.tlpKpi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpKpi.Size = new System.Drawing.Size(1080, 108);
            this.tlpKpi.TabIndex = 1;
            // 
            // gbTotalAlarms
            // 
            this.gbTotalAlarms.Controls.Add(this.lblTotalAlarms);
            this.gbTotalAlarms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTotalAlarms.Font = new System.Drawing.Font("微軟正黑體", 10.8F);
            this.gbTotalAlarms.Location = new System.Drawing.Point(0, 0);
            this.gbTotalAlarms.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.gbTotalAlarms.Name = "gbTotalAlarms";
            this.gbTotalAlarms.Size = new System.Drawing.Size(352, 108);
            this.gbTotalAlarms.TabIndex = 0;
            this.gbTotalAlarms.TabStop = false;
            this.gbTotalAlarms.Text = "Current Alarm Count";
            // 
            // lblTotalAlarms
            // 
            this.lblTotalAlarms.AutoSize = true;
            this.lblTotalAlarms.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold);
            this.lblTotalAlarms.Location = new System.Drawing.Point(16, 37);
            this.lblTotalAlarms.Name = "lblTotalAlarms";
            this.lblTotalAlarms.Size = new System.Drawing.Size(74, 42);
            this.lblTotalAlarms.TabIndex = 0;
            this.lblTotalAlarms.Text = "----";
            // 
            // gbMaxAlarm
            // 
            this.gbMaxAlarm.Controls.Add(this.lblMaxAlarmCode);
            this.gbMaxAlarm.Controls.Add(this.lblMaxAlarmCodeTimes);
            this.gbMaxAlarm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMaxAlarm.Font = new System.Drawing.Font("微軟正黑體", 10.8F);
            this.gbMaxAlarm.Location = new System.Drawing.Point(360, 0);
            this.gbMaxAlarm.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.gbMaxAlarm.Name = "gbMaxAlarm";
            this.gbMaxAlarm.Size = new System.Drawing.Size(352, 108);
            this.gbMaxAlarm.TabIndex = 1;
            this.gbMaxAlarm.TabStop = false;
            this.gbMaxAlarm.Text = "Top Problem Right Now";
            // 
            // lblMaxAlarmCode
            // 
            this.lblMaxAlarmCode.AutoSize = true;
            this.lblMaxAlarmCode.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold);
            this.lblMaxAlarmCode.Location = new System.Drawing.Point(16, 26);
            this.lblMaxAlarmCode.Name = "lblMaxAlarmCode";
            this.lblMaxAlarmCode.Size = new System.Drawing.Size(74, 42);
            this.lblMaxAlarmCode.TabIndex = 0;
            this.lblMaxAlarmCode.Text = "----";
            // 
            // lblMaxAlarmCodeTimes
            // 
            this.lblMaxAlarmCodeTimes.AutoSize = true;
            this.lblMaxAlarmCodeTimes.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblMaxAlarmCodeTimes.Location = new System.Drawing.Point(18, 69);
            this.lblMaxAlarmCodeTimes.Name = "lblMaxAlarmCodeTimes";
            this.lblMaxAlarmCodeTimes.Size = new System.Drawing.Size(96, 22);
            this.lblMaxAlarmCodeTimes.TabIndex = 1;
            this.lblMaxAlarmCodeTimes.Text = "(Times ---)";
            // 
            // gbMaxMachine
            // 
            this.gbMaxMachine.Controls.Add(this.lblMaxMachine);
            this.gbMaxMachine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMaxMachine.Font = new System.Drawing.Font("微軟正黑體", 10.8F);
            this.gbMaxMachine.Location = new System.Drawing.Point(723, 3);
            this.gbMaxMachine.Name = "gbMaxMachine";
            this.gbMaxMachine.Size = new System.Drawing.Size(354, 102);
            this.gbMaxMachine.TabIndex = 2;
            this.gbMaxMachine.TabStop = false;
            this.gbMaxMachine.Text = "Most Affected Machine";
            // 
            // lblMaxMachine
            // 
            this.lblMaxMachine.AutoSize = true;
            this.lblMaxMachine.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold);
            this.lblMaxMachine.Location = new System.Drawing.Point(16, 37);
            this.lblMaxMachine.Name = "lblMaxMachine";
            this.lblMaxMachine.Size = new System.Drawing.Size(74, 42);
            this.lblMaxMachine.TabIndex = 0;
            this.lblMaxMachine.Text = "----";
            // 
            // splitRight
            // 
            this.splitRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitRight.Location = new System.Drawing.Point(3, 171);
            this.splitRight.Name = "splitRight";
            this.splitRight.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitRight.Panel1
            // 
            this.splitRight.Panel1.Controls.Add(this.tcCharts);
            this.splitRight.Panel1MinSize = 280;
            // 
            // splitRight.Panel2
            // 
            this.splitRight.Panel2.Controls.Add(this.splitData);
            this.splitRight.Panel2MinSize = 220;
            this.splitRight.Size = new System.Drawing.Size(1074, 550);
            this.splitRight.SplitterDistance = 298;
            this.splitRight.TabIndex = 2;
            // 
            // tcCharts
            // 
            this.tcCharts.Controls.Add(this.tpOverview);
            this.tcCharts.Controls.Add(this.tpPattern);
            this.tcCharts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcCharts.Font = new System.Drawing.Font("微軟正黑體", 10.2F);
            this.tcCharts.Location = new System.Drawing.Point(0, 0);
            this.tcCharts.Name = "tcCharts";
            this.tcCharts.SelectedIndex = 0;
            this.tcCharts.Size = new System.Drawing.Size(1074, 298);
            this.tcCharts.TabIndex = 0;
            // 
            // tpOverview
            // 
            this.tpOverview.Controls.Add(this.tlpCharts);
            this.tpOverview.Location = new System.Drawing.Point(4, 31);
            this.tpOverview.Name = "tpOverview";
            this.tpOverview.Padding = new System.Windows.Forms.Padding(8);
            this.tpOverview.Size = new System.Drawing.Size(1066, 263);
            this.tpOverview.TabIndex = 0;
            this.tpOverview.Text = "Overview";
            this.tpOverview.UseVisualStyleBackColor = true;
            // 
            // tlpCharts
            // 
            this.tlpCharts.ColumnCount = 2;
            this.tlpCharts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCharts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCharts.Controls.Add(this.fpCodeBar, 0, 0);
            this.tlpCharts.Controls.Add(this.fpPareto, 1, 0);
            this.tlpCharts.Controls.Add(this.fpMachineBar, 0, 1);
            this.tlpCharts.Controls.Add(this.fpDailyTrend, 1, 1);
            this.tlpCharts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCharts.Location = new System.Drawing.Point(8, 8);
            this.tlpCharts.Name = "tlpCharts";
            this.tlpCharts.RowCount = 2;
            this.tlpCharts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCharts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCharts.Size = new System.Drawing.Size(1050, 247);
            this.tlpCharts.TabIndex = 0;
            // 
            // fpCodeBar
            // 
            this.fpCodeBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpCodeBar.Location = new System.Drawing.Point(0, 0);
            this.fpCodeBar.Margin = new System.Windows.Forms.Padding(0, 0, 8, 8);
            this.fpCodeBar.Name = "fpCodeBar";
            this.fpCodeBar.Size = new System.Drawing.Size(517, 115);
            this.fpCodeBar.TabIndex = 0;
            // 
            // fpPareto
            // 
            this.fpPareto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpPareto.Location = new System.Drawing.Point(533, 0);
            this.fpPareto.Margin = new System.Windows.Forms.Padding(8, 0, 0, 8);
            this.fpPareto.Name = "fpPareto";
            this.fpPareto.Size = new System.Drawing.Size(517, 115);
            this.fpPareto.TabIndex = 1;
            // 
            // fpMachineBar
            // 
            this.fpMachineBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpMachineBar.Location = new System.Drawing.Point(0, 131);
            this.fpMachineBar.Margin = new System.Windows.Forms.Padding(0, 8, 8, 0);
            this.fpMachineBar.Name = "fpMachineBar";
            this.fpMachineBar.Size = new System.Drawing.Size(517, 116);
            this.fpMachineBar.TabIndex = 2;
            // 
            // fpDailyTrend
            // 
            this.fpDailyTrend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpDailyTrend.Location = new System.Drawing.Point(533, 131);
            this.fpDailyTrend.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.fpDailyTrend.Name = "fpDailyTrend";
            this.fpDailyTrend.Size = new System.Drawing.Size(517, 116);
            this.fpDailyTrend.TabIndex = 3;
            // 
            // tpPattern
            // 
            this.tpPattern.Controls.Add(this.fpHourHistogram);
            this.tpPattern.Location = new System.Drawing.Point(4, 31);
            this.tpPattern.Name = "tpPattern";
            this.tpPattern.Padding = new System.Windows.Forms.Padding(8);
            this.tpPattern.Size = new System.Drawing.Size(1072, 267);
            this.tpPattern.TabIndex = 1;
            this.tpPattern.Text = "Time Pattern";
            this.tpPattern.UseVisualStyleBackColor = true;
            // 
            // fpHourHistogram
            // 
            this.fpHourHistogram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpHourHistogram.Location = new System.Drawing.Point(8, 8);
            this.fpHourHistogram.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.fpHourHistogram.Name = "fpHourHistogram";
            this.fpHourHistogram.Size = new System.Drawing.Size(1056, 251);
            this.fpHourHistogram.TabIndex = 0;
            // 
            // splitData
            // 
            this.splitData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitData.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitData.Location = new System.Drawing.Point(0, 0);
            this.splitData.Name = "splitData";
            // 
            // splitData.Panel1
            // 
            this.splitData.Panel1.Controls.Add(this.gbWarnCode);
            this.splitData.Panel1MinSize = 318;
            // 
            // splitData.Panel2
            // 
            this.splitData.Panel2.Controls.Add(this.gbAlarmDetails);
            this.splitData.Panel2MinSize = 420;
            this.splitData.Size = new System.Drawing.Size(1074, 248);
            this.splitData.SplitterDistance = 350;
            this.splitData.TabIndex = 0;
            // 
            // gbWarnCode
            // 
            this.gbWarnCode.Controls.Add(this.tlpWarnCode);
            this.gbWarnCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbWarnCode.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Bold);
            this.gbWarnCode.Location = new System.Drawing.Point(0, 0);
            this.gbWarnCode.Name = "gbWarnCode";
            this.gbWarnCode.Padding = new System.Windows.Forms.Padding(10, 8, 10, 10);
            this.gbWarnCode.Size = new System.Drawing.Size(350, 248);
            this.gbWarnCode.TabIndex = 0;
            this.gbWarnCode.TabStop = false;
            this.gbWarnCode.Text = "Problem Code Dictionary";
            // 
            // tlpWarnCode
            // 
            this.tlpWarnCode.ColumnCount = 1;
            this.tlpWarnCode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpWarnCode.Controls.Add(this.panelWarnCodeSearch, 0, 0);
            this.tlpWarnCode.Controls.Add(this.dgvWareCode, 0, 1);
            this.tlpWarnCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpWarnCode.Location = new System.Drawing.Point(10, 32);
            this.tlpWarnCode.Name = "tlpWarnCode";
            this.tlpWarnCode.RowCount = 2;
            this.tlpWarnCode.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tlpWarnCode.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpWarnCode.Size = new System.Drawing.Size(330, 206);
            this.tlpWarnCode.TabIndex = 0;
            // 
            // panelWarnCodeSearch
            // 
            this.panelWarnCodeSearch.Controls.Add(this.lblWarnCodeSearch);
            this.panelWarnCodeSearch.Controls.Add(this.panelWarnCodeSearchInput);
            this.panelWarnCodeSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWarnCodeSearch.Location = new System.Drawing.Point(0, 0);
            this.panelWarnCodeSearch.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.panelWarnCodeSearch.Name = "panelWarnCodeSearch";
            this.panelWarnCodeSearch.Size = new System.Drawing.Size(330, 36);
            this.panelWarnCodeSearch.TabIndex = 0;
            // 
            // lblWarnCodeSearch
            // 
            this.lblWarnCodeSearch.AutoSize = true;
            this.lblWarnCodeSearch.Font = new System.Drawing.Font("微軟正黑體", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblWarnCodeSearch.Location = new System.Drawing.Point(0, 8);
            this.lblWarnCodeSearch.Name = "lblWarnCodeSearch";
            this.lblWarnCodeSearch.Size = new System.Drawing.Size(61, 21);
            this.lblWarnCodeSearch.TabIndex = 0;
            this.lblWarnCodeSearch.Text = "Search";
            // 
            // panelWarnCodeSearchInput
            // 
            this.panelWarnCodeSearchInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelWarnCodeSearchInput.BackColor = System.Drawing.Color.White;
            this.panelWarnCodeSearchInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWarnCodeSearchInput.Controls.Add(this.txtWarnCodeSearch);
            this.panelWarnCodeSearchInput.Controls.Add(this.pbWarnCodeSearchClear);
            this.panelWarnCodeSearchInput.Location = new System.Drawing.Point(72, 1);
            this.panelWarnCodeSearchInput.Name = "panelWarnCodeSearchInput";
            this.panelWarnCodeSearchInput.Padding = new System.Windows.Forms.Padding(8, 6, 4, 6);
            this.panelWarnCodeSearchInput.Size = new System.Drawing.Size(388, 32);
            this.panelWarnCodeSearchInput.TabIndex = 1;
            // 
            // txtWarnCodeSearch
            // 
            this.txtWarnCodeSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWarnCodeSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtWarnCodeSearch.Font = new System.Drawing.Font("微軟正黑體", 9.8F);
            this.txtWarnCodeSearch.Location = new System.Drawing.Point(8, 6);
            this.txtWarnCodeSearch.Name = "txtWarnCodeSearch";
            this.txtWarnCodeSearch.Size = new System.Drawing.Size(352, 22);
            this.txtWarnCodeSearch.TabIndex = 0;
            // 
            // pbWarnCodeSearchClear
            // 
            this.pbWarnCodeSearchClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbWarnCodeSearchClear.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbWarnCodeSearchClear.Image = global::Project_LBTToolBox.Properties.Resources.Cross_mark_icon_in_red;
            this.pbWarnCodeSearchClear.Location = new System.Drawing.Point(360, 6);
            this.pbWarnCodeSearchClear.Name = "pbWarnCodeSearchClear";
            this.pbWarnCodeSearchClear.Size = new System.Drawing.Size(22, 18);
            this.pbWarnCodeSearchClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbWarnCodeSearchClear.TabIndex = 1;
            this.pbWarnCodeSearchClear.TabStop = false;
            // 
            // dgvWareCode
            // 
            this.dgvWareCode.AllowUserToAddRows = false;
            this.dgvWareCode.AllowUserToDeleteRows = false;
            this.dgvWareCode.AllowUserToResizeRows = false;
            this.dgvWareCode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWareCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWareCode.Location = new System.Drawing.Point(3, 45);
            this.dgvWareCode.MultiSelect = false;
            this.dgvWareCode.Name = "dgvWareCode";
            this.dgvWareCode.ReadOnly = true;
            this.dgvWareCode.RowHeadersVisible = false;
            this.dgvWareCode.RowHeadersWidth = 51;
            this.dgvWareCode.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWareCode.Size = new System.Drawing.Size(324, 158);
            this.dgvWareCode.TabIndex = 1;
            // 
            // gbAlarmDetails
            // 
            this.gbAlarmDetails.Controls.Add(this.panelDetails);
            this.gbAlarmDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAlarmDetails.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Bold);
            this.gbAlarmDetails.Location = new System.Drawing.Point(0, 0);
            this.gbAlarmDetails.Name = "gbAlarmDetails";
            this.gbAlarmDetails.Padding = new System.Windows.Forms.Padding(10, 8, 10, 10);
            this.gbAlarmDetails.Size = new System.Drawing.Size(720, 248);
            this.gbAlarmDetails.TabIndex = 0;
            this.gbAlarmDetails.TabStop = false;
            this.gbAlarmDetails.Text = "Alarm Records";
            // 
            // panelDetails
            // 
            this.panelDetails.Controls.Add(this.dgvAlarmTable);
            this.panelDetails.Controls.Add(this.panelPaging);
            this.panelDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetails.Location = new System.Drawing.Point(10, 32);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(700, 206);
            this.panelDetails.TabIndex = 0;
            // 
            // dgvAlarmTable
            // 
            this.dgvAlarmTable.AllowUserToAddRows = false;
            this.dgvAlarmTable.AllowUserToDeleteRows = false;
            this.dgvAlarmTable.AllowUserToResizeRows = false;
            this.dgvAlarmTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlarmTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAlarmTable.Location = new System.Drawing.Point(0, 0);
            this.dgvAlarmTable.MultiSelect = false;
            this.dgvAlarmTable.Name = "dgvAlarmTable";
            this.dgvAlarmTable.ReadOnly = true;
            this.dgvAlarmTable.RowHeadersVisible = false;
            this.dgvAlarmTable.RowHeadersWidth = 51;
            this.dgvAlarmTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlarmTable.Size = new System.Drawing.Size(700, 162);
            this.dgvAlarmTable.TabIndex = 0;
            // 
            // panelPaging
            // 
            this.panelPaging.Controls.Add(this.tlpPaging);
            this.panelPaging.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPaging.Location = new System.Drawing.Point(0, 162);
            this.panelPaging.Name = "panelPaging";
            this.panelPaging.Size = new System.Drawing.Size(700, 44);
            this.panelPaging.TabIndex = 1;
            // 
            // tlpPaging
            // 
            this.tlpPaging.ColumnCount = 5;
            this.tlpPaging.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPaging.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPaging.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPaging.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPaging.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPaging.Controls.Add(this.btnPrevPage, 0, 0);
            this.tlpPaging.Controls.Add(this.btnNextPage, 1, 0);
            this.tlpPaging.Controls.Add(this.lblPagingStatus, 2, 0);
            this.tlpPaging.Controls.Add(this.txtJumpPage, 3, 0);
            this.tlpPaging.Controls.Add(this.btnJumpPage, 4, 0);
            this.tlpPaging.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPaging.Location = new System.Drawing.Point(0, 0);
            this.tlpPaging.Name = "tlpPaging";
            this.tlpPaging.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPaging.Size = new System.Drawing.Size(700, 44);
            this.tlpPaging.TabIndex = 0;
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnPrevPage.Font = new System.Drawing.Font("微軟正黑體", 9.5F);
            this.btnPrevPage.Location = new System.Drawing.Point(0, 7);
            this.btnPrevPage.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(78, 30);
            this.btnPrevPage.TabIndex = 0;
            this.btnPrevPage.Text = "Prev";
            this.btnPrevPage.UseVisualStyleBackColor = true;
            // 
            // btnNextPage
            // 
            this.btnNextPage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnNextPage.Font = new System.Drawing.Font("微軟正黑體", 9.5F);
            this.btnNextPage.Location = new System.Drawing.Point(86, 7);
            this.btnNextPage.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(78, 30);
            this.btnNextPage.TabIndex = 1;
            this.btnNextPage.Text = "Next";
            this.btnNextPage.UseVisualStyleBackColor = true;
            // 
            // lblPagingStatus
            // 
            this.lblPagingStatus.AutoEllipsis = true;
            this.lblPagingStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPagingStatus.Font = new System.Drawing.Font("微軟正黑體", 10.2F);
            this.lblPagingStatus.Location = new System.Drawing.Point(174, 0);
            this.lblPagingStatus.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblPagingStatus.Name = "lblPagingStatus";
            this.lblPagingStatus.Size = new System.Drawing.Size(374, 44);
            this.lblPagingStatus.TabIndex = 2;
            this.lblPagingStatus.Text = "Page 0 / 0";
            this.lblPagingStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtJumpPage
            // 
            this.txtJumpPage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtJumpPage.Font = new System.Drawing.Font("微軟正黑體", 10.2F);
            this.txtJumpPage.Location = new System.Drawing.Point(558, 7);
            this.txtJumpPage.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.txtJumpPage.Name = "txtJumpPage";
            this.txtJumpPage.Size = new System.Drawing.Size(64, 30);
            this.txtJumpPage.TabIndex = 3;
            // 
            // btnJumpPage
            // 
            this.btnJumpPage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnJumpPage.Font = new System.Drawing.Font("微軟正黑體", 9.5F);
            this.btnJumpPage.Location = new System.Drawing.Point(633, 7);
            this.btnJumpPage.Name = "btnJumpPage";
            this.btnJumpPage.Size = new System.Drawing.Size(64, 30);
            this.btnJumpPage.TabIndex = 4;
            this.btnJumpPage.Text = "Go";
            this.btnJumpPage.UseVisualStyleBackColor = true;
            // 
            // AlarmDashboardView3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpRoot);
            this.Font = new System.Drawing.Font("微軟正黑體", 13.8F);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MinimumSize = new System.Drawing.Size(1220, 760);
            this.Name = "AlarmDashboardView3";
            this.Size = new System.Drawing.Size(1400, 900);
            this.tlpRoot.ResumeLayout(false);
            this.gbSource.ResumeLayout(false);
            this.tlpSource.ResumeLayout(false);
            this.tlpSource.PerformLayout();
            this.flpSourceMode.ResumeLayout(false);
            this.flpSourceMode.PerformLayout();
            this.gbExportActions.ResumeLayout(false);
            this.flpExportButtons.ResumeLayout(false);
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.gbFilters.ResumeLayout(false);
            this.tlpFilters.ResumeLayout(false);
            this.panelDateFilter.ResumeLayout(false);
            this.panelDateFilter.PerformLayout();
            this.panelMachines.ResumeLayout(false);
            this.panelMachines.PerformLayout();
            this.panelMachineActions.ResumeLayout(false);
            this.panelCodeFilter.ResumeLayout(false);
            this.panelCodeFilter.PerformLayout();
            this.panelWarnCodeFilterInput.ResumeLayout(false);
            this.panelWarnCodeFilterInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarnCodeFilterClear)).EndInit();
            this.panelFilterHint.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.tlpRight.ResumeLayout(false);
            this.panelStatus.ResumeLayout(false);
            this.tlpStatus.ResumeLayout(false);
            this.tlpStatus.PerformLayout();
            this.tlpKpi.ResumeLayout(false);
            this.gbTotalAlarms.ResumeLayout(false);
            this.gbTotalAlarms.PerformLayout();
            this.gbMaxAlarm.ResumeLayout(false);
            this.gbMaxAlarm.PerformLayout();
            this.gbMaxMachine.ResumeLayout(false);
            this.gbMaxMachine.PerformLayout();
            this.splitRight.Panel1.ResumeLayout(false);
            this.splitRight.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitRight)).EndInit();
            this.splitRight.ResumeLayout(false);
            this.tcCharts.ResumeLayout(false);
            this.tpOverview.ResumeLayout(false);
            this.tlpCharts.ResumeLayout(false);
            this.tpPattern.ResumeLayout(false);
            this.splitData.Panel1.ResumeLayout(false);
            this.splitData.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitData)).EndInit();
            this.splitData.ResumeLayout(false);
            this.gbWarnCode.ResumeLayout(false);
            this.tlpWarnCode.ResumeLayout(false);
            this.panelWarnCodeSearch.ResumeLayout(false);
            this.panelWarnCodeSearch.PerformLayout();
            this.panelWarnCodeSearchInput.ResumeLayout(false);
            this.panelWarnCodeSearchInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarnCodeSearchClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWareCode)).EndInit();
            this.gbAlarmDetails.ResumeLayout(false);
            this.panelDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlarmTable)).EndInit();
            this.panelPaging.ResumeLayout(false);
            this.tlpPaging.ResumeLayout(false);
            this.tlpPaging.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TableLayoutPanel tlpRoot;
        private System.Windows.Forms.GroupBox gbSource;
        private System.Windows.Forms.TableLayoutPanel tlpSource;
        private System.Windows.Forms.Label lblSourceMode;
        private System.Windows.Forms.FlowLayoutPanel flpSourceMode;
        private System.Windows.Forms.RadioButton rdbRemote;
        private System.Windows.Forms.RadioButton rdbLocal;
        private System.Windows.Forms.Label lblRemotePath;
        private System.Windows.Forms.TextBox txtRemotePath;
        private System.Windows.Forms.Button btnBrowseRemote;
        private System.Windows.Forms.Button btnTestRemote;
        private System.Windows.Forms.Label lblLocalPath;
        private System.Windows.Forms.TextBox txtLocalPath;
        private System.Windows.Forms.Button btnBrowseLocal;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.GroupBox gbExportActions;
        private System.Windows.Forms.FlowLayoutPanel flpExportButtons;
        private System.Windows.Forms.Button btnExportWarnCodesCsv;
        private System.Windows.Forms.Button btnExportAlarmsCsv;
        private System.Windows.Forms.Button btnExportAllAlarmsCsv;
        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.GroupBox gbFilters;
        private System.Windows.Forms.TableLayoutPanel tlpFilters;
        private System.Windows.Forms.Panel panelDateFilter;
        private System.Windows.Forms.CheckBox ckbDateRangeEnable;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Panel panelMachines;
        private System.Windows.Forms.Label lblMachines;
        private System.Windows.Forms.CheckedListBox clbMachines;
        private System.Windows.Forms.FlowLayoutPanel panelMachineActions;
        private System.Windows.Forms.Button btnMachinesAll;
        private System.Windows.Forms.Button btnMachinesClear;
        private System.Windows.Forms.Panel panelCodeFilter;
        private System.Windows.Forms.Label lblWarnCodeFilter;
        private System.Windows.Forms.Panel panelWarnCodeFilterInput;
        private System.Windows.Forms.TextBox txtWarnCodeFilter;
        private System.Windows.Forms.PictureBox pbWarnCodeFilterClear;
        private System.Windows.Forms.Panel panelFilterHint;
        private System.Windows.Forms.Label lblFilterHint;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.TableLayoutPanel tlpRight;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.TableLayoutPanel tlpStatus;
        private System.Windows.Forms.Label lblCurrentModeTitle;
        private System.Windows.Forms.Label lblCurrentMode;
        private System.Windows.Forms.Label lblDatabasePathTitle;
        private System.Windows.Forms.Label lblDatabasePath;
        private System.Windows.Forms.Label lblSourceStatusTitle;
        private System.Windows.Forms.Label lblSourceStatus;
        private System.Windows.Forms.TableLayoutPanel tlpKpi;
        private System.Windows.Forms.GroupBox gbTotalAlarms;
        private System.Windows.Forms.Label lblTotalAlarms;
        private System.Windows.Forms.GroupBox gbMaxAlarm;
        private System.Windows.Forms.Label lblMaxAlarmCode;
        private System.Windows.Forms.Label lblMaxAlarmCodeTimes;
        private System.Windows.Forms.GroupBox gbMaxMachine;
        private System.Windows.Forms.Label lblMaxMachine;
        private System.Windows.Forms.SplitContainer splitRight;
        private System.Windows.Forms.TabControl tcCharts;
        private System.Windows.Forms.TabPage tpOverview;
        private System.Windows.Forms.TableLayoutPanel tlpCharts;
        private ScottPlot.FormsPlot fpCodeBar;
        private ScottPlot.FormsPlot fpPareto;
        private ScottPlot.FormsPlot fpMachineBar;
        private ScottPlot.FormsPlot fpDailyTrend;
        private System.Windows.Forms.TabPage tpPattern;
        private ScottPlot.FormsPlot fpHourHistogram;
        private System.Windows.Forms.SplitContainer splitData;
        private System.Windows.Forms.GroupBox gbWarnCode;
        private System.Windows.Forms.TableLayoutPanel tlpWarnCode;
        private System.Windows.Forms.Panel panelWarnCodeSearch;
        private System.Windows.Forms.Label lblWarnCodeSearch;
        private System.Windows.Forms.Panel panelWarnCodeSearchInput;
        private System.Windows.Forms.TextBox txtWarnCodeSearch;
        private System.Windows.Forms.PictureBox pbWarnCodeSearchClear;
        private System.Windows.Forms.DataGridView dgvWareCode;
        private System.Windows.Forms.GroupBox gbAlarmDetails;
        private System.Windows.Forms.Panel panelDetails;
        private System.Windows.Forms.DataGridView dgvAlarmTable;
        private System.Windows.Forms.Panel panelPaging;
        private System.Windows.Forms.TableLayoutPanel tlpPaging;
        private System.Windows.Forms.Button btnPrevPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Label lblPagingStatus;
        private System.Windows.Forms.TextBox txtJumpPage;
        private System.Windows.Forms.Button btnJumpPage;
    }
}
