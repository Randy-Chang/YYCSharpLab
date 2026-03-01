namespace Project_LBTToolBox.Views.Alarms
{
    partial class AlarmDashboardView3
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tlpRoot = new System.Windows.Forms.TableLayoutPanel();
            this.gbSource = new System.Windows.Forms.GroupBox();
            this.rdbRemote = new System.Windows.Forms.RadioButton();
            this.rdbLocal = new System.Windows.Forms.RadioButton();
            this.lblRemotePath = new System.Windows.Forms.Label();
            this.txtRemotePath = new System.Windows.Forms.TextBox();
            this.btnBrowseRemote = new System.Windows.Forms.Button();
            this.btnTestRemote = new System.Windows.Forms.Button();
            this.lblLocalPath = new System.Windows.Forms.Label();
            this.txtLocalPath = new System.Windows.Forms.TextBox();
            this.btnBrowseLocal = new System.Windows.Forms.Button();
            this.gbExportActions = new System.Windows.Forms.GroupBox();
            this.btnExportWarnCodesCsv = new System.Windows.Forms.Button();
            this.btnExportAlarmsCsv = new System.Windows.Forms.Button();
            this.btnExportAllAlarmsCsv = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
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
            this.btnMachinesAll = new System.Windows.Forms.Button();
            this.btnMachinesClear = new System.Windows.Forms.Button();
            this.panelCodeFilter = new System.Windows.Forms.Panel();
            this.lblWarnCodeFilter = new System.Windows.Forms.Label();
            this.pbWarnCodeFilterClear = new System.Windows.Forms.PictureBox();
            this.txtWarnCodeFilter = new System.Windows.Forms.TextBox();
            this.panelFilterHint = new System.Windows.Forms.Panel();
            this.lblFilterHint = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
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
            this.dgvWareCode = new System.Windows.Forms.DataGridView();
            this.panelWarnCodeSearch = new System.Windows.Forms.Panel();
            this.pbWarnCodeSearchClear = new System.Windows.Forms.PictureBox();
            this.txtWarnCodeSearch = new System.Windows.Forms.TextBox();
            this.lblWarnCodeSearch = new System.Windows.Forms.Label();
            this.gbAlarmDetails = new System.Windows.Forms.GroupBox();
            this.panelDetails = new System.Windows.Forms.Panel();
            this.dgvAlarmTable = new System.Windows.Forms.DataGridView();
            this.panelPaging = new System.Windows.Forms.Panel();
            this.btnPrevPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.lblPagingStatus = new System.Windows.Forms.Label();
            this.txtJumpPage = new System.Windows.Forms.TextBox();
            this.btnJumpPage = new System.Windows.Forms.Button();
            this.tlpKpi = new System.Windows.Forms.TableLayoutPanel();
            this.gbTotalAlarms = new System.Windows.Forms.GroupBox();
            this.lblTotalAlarms = new System.Windows.Forms.Label();
            this.gbMaxAlarm = new System.Windows.Forms.GroupBox();
            this.lblMaxAlarmCode = new System.Windows.Forms.Label();
            this.lblMaxAlarmCodeTimes = new System.Windows.Forms.Label();
            this.gbMaxMachine = new System.Windows.Forms.GroupBox();
            this.lblMaxMachine = new System.Windows.Forms.Label();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.lblCurrentModeTitle = new System.Windows.Forms.Label();
            this.lblCurrentMode = new System.Windows.Forms.Label();
            this.lblDatabasePathTitle = new System.Windows.Forms.Label();
            this.lblDatabasePath = new System.Windows.Forms.Label();
            this.lblSourceStatusTitle = new System.Windows.Forms.Label();
            this.lblSourceStatus = new System.Windows.Forms.Label();
            this.tlpRoot.SuspendLayout();
            this.gbSource.SuspendLayout();
            this.gbExportActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.gbFilters.SuspendLayout();
            this.tlpFilters.SuspendLayout();
            this.panelDateFilter.SuspendLayout();
            this.panelMachines.SuspendLayout();
            this.panelCodeFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarnCodeFilterClear)).BeginInit();
            this.panelFilterHint.SuspendLayout();
            this.panelRight.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvWareCode)).BeginInit();
            this.panelWarnCodeSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarnCodeSearchClear)).BeginInit();
            this.gbAlarmDetails.SuspendLayout();
            this.panelDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlarmTable)).BeginInit();
            this.panelPaging.SuspendLayout();
            this.tlpKpi.SuspendLayout();
            this.gbTotalAlarms.SuspendLayout();
            this.gbMaxAlarm.SuspendLayout();
            this.gbMaxMachine.SuspendLayout();
            this.panelStatus.SuspendLayout();
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
            this.tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRoot.Size = new System.Drawing.Size(1280, 820);
            this.tlpRoot.TabIndex = 0;
            // 
            // gbSource
            // 
            this.gbSource.Controls.Add(this.rdbRemote);
            this.gbSource.Controls.Add(this.rdbLocal);
            this.gbSource.Controls.Add(this.lblRemotePath);
            this.gbSource.Controls.Add(this.txtRemotePath);
            this.gbSource.Controls.Add(this.btnBrowseRemote);
            this.gbSource.Controls.Add(this.btnTestRemote);
            this.gbSource.Controls.Add(this.lblLocalPath);
            this.gbSource.Controls.Add(this.txtLocalPath);
            this.gbSource.Controls.Add(this.btnBrowseLocal);
            this.gbSource.Controls.Add(this.gbExportActions);
            this.gbSource.Controls.Add(this.btnApply);
            this.gbSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSource.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold);
            this.gbSource.Location = new System.Drawing.Point(3, 3);
            this.gbSource.Name = "gbSource";
            this.gbSource.Size = new System.Drawing.Size(1274, 110);
            this.gbSource.TabIndex = 0;
            this.gbSource.TabStop = false;
            this.gbSource.Text = "Analysis Source";
            // 
            // rdbRemote
            // 
            this.rdbRemote.AutoSize = true;
            this.rdbRemote.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.rdbRemote.Location = new System.Drawing.Point(16, 33);
            this.rdbRemote.Name = "rdbRemote";
            this.rdbRemote.Size = new System.Drawing.Size(107, 29);
            this.rdbRemote.TabIndex = 0;
            this.rdbRemote.TabStop = true;
            this.rdbRemote.Text = "Remote";
            this.rdbRemote.UseVisualStyleBackColor = true;
            // 
            // rdbLocal
            // 
            this.rdbLocal.AutoSize = true;
            this.rdbLocal.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.rdbLocal.Location = new System.Drawing.Point(124, 33);
            this.rdbLocal.Name = "rdbLocal";
            this.rdbLocal.Size = new System.Drawing.Size(82, 29);
            this.rdbLocal.TabIndex = 1;
            this.rdbLocal.TabStop = true;
            this.rdbLocal.Text = "Local";
            this.rdbLocal.UseVisualStyleBackColor = true;
            // 
            // lblRemotePath
            // 
            this.lblRemotePath.AutoSize = true;
            this.lblRemotePath.Font = new System.Drawing.Font("微軟正黑體", 10.2F);
            this.lblRemotePath.Location = new System.Drawing.Point(16, 78);
            this.lblRemotePath.Name = "lblRemotePath";
            this.lblRemotePath.Size = new System.Drawing.Size(114, 22);
            this.lblRemotePath.TabIndex = 2;
            this.lblRemotePath.Text = "Remote NAS";
            // 
            // txtRemotePath
            // 
            this.txtRemotePath.Font = new System.Drawing.Font("微軟正黑體", 10.2F);
            this.txtRemotePath.Location = new System.Drawing.Point(97, 75);
            this.txtRemotePath.Name = "txtRemotePath";
            this.txtRemotePath.Size = new System.Drawing.Size(620, 30);
            this.txtRemotePath.TabIndex = 3;
            // 
            // btnBrowseRemote
            // 
            this.btnBrowseRemote.Font = new System.Drawing.Font("微軟正黑體", 10.2F);
            this.btnBrowseRemote.Location = new System.Drawing.Point(723, 74);
            this.btnBrowseRemote.Name = "btnBrowseRemote";
            this.btnBrowseRemote.Size = new System.Drawing.Size(88, 31);
            this.btnBrowseRemote.TabIndex = 4;
            this.btnBrowseRemote.Text = "Browse";
            this.btnBrowseRemote.UseVisualStyleBackColor = true;
            // 
            // btnTestRemote
            // 
            this.btnTestRemote.Font = new System.Drawing.Font("微軟正黑體", 10.2F);
            this.btnTestRemote.Location = new System.Drawing.Point(817, 74);
            this.btnTestRemote.Name = "btnTestRemote";
            this.btnTestRemote.Size = new System.Drawing.Size(88, 31);
            this.btnTestRemote.TabIndex = 5;
            this.btnTestRemote.Text = "Check";
            this.btnTestRemote.UseVisualStyleBackColor = true;
            // 
            // lblLocalPath
            // 
            this.lblLocalPath.AutoSize = true;
            this.lblLocalPath.Font = new System.Drawing.Font("微軟正黑體", 10.2F);
            this.lblLocalPath.Location = new System.Drawing.Point(213, 36);
            this.lblLocalPath.Name = "lblLocalPath";
            this.lblLocalPath.Size = new System.Drawing.Size(106, 22);
            this.lblLocalPath.TabIndex = 6;
            this.lblLocalPath.Text = "Local Folder";
            // 
            // txtLocalPath
            // 
            this.txtLocalPath.Font = new System.Drawing.Font("微軟正黑體", 10.2F);
            this.txtLocalPath.Location = new System.Drawing.Point(299, 33);
            this.txtLocalPath.Name = "txtLocalPath";
            this.txtLocalPath.Size = new System.Drawing.Size(418, 30);
            this.txtLocalPath.TabIndex = 7;
            // 
            // btnBrowseLocal
            // 
            this.btnBrowseLocal.Font = new System.Drawing.Font("微軟正黑體", 10.2F);
            this.btnBrowseLocal.Location = new System.Drawing.Point(723, 32);
            this.btnBrowseLocal.Name = "btnBrowseLocal";
            this.btnBrowseLocal.Size = new System.Drawing.Size(88, 31);
            this.btnBrowseLocal.TabIndex = 8;
            this.btnBrowseLocal.Text = "Browse";
            this.btnBrowseLocal.UseVisualStyleBackColor = true;
            // 
            // gbExportActions
            // 
            this.gbExportActions.Controls.Add(this.btnExportWarnCodesCsv);
            this.gbExportActions.Controls.Add(this.btnExportAlarmsCsv);
            this.gbExportActions.Controls.Add(this.btnExportAllAlarmsCsv);
            this.gbExportActions.Font = new System.Drawing.Font("微軟正黑體", 9.8F, System.Drawing.FontStyle.Bold);
            this.gbExportActions.Location = new System.Drawing.Point(1093, 21);
            this.gbExportActions.Name = "gbExportActions";
            this.gbExportActions.Size = new System.Drawing.Size(166, 84);
            this.gbExportActions.TabIndex = 10;
            this.gbExportActions.TabStop = false;
            this.gbExportActions.Text = "Export";
            // 
            // btnExportWarnCodesCsv
            // 
            this.btnExportWarnCodesCsv.Font = new System.Drawing.Font("微軟正黑體", 9.2F);
            this.btnExportWarnCodesCsv.Location = new System.Drawing.Point(3, 54);
            this.btnExportWarnCodesCsv.Margin = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.btnExportWarnCodesCsv.Name = "btnExportWarnCodesCsv";
            this.btnExportWarnCodesCsv.Size = new System.Drawing.Size(74, 28);
            this.btnExportWarnCodesCsv.TabIndex = 0;
            this.btnExportWarnCodesCsv.Text = "Codes";
            this.btnExportWarnCodesCsv.UseVisualStyleBackColor = true;
            // 
            // btnExportAlarmsCsv
            // 
            this.btnExportAlarmsCsv.Font = new System.Drawing.Font("微軟正黑體", 9.2F);
            this.btnExportAlarmsCsv.Location = new System.Drawing.Point(80, 25);
            this.btnExportAlarmsCsv.Margin = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.btnExportAlarmsCsv.Name = "btnExportAlarmsCsv";
            this.btnExportAlarmsCsv.Size = new System.Drawing.Size(74, 28);
            this.btnExportAlarmsCsv.TabIndex = 1;
            this.btnExportAlarmsCsv.Text = "Page";
            this.btnExportAlarmsCsv.UseVisualStyleBackColor = true;
            // 
            // btnExportAllAlarmsCsv
            // 
            this.btnExportAllAlarmsCsv.Font = new System.Drawing.Font("微軟正黑體", 9.2F);
            this.btnExportAllAlarmsCsv.Location = new System.Drawing.Point(3, 25);
            this.btnExportAllAlarmsCsv.Margin = new System.Windows.Forms.Padding(0);
            this.btnExportAllAlarmsCsv.Name = "btnExportAllAlarmsCsv";
            this.btnExportAllAlarmsCsv.Size = new System.Drawing.Size(74, 28);
            this.btnExportAllAlarmsCsv.TabIndex = 2;
            this.btnExportAllAlarmsCsv.Text = "All";
            this.btnExportAllAlarmsCsv.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            this.btnApply.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.btnApply.Location = new System.Drawing.Point(911, 33);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(94, 72);
            this.btnApply.TabIndex = 9;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitMain.Location = new System.Drawing.Point(3, 119);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.gbFilters);
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.panelRight);
            this.splitMain.Size = new System.Drawing.Size(1274, 698);
            this.splitMain.SplitterDistance = 292;
            this.splitMain.TabIndex = 1;
            // 
            // gbFilters
            // 
            this.gbFilters.Controls.Add(this.tlpFilters);
            this.gbFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFilters.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold);
            this.gbFilters.Location = new System.Drawing.Point(0, 0);
            this.gbFilters.Name = "gbFilters";
            this.gbFilters.Size = new System.Drawing.Size(292, 698);
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
            this.tlpFilters.Location = new System.Drawing.Point(3, 34);
            this.tlpFilters.Name = "tlpFilters";
            this.tlpFilters.RowCount = 4;
            this.tlpFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tlpFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFilters.Size = new System.Drawing.Size(286, 661);
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
            this.panelDateFilter.Location = new System.Drawing.Point(3, 3);
            this.panelDateFilter.Name = "panelDateFilter";
            this.panelDateFilter.Size = new System.Drawing.Size(280, 144);
            this.panelDateFilter.TabIndex = 0;
            // 
            // ckbDateRangeEnable
            // 
            this.ckbDateRangeEnable.AutoSize = true;
            this.ckbDateRangeEnable.Font = new System.Drawing.Font("微軟正黑體", 10.8F);
            this.ckbDateRangeEnable.Location = new System.Drawing.Point(8, 8);
            this.ckbDateRangeEnable.Name = "ckbDateRangeEnable";
            this.ckbDateRangeEnable.Size = new System.Drawing.Size(132, 27);
            this.ckbDateRangeEnable.TabIndex = 0;
            this.ckbDateRangeEnable.Text = "Date Range";
            this.ckbDateRangeEnable.UseVisualStyleBackColor = true;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("微軟正黑體", 13.8F);
            this.lblStartDate.Location = new System.Drawing.Point(8, 52);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(75, 29);
            this.lblStartDate.TabIndex = 1;
            this.lblStartDate.Text = "From:";
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "yyyy-MM-dd";
            this.dtpFrom.Font = new System.Drawing.Font("微軟正黑體", 13.8F);
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(90, 46);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(196, 38);
            this.dtpFrom.TabIndex = 2;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("微軟正黑體", 13.8F);
            this.lblEndDate.Location = new System.Drawing.Point(35, 95);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(46, 29);
            this.lblEndDate.TabIndex = 3;
            this.lblEndDate.Text = "To:";
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "yyyy-MM-dd";
            this.dtpTo.Font = new System.Drawing.Font("微軟正黑體", 13.8F);
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(90, 89);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(196, 38);
            this.dtpTo.TabIndex = 4;
            // 
            // panelMachines
            // 
            this.panelMachines.Controls.Add(this.lblMachines);
            this.panelMachines.Controls.Add(this.clbMachines);
            this.panelMachines.Controls.Add(this.btnMachinesAll);
            this.panelMachines.Controls.Add(this.btnMachinesClear);
            this.panelMachines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMachines.Location = new System.Drawing.Point(3, 153);
            this.panelMachines.Name = "panelMachines";
            this.panelMachines.Size = new System.Drawing.Size(280, 294);
            this.panelMachines.TabIndex = 1;
            // 
            // lblMachines
            // 
            this.lblMachines.AutoSize = true;
            this.lblMachines.Font = new System.Drawing.Font("微軟正黑體", 10.8F);
            this.lblMachines.Location = new System.Drawing.Point(8, 8);
            this.lblMachines.Name = "lblMachines";
            this.lblMachines.Size = new System.Drawing.Size(139, 23);
            this.lblMachines.TabIndex = 0;
            this.lblMachines.Text = "Machines Filter";
            // 
            // clbMachines
            // 
            this.clbMachines.Font = new System.Drawing.Font("微軟正黑體", 13.8F);
            this.clbMachines.FormattingEnabled = true;
            this.clbMachines.Location = new System.Drawing.Point(8, 41);
            this.clbMachines.Name = "clbMachines";
            this.clbMachines.Size = new System.Drawing.Size(292, 169);
            this.clbMachines.TabIndex = 1;
            // 
            // btnMachinesAll
            // 
            this.btnMachinesAll.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnMachinesAll.Location = new System.Drawing.Point(8, 234);
            this.btnMachinesAll.Name = "btnMachinesAll";
            this.btnMachinesAll.Size = new System.Drawing.Size(140, 36);
            this.btnMachinesAll.TabIndex = 2;
            this.btnMachinesAll.Text = "Select All";
            this.btnMachinesAll.UseVisualStyleBackColor = true;
            // 
            // btnMachinesClear
            // 
            this.btnMachinesClear.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.btnMachinesClear.Location = new System.Drawing.Point(160, 234);
            this.btnMachinesClear.Name = "btnMachinesClear";
            this.btnMachinesClear.Size = new System.Drawing.Size(140, 36);
            this.btnMachinesClear.TabIndex = 3;
            this.btnMachinesClear.Text = "Clear";
            this.btnMachinesClear.UseVisualStyleBackColor = true;
            // 
            // panelCodeFilter
            // 
            this.panelCodeFilter.Controls.Add(this.lblWarnCodeFilter);
            this.panelCodeFilter.Controls.Add(this.pbWarnCodeFilterClear);
            this.panelCodeFilter.Controls.Add(this.txtWarnCodeFilter);
            this.panelCodeFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCodeFilter.Location = new System.Drawing.Point(3, 453);
            this.panelCodeFilter.Name = "panelCodeFilter";
            this.panelCodeFilter.Size = new System.Drawing.Size(280, 58);
            this.panelCodeFilter.TabIndex = 2;
            // 
            // lblWarnCodeFilter
            // 
            this.lblWarnCodeFilter.AutoSize = true;
            this.lblWarnCodeFilter.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.lblWarnCodeFilter.Location = new System.Drawing.Point(8, 11);
            this.lblWarnCodeFilter.Name = "lblWarnCodeFilter";
            this.lblWarnCodeFilter.Size = new System.Drawing.Size(112, 25);
            this.lblWarnCodeFilter.TabIndex = 0;
            this.lblWarnCodeFilter.Text = "WarnCode";
            // 
            // pbWarnCodeFilterClear
            // 
            this.pbWarnCodeFilterClear.BackColor = System.Drawing.Color.White;
            this.pbWarnCodeFilterClear.Image = global::Project_LBTToolBox.Properties.Resources.Cross_mark_icon_in_red;
            this.pbWarnCodeFilterClear.Location = new System.Drawing.Point(241, 14);
            this.pbWarnCodeFilterClear.Name = "pbWarnCodeFilterClear";
            this.pbWarnCodeFilterClear.Size = new System.Drawing.Size(20, 20);
            this.pbWarnCodeFilterClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbWarnCodeFilterClear.TabIndex = 2;
            this.pbWarnCodeFilterClear.TabStop = false;
            // 
            // txtWarnCodeFilter
            // 
            this.txtWarnCodeFilter.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.txtWarnCodeFilter.Location = new System.Drawing.Point(118, 8);
            this.txtWarnCodeFilter.Name = "txtWarnCodeFilter";
            this.txtWarnCodeFilter.Size = new System.Drawing.Size(148, 34);
            this.txtWarnCodeFilter.TabIndex = 1;
            // 
            // panelFilterHint
            // 
            this.panelFilterHint.Controls.Add(this.lblFilterHint);
            this.panelFilterHint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFilterHint.Location = new System.Drawing.Point(3, 517);
            this.panelFilterHint.Name = "panelFilterHint";
            this.panelFilterHint.Size = new System.Drawing.Size(280, 141);
            this.panelFilterHint.TabIndex = 3;
            // 
            // lblFilterHint
            // 
            this.lblFilterHint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFilterHint.Font = new System.Drawing.Font("微軟正黑體", 11F);
            this.lblFilterHint.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFilterHint.Location = new System.Drawing.Point(0, 0);
            this.lblFilterHint.Name = "lblFilterHint";
            this.lblFilterHint.Padding = new System.Windows.Forms.Padding(8);
            this.lblFilterHint.Size = new System.Drawing.Size(280, 141);
            this.lblFilterHint.TabIndex = 0;
            this.lblFilterHint.Text = "Start from the overview on the right: Top Problem, Pareto, and Daily Trend. Doubl" +
    "e-click a code bar or a code row to lock one issue, then verify whether it is co" +
    "ncentrated on a machine or time period.";
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.splitRight);
            this.panelRight.Controls.Add(this.tlpKpi);
            this.panelRight.Controls.Add(this.panelStatus);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(0, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(978, 698);
            this.panelRight.TabIndex = 0;
            // 
            // splitRight
            // 
            this.splitRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitRight.Location = new System.Drawing.Point(0, 154);
            this.splitRight.Name = "splitRight";
            this.splitRight.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitRight.Panel1
            // 
            this.splitRight.Panel1.Controls.Add(this.tcCharts);
            // 
            // splitRight.Panel2
            // 
            this.splitRight.Panel2.Controls.Add(this.splitData);
            this.splitRight.Size = new System.Drawing.Size(978, 544);
            this.splitRight.SplitterDistance = 317;
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
            this.tcCharts.Size = new System.Drawing.Size(978, 317);
            this.tcCharts.TabIndex = 0;
            // 
            // tpOverview
            // 
            this.tpOverview.Controls.Add(this.tlpCharts);
            this.tpOverview.Location = new System.Drawing.Point(4, 31);
            this.tpOverview.Name = "tpOverview";
            this.tpOverview.Padding = new System.Windows.Forms.Padding(3);
            this.tpOverview.Size = new System.Drawing.Size(970, 282);
            this.tpOverview.TabIndex = 0;
            this.tpOverview.Text = "Problem Overview";
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
            this.tlpCharts.Location = new System.Drawing.Point(3, 3);
            this.tlpCharts.Name = "tlpCharts";
            this.tlpCharts.RowCount = 2;
            this.tlpCharts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCharts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCharts.Size = new System.Drawing.Size(964, 276);
            this.tlpCharts.TabIndex = 0;
            // 
            // fpCodeBar
            // 
            this.fpCodeBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpCodeBar.Location = new System.Drawing.Point(8, 8);
            this.fpCodeBar.Margin = new System.Windows.Forms.Padding(8);
            this.fpCodeBar.Name = "fpCodeBar";
            this.fpCodeBar.Size = new System.Drawing.Size(466, 122);
            this.fpCodeBar.TabIndex = 0;
            // 
            // fpPareto
            // 
            this.fpPareto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpPareto.Location = new System.Drawing.Point(490, 8);
            this.fpPareto.Margin = new System.Windows.Forms.Padding(8);
            this.fpPareto.Name = "fpPareto";
            this.fpPareto.Size = new System.Drawing.Size(466, 122);
            this.fpPareto.TabIndex = 1;
            // 
            // fpMachineBar
            // 
            this.fpMachineBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpMachineBar.Location = new System.Drawing.Point(8, 146);
            this.fpMachineBar.Margin = new System.Windows.Forms.Padding(8);
            this.fpMachineBar.Name = "fpMachineBar";
            this.fpMachineBar.Size = new System.Drawing.Size(466, 122);
            this.fpMachineBar.TabIndex = 2;
            // 
            // fpDailyTrend
            // 
            this.fpDailyTrend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpDailyTrend.Location = new System.Drawing.Point(490, 146);
            this.fpDailyTrend.Margin = new System.Windows.Forms.Padding(8);
            this.fpDailyTrend.Name = "fpDailyTrend";
            this.fpDailyTrend.Size = new System.Drawing.Size(466, 122);
            this.fpDailyTrend.TabIndex = 3;
            // 
            // tpPattern
            // 
            this.tpPattern.Controls.Add(this.fpHourHistogram);
            this.tpPattern.Location = new System.Drawing.Point(4, 31);
            this.tpPattern.Name = "tpPattern";
            this.tpPattern.Padding = new System.Windows.Forms.Padding(3);
            this.tpPattern.Size = new System.Drawing.Size(970, 282);
            this.tpPattern.TabIndex = 1;
            this.tpPattern.Text = "Time Pattern";
            this.tpPattern.UseVisualStyleBackColor = true;
            // 
            // fpHourHistogram
            // 
            this.fpHourHistogram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpHourHistogram.Location = new System.Drawing.Point(3, 3);
            this.fpHourHistogram.Margin = new System.Windows.Forms.Padding(8);
            this.fpHourHistogram.Name = "fpHourHistogram";
            this.fpHourHistogram.Size = new System.Drawing.Size(964, 276);
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
            // 
            // splitData.Panel2
            // 
            this.splitData.Panel2.Controls.Add(this.gbAlarmDetails);
            this.splitData.Size = new System.Drawing.Size(978, 223);
            this.splitData.SplitterDistance = 360;
            this.splitData.TabIndex = 0;
            // 
            // gbWarnCode
            // 
            this.gbWarnCode.Controls.Add(this.dgvWareCode);
            this.gbWarnCode.Controls.Add(this.panelWarnCodeSearch);
            this.gbWarnCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbWarnCode.Font = new System.Drawing.Font("微軟正黑體", 10.8F);
            this.gbWarnCode.Location = new System.Drawing.Point(0, 0);
            this.gbWarnCode.Name = "gbWarnCode";
            this.gbWarnCode.Size = new System.Drawing.Size(360, 223);
            this.gbWarnCode.TabIndex = 0;
            this.gbWarnCode.TabStop = false;
            this.gbWarnCode.Text = "Problem Code Dictionary";
            // 
            // dgvWareCode
            // 
            this.dgvWareCode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWareCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWareCode.Location = new System.Drawing.Point(3, 67);
            this.dgvWareCode.Name = "dgvWareCode";
            this.dgvWareCode.RowHeadersWidth = 51;
            this.dgvWareCode.RowTemplate.Height = 27;
            this.dgvWareCode.Size = new System.Drawing.Size(354, 153);
            this.dgvWareCode.TabIndex = 0;
            // 
            // panelWarnCodeSearch
            // 
            this.panelWarnCodeSearch.Controls.Add(this.pbWarnCodeSearchClear);
            this.panelWarnCodeSearch.Controls.Add(this.txtWarnCodeSearch);
            this.panelWarnCodeSearch.Controls.Add(this.lblWarnCodeSearch);
            this.panelWarnCodeSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWarnCodeSearch.Location = new System.Drawing.Point(3, 27);
            this.panelWarnCodeSearch.Name = "panelWarnCodeSearch";
            this.panelWarnCodeSearch.Padding = new System.Windows.Forms.Padding(8, 6, 8, 4);
            this.panelWarnCodeSearch.Size = new System.Drawing.Size(354, 40);
            this.panelWarnCodeSearch.TabIndex = 1;
            // 
            // pbWarnCodeSearchClear
            // 
            this.pbWarnCodeSearchClear.BackColor = System.Drawing.Color.White;
            this.pbWarnCodeSearchClear.Image = global::Project_LBTToolBox.Properties.Resources.Cross_mark_icon_in_red;
            this.pbWarnCodeSearchClear.Location = new System.Drawing.Point(320, 10);
            this.pbWarnCodeSearchClear.Name = "pbWarnCodeSearchClear";
            this.pbWarnCodeSearchClear.Size = new System.Drawing.Size(20, 20);
            this.pbWarnCodeSearchClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbWarnCodeSearchClear.TabIndex = 2;
            this.pbWarnCodeSearchClear.TabStop = false;
            // 
            // txtWarnCodeSearch
            // 
            this.txtWarnCodeSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWarnCodeSearch.Font = new System.Drawing.Font("微軟正黑體", 9.8F);
            this.txtWarnCodeSearch.Location = new System.Drawing.Point(77, 7);
            this.txtWarnCodeSearch.Name = "txtWarnCodeSearch";
            this.txtWarnCodeSearch.Size = new System.Drawing.Size(266, 29);
            this.txtWarnCodeSearch.TabIndex = 1;
            // 
            // lblWarnCodeSearch
            // 
            this.lblWarnCodeSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblWarnCodeSearch.Font = new System.Drawing.Font("微軟正黑體", 9.8F, System.Drawing.FontStyle.Bold);
            this.lblWarnCodeSearch.Location = new System.Drawing.Point(8, 6);
            this.lblWarnCodeSearch.Name = "lblWarnCodeSearch";
            this.lblWarnCodeSearch.Size = new System.Drawing.Size(78, 30);
            this.lblWarnCodeSearch.TabIndex = 0;
            this.lblWarnCodeSearch.Text = "Search";
            this.lblWarnCodeSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbAlarmDetails
            // 
            this.gbAlarmDetails.Controls.Add(this.panelDetails);
            this.gbAlarmDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAlarmDetails.Font = new System.Drawing.Font("微軟正黑體", 10.8F);
            this.gbAlarmDetails.Location = new System.Drawing.Point(0, 0);
            this.gbAlarmDetails.Name = "gbAlarmDetails";
            this.gbAlarmDetails.Size = new System.Drawing.Size(614, 223);
            this.gbAlarmDetails.TabIndex = 0;
            this.gbAlarmDetails.TabStop = false;
            this.gbAlarmDetails.Text = "Alarm Records";
            // 
            // panelDetails
            // 
            this.panelDetails.Controls.Add(this.dgvAlarmTable);
            this.panelDetails.Controls.Add(this.panelPaging);
            this.panelDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetails.Location = new System.Drawing.Point(3, 27);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(608, 193);
            this.panelDetails.TabIndex = 0;
            // 
            // dgvAlarmTable
            // 
            this.dgvAlarmTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlarmTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAlarmTable.Location = new System.Drawing.Point(0, 42);
            this.dgvAlarmTable.Name = "dgvAlarmTable";
            this.dgvAlarmTable.RowHeadersWidth = 51;
            this.dgvAlarmTable.RowTemplate.Height = 27;
            this.dgvAlarmTable.Size = new System.Drawing.Size(608, 151);
            this.dgvAlarmTable.TabIndex = 1;
            // 
            // panelPaging
            // 
            this.panelPaging.Controls.Add(this.btnPrevPage);
            this.panelPaging.Controls.Add(this.btnNextPage);
            this.panelPaging.Controls.Add(this.lblPagingStatus);
            this.panelPaging.Controls.Add(this.txtJumpPage);
            this.panelPaging.Controls.Add(this.btnJumpPage);
            this.panelPaging.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPaging.Location = new System.Drawing.Point(0, 0);
            this.panelPaging.Name = "panelPaging";
            this.panelPaging.Size = new System.Drawing.Size(608, 42);
            this.panelPaging.TabIndex = 0;
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.Font = new System.Drawing.Font("微軟正黑體", 9.5F);
            this.btnPrevPage.Location = new System.Drawing.Point(8, 6);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(78, 30);
            this.btnPrevPage.TabIndex = 0;
            this.btnPrevPage.Text = "Prev";
            this.btnPrevPage.UseVisualStyleBackColor = true;
            // 
            // btnNextPage
            // 
            this.btnNextPage.Font = new System.Drawing.Font("微軟正黑體", 9.5F);
            this.btnNextPage.Location = new System.Drawing.Point(92, 6);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(78, 30);
            this.btnNextPage.TabIndex = 1;
            this.btnNextPage.Text = "Next";
            this.btnNextPage.UseVisualStyleBackColor = true;
            // 
            // lblPagingStatus
            // 
            this.lblPagingStatus.Font = new System.Drawing.Font("微軟正黑體", 10.2F);
            this.lblPagingStatus.Location = new System.Drawing.Point(180, 10);
            this.lblPagingStatus.Name = "lblPagingStatus";
            this.lblPagingStatus.Size = new System.Drawing.Size(220, 22);
            this.lblPagingStatus.TabIndex = 2;
            this.lblPagingStatus.Text = "Page 0 / 0";
            // 
            // txtJumpPage
            // 
            this.txtJumpPage.Font = new System.Drawing.Font("微軟正黑體", 10.2F);
            this.txtJumpPage.Location = new System.Drawing.Point(410, 7);
            this.txtJumpPage.Name = "txtJumpPage";
            this.txtJumpPage.Size = new System.Drawing.Size(64, 30);
            this.txtJumpPage.TabIndex = 3;
            // 
            // btnJumpPage
            // 
            this.btnJumpPage.Font = new System.Drawing.Font("微軟正黑體", 9.5F);
            this.btnJumpPage.Location = new System.Drawing.Point(480, 6);
            this.btnJumpPage.Name = "btnJumpPage";
            this.btnJumpPage.Size = new System.Drawing.Size(64, 30);
            this.btnJumpPage.TabIndex = 4;
            this.btnJumpPage.Text = "Go";
            this.btnJumpPage.UseVisualStyleBackColor = true;
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
            this.tlpKpi.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpKpi.Location = new System.Drawing.Point(0, 46);
            this.tlpKpi.Name = "tlpKpi";
            this.tlpKpi.RowCount = 1;
            this.tlpKpi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpKpi.Size = new System.Drawing.Size(978, 108);
            this.tlpKpi.TabIndex = 1;
            // 
            // gbTotalAlarms
            // 
            this.gbTotalAlarms.Controls.Add(this.lblTotalAlarms);
            this.gbTotalAlarms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTotalAlarms.Font = new System.Drawing.Font("微軟正黑體", 10.8F);
            this.gbTotalAlarms.Location = new System.Drawing.Point(3, 3);
            this.gbTotalAlarms.Name = "gbTotalAlarms";
            this.gbTotalAlarms.Size = new System.Drawing.Size(320, 102);
            this.gbTotalAlarms.TabIndex = 0;
            this.gbTotalAlarms.TabStop = false;
            this.gbTotalAlarms.Text = "Current Alarm Count";
            // 
            // lblTotalAlarms
            // 
            this.lblTotalAlarms.AutoSize = true;
            this.lblTotalAlarms.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold);
            this.lblTotalAlarms.Location = new System.Drawing.Point(12, 31);
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
            this.gbMaxAlarm.Location = new System.Drawing.Point(329, 3);
            this.gbMaxAlarm.Name = "gbMaxAlarm";
            this.gbMaxAlarm.Size = new System.Drawing.Size(320, 102);
            this.gbMaxAlarm.TabIndex = 1;
            this.gbMaxAlarm.TabStop = false;
            this.gbMaxAlarm.Text = "Top Problem Right Now";
            // 
            // lblMaxAlarmCode
            // 
            this.lblMaxAlarmCode.AutoSize = true;
            this.lblMaxAlarmCode.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold);
            this.lblMaxAlarmCode.Location = new System.Drawing.Point(12, 23);
            this.lblMaxAlarmCode.Name = "lblMaxAlarmCode";
            this.lblMaxAlarmCode.Size = new System.Drawing.Size(74, 42);
            this.lblMaxAlarmCode.TabIndex = 0;
            this.lblMaxAlarmCode.Text = "----";
            // 
            // lblMaxAlarmCodeTimes
            // 
            this.lblMaxAlarmCodeTimes.AutoSize = true;
            this.lblMaxAlarmCodeTimes.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblMaxAlarmCodeTimes.Location = new System.Drawing.Point(14, 62);
            this.lblMaxAlarmCodeTimes.Name = "lblMaxAlarmCodeTimes";
            this.lblMaxAlarmCodeTimes.Size = new System.Drawing.Size(103, 23);
            this.lblMaxAlarmCodeTimes.TabIndex = 1;
            this.lblMaxAlarmCodeTimes.Text = "(Times ---)";
            // 
            // gbMaxMachine
            // 
            this.gbMaxMachine.Controls.Add(this.lblMaxMachine);
            this.gbMaxMachine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMaxMachine.Font = new System.Drawing.Font("微軟正黑體", 10.8F);
            this.gbMaxMachine.Location = new System.Drawing.Point(655, 3);
            this.gbMaxMachine.Name = "gbMaxMachine";
            this.gbMaxMachine.Size = new System.Drawing.Size(320, 102);
            this.gbMaxMachine.TabIndex = 2;
            this.gbMaxMachine.TabStop = false;
            this.gbMaxMachine.Text = "Most Affected Machine";
            // 
            // lblMaxMachine
            // 
            this.lblMaxMachine.AutoSize = true;
            this.lblMaxMachine.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold);
            this.lblMaxMachine.Location = new System.Drawing.Point(12, 31);
            this.lblMaxMachine.Name = "lblMaxMachine";
            this.lblMaxMachine.Size = new System.Drawing.Size(74, 42);
            this.lblMaxMachine.TabIndex = 0;
            this.lblMaxMachine.Text = "----";
            // 
            // panelStatus
            // 
            this.panelStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.panelStatus.Controls.Add(this.lblCurrentModeTitle);
            this.panelStatus.Controls.Add(this.lblCurrentMode);
            this.panelStatus.Controls.Add(this.lblDatabasePathTitle);
            this.panelStatus.Controls.Add(this.lblDatabasePath);
            this.panelStatus.Controls.Add(this.lblSourceStatusTitle);
            this.panelStatus.Controls.Add(this.lblSourceStatus);
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStatus.Location = new System.Drawing.Point(0, 0);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(978, 46);
            this.panelStatus.TabIndex = 0;
            // 
            // lblCurrentModeTitle
            // 
            this.lblCurrentModeTitle.AutoSize = true;
            this.lblCurrentModeTitle.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblCurrentModeTitle.Location = new System.Drawing.Point(12, 8);
            this.lblCurrentModeTitle.Name = "lblCurrentModeTitle";
            this.lblCurrentModeTitle.Size = new System.Drawing.Size(100, 22);
            this.lblCurrentModeTitle.TabIndex = 0;
            this.lblCurrentModeTitle.Text = "Run Mode:";
            // 
            // lblCurrentMode
            // 
            this.lblCurrentMode.AutoSize = true;
            this.lblCurrentMode.Font = new System.Drawing.Font("微軟正黑體", 10.2F);
            this.lblCurrentMode.Location = new System.Drawing.Point(114, 8);
            this.lblCurrentMode.Name = "lblCurrentMode";
            this.lblCurrentMode.Size = new System.Drawing.Size(74, 22);
            this.lblCurrentMode.TabIndex = 1;
            this.lblCurrentMode.Text = "Remote";
            // 
            // lblDatabasePathTitle
            // 
            this.lblDatabasePathTitle.AutoSize = true;
            this.lblDatabasePathTitle.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblDatabasePathTitle.Location = new System.Drawing.Point(210, 8);
            this.lblDatabasePathTitle.Name = "lblDatabasePathTitle";
            this.lblDatabasePathTitle.Size = new System.Drawing.Size(81, 22);
            this.lblDatabasePathTitle.TabIndex = 2;
            this.lblDatabasePathTitle.Text = "DB Path:";
            // 
            // lblDatabasePath
            // 
            this.lblDatabasePath.AutoEllipsis = true;
            this.lblDatabasePath.Font = new System.Drawing.Font("微軟正黑體", 10.2F);
            this.lblDatabasePath.Location = new System.Drawing.Point(292, 8);
            this.lblDatabasePath.Name = "lblDatabasePath";
            this.lblDatabasePath.Size = new System.Drawing.Size(360, 22);
            this.lblDatabasePath.TabIndex = 3;
            this.lblDatabasePath.Text = "-";
            // 
            // lblSourceStatusTitle
            // 
            this.lblSourceStatusTitle.AutoSize = true;
            this.lblSourceStatusTitle.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblSourceStatusTitle.Location = new System.Drawing.Point(664, 8);
            this.lblSourceStatusTitle.Name = "lblSourceStatusTitle";
            this.lblSourceStatusTitle.Size = new System.Drawing.Size(67, 22);
            this.lblSourceStatusTitle.TabIndex = 4;
            this.lblSourceStatusTitle.Text = "Status:";
            // 
            // lblSourceStatus
            // 
            this.lblSourceStatus.AutoEllipsis = true;
            this.lblSourceStatus.Font = new System.Drawing.Font("微軟正黑體", 10.2F);
            this.lblSourceStatus.Location = new System.Drawing.Point(731, 8);
            this.lblSourceStatus.Name = "lblSourceStatus";
            this.lblSourceStatus.Size = new System.Drawing.Size(206, 22);
            this.lblSourceStatus.TabIndex = 5;
            this.lblSourceStatus.Text = "Idle";
            // 
            // AlarmDashboardView3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpRoot);
            this.Font = new System.Drawing.Font("微軟正黑體", 13.8F);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "AlarmDashboardView3";
            this.Size = new System.Drawing.Size(1280, 820);
            this.tlpRoot.ResumeLayout(false);
            this.gbSource.ResumeLayout(false);
            this.gbSource.PerformLayout();
            this.gbExportActions.ResumeLayout(false);
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
            this.panelCodeFilter.ResumeLayout(false);
            this.panelCodeFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarnCodeFilterClear)).EndInit();
            this.panelFilterHint.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvWareCode)).EndInit();
            this.panelWarnCodeSearch.ResumeLayout(false);
            this.panelWarnCodeSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarnCodeSearchClear)).EndInit();
            this.gbAlarmDetails.ResumeLayout(false);
            this.panelDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlarmTable)).EndInit();
            this.panelPaging.ResumeLayout(false);
            this.panelPaging.PerformLayout();
            this.tlpKpi.ResumeLayout(false);
            this.gbTotalAlarms.ResumeLayout(false);
            this.gbTotalAlarms.PerformLayout();
            this.gbMaxAlarm.ResumeLayout(false);
            this.gbMaxAlarm.PerformLayout();
            this.gbMaxMachine.ResumeLayout(false);
            this.gbMaxMachine.PerformLayout();
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TableLayoutPanel tlpRoot;
        private System.Windows.Forms.GroupBox gbSource;
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
        private System.Windows.Forms.Button btnMachinesAll;
        private System.Windows.Forms.Button btnMachinesClear;
        private System.Windows.Forms.Panel panelCodeFilter;
        private System.Windows.Forms.Label lblWarnCodeFilter;
        private System.Windows.Forms.TextBox txtWarnCodeFilter;
        private System.Windows.Forms.PictureBox pbWarnCodeFilterClear;
        private System.Windows.Forms.Panel panelFilterHint;
        private System.Windows.Forms.Label lblFilterHint;
        private System.Windows.Forms.Panel panelRight;
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
        private System.Windows.Forms.Panel panelWarnCodeSearch;
        private System.Windows.Forms.Label lblWarnCodeSearch;
        private System.Windows.Forms.TextBox txtWarnCodeSearch;
        private System.Windows.Forms.PictureBox pbWarnCodeSearchClear;
        private System.Windows.Forms.DataGridView dgvWareCode;
        private System.Windows.Forms.GroupBox gbAlarmDetails;
        private System.Windows.Forms.Panel panelDetails;
        private System.Windows.Forms.DataGridView dgvAlarmTable;
        private System.Windows.Forms.Panel panelPaging;
        private System.Windows.Forms.Button btnPrevPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Label lblPagingStatus;
        private System.Windows.Forms.TextBox txtJumpPage;
        private System.Windows.Forms.Button btnJumpPage;
        private System.Windows.Forms.TableLayoutPanel tlpKpi;
        private System.Windows.Forms.GroupBox gbTotalAlarms;
        private System.Windows.Forms.Label lblTotalAlarms;
        private System.Windows.Forms.GroupBox gbMaxAlarm;
        private System.Windows.Forms.Label lblMaxAlarmCode;
        private System.Windows.Forms.Label lblMaxAlarmCodeTimes;
        private System.Windows.Forms.GroupBox gbMaxMachine;
        private System.Windows.Forms.Label lblMaxMachine;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.Label lblCurrentModeTitle;
        private System.Windows.Forms.Label lblCurrentMode;
        private System.Windows.Forms.Label lblDatabasePathTitle;
        private System.Windows.Forms.Label lblDatabasePath;
        private System.Windows.Forms.Label lblSourceStatusTitle;
        private System.Windows.Forms.Label lblSourceStatus;
    }
}


