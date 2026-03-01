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
            this.tlpLeft = new System.Windows.Forms.TableLayoutPanel();
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
            this.lblSourceStatusTitle = new System.Windows.Forms.Label();
            this.lblSourceStatus = new System.Windows.Forms.Label();
            this.gbFilters = new System.Windows.Forms.GroupBox();
            this.tlpFilters = new System.Windows.Forms.TableLayoutPanel();
            this.panelDateFilter = new System.Windows.Forms.Panel();
            this.ckbDateRangeEnable = new System.Windows.Forms.CheckBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.panelMachines = new System.Windows.Forms.Panel();
            this.lblMachines = new System.Windows.Forms.Label();
            this.clbMachines = new System.Windows.Forms.CheckedListBox();
            this.btnMachinesAll = new System.Windows.Forms.Button();
            this.btnMachinesClear = new System.Windows.Forms.Button();
            this.panelCodeFilter = new System.Windows.Forms.Panel();
            this.lblWarnCodeFilter = new System.Windows.Forms.Label();
            this.txtWarnCodeFilter = new System.Windows.Forms.TextBox();
            this.gbWarnCode = new System.Windows.Forms.GroupBox();
            this.dgvWareCode = new System.Windows.Forms.DataGridView();
            this.btnApply = new System.Windows.Forms.Button();
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.tlpPlots = new System.Windows.Forms.TableLayoutPanel();
            this.fpCodeBar = new ScottPlot.FormsPlot();
            this.fpMachineBar = new ScottPlot.FormsPlot();
            this.fpPareto = new ScottPlot.FormsPlot();
            this.fpDailyTrend = new ScottPlot.FormsPlot();
            this.fpHourHistogram = new ScottPlot.FormsPlot();
            this.panelPlotSpacer = new System.Windows.Forms.Panel();
            this.panelPaging = new System.Windows.Forms.Panel();
            this.btnPrevPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.lblPagingStatus = new System.Windows.Forms.Label();
            this.txtJumpPage = new System.Windows.Forms.TextBox();
            this.btnJumpPage = new System.Windows.Forms.Button();
            this.dgvAlarmTable = new System.Windows.Forms.DataGridView();
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
            this.btnExportWarnCodesCsv = new System.Windows.Forms.Button();
            this.btnExportAlarmsCsv = new System.Windows.Forms.Button();
            this.btnExportAllAlarmsCsv = new System.Windows.Forms.Button();
            this.tlpRoot.SuspendLayout();
            this.tlpLeft.SuspendLayout();
            this.gbSource.SuspendLayout();
            this.gbFilters.SuspendLayout();
            this.tlpFilters.SuspendLayout();
            this.panelDateFilter.SuspendLayout();
            this.panelMachines.SuspendLayout();
            this.panelCodeFilter.SuspendLayout();
            this.gbWarnCode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWareCode)).BeginInit();
            this.panelDashboard.SuspendLayout();
            this.tlpPlots.SuspendLayout();
            this.panelPaging.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlarmTable)).BeginInit();
            this.tlpKpi.SuspendLayout();
            this.gbTotalAlarms.SuspendLayout();
            this.gbMaxAlarm.SuspendLayout();
            this.gbMaxMachine.SuspendLayout();
            this.panelStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpRoot
            // 
            this.tlpRoot.ColumnCount = 2;
            this.tlpRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 340F));
            this.tlpRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRoot.Controls.Add(this.tlpLeft, 0, 0);
            this.tlpRoot.Controls.Add(this.panelDashboard, 1, 0);
            this.tlpRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRoot.Location = new System.Drawing.Point(0, 0);
            this.tlpRoot.Margin = new System.Windows.Forms.Padding(0);
            this.tlpRoot.Name = "tlpRoot";
            this.tlpRoot.RowCount = 1;
            this.tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRoot.Size = new System.Drawing.Size(1280, 820);
            this.tlpRoot.TabIndex = 0;
            // 
            // tlpLeft
            // 
            this.tlpLeft.ColumnCount = 1;
            this.tlpLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLeft.Controls.Add(this.gbSource, 0, 0);
            this.tlpLeft.Controls.Add(this.gbFilters, 0, 1);
            this.tlpLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLeft.Location = new System.Drawing.Point(0, 0);
            this.tlpLeft.Margin = new System.Windows.Forms.Padding(0);
            this.tlpLeft.Name = "tlpLeft";
            this.tlpLeft.RowCount = 2;
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 230F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLeft.Size = new System.Drawing.Size(340, 820);
            this.tlpLeft.TabIndex = 0;
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
            this.gbSource.Controls.Add(this.lblSourceStatusTitle);
            this.gbSource.Controls.Add(this.lblSourceStatus);
            this.gbSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSource.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold);
            this.gbSource.Location = new System.Drawing.Point(3, 3);
            this.gbSource.Name = "gbSource";
            this.gbSource.Size = new System.Drawing.Size(334, 224);
            this.gbSource.TabIndex = 0;
            this.gbSource.TabStop = false;
            this.gbSource.Text = "Source";
            // 
            // rdbRemote
            // 
            this.rdbRemote.AutoSize = true;
            this.rdbRemote.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.rdbRemote.Location = new System.Drawing.Point(14, 33);
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
            this.lblRemotePath.Location = new System.Drawing.Point(10, 76);
            this.lblRemotePath.Name = "lblRemotePath";
            this.lblRemotePath.Size = new System.Drawing.Size(81, 22);
            this.lblRemotePath.TabIndex = 2;
            this.lblRemotePath.Text = "NAS Log";
            // 
            // txtRemotePath
            // 
            this.txtRemotePath.Font = new System.Drawing.Font("微軟正黑體", 10.2F);
            this.txtRemotePath.Location = new System.Drawing.Point(97, 71);
            this.txtRemotePath.Multiline = true;
            this.txtRemotePath.Name = "txtRemotePath";
            this.txtRemotePath.Size = new System.Drawing.Size(144, 66);
            this.txtRemotePath.TabIndex = 3;
            // 
            // btnBrowseRemote
            // 
            this.btnBrowseRemote.Font = new System.Drawing.Font("微軟正黑體", 10.2F);
            this.btnBrowseRemote.Location = new System.Drawing.Point(247, 71);
            this.btnBrowseRemote.Name = "btnBrowseRemote";
            this.btnBrowseRemote.Size = new System.Drawing.Size(75, 30);
            this.btnBrowseRemote.TabIndex = 4;
            this.btnBrowseRemote.Text = "Browse";
            this.btnBrowseRemote.UseVisualStyleBackColor = true;
            // 
            // btnTestRemote
            // 
            this.btnTestRemote.Font = new System.Drawing.Font("微軟正黑體", 10.2F);
            this.btnTestRemote.Location = new System.Drawing.Point(247, 107);
            this.btnTestRemote.Name = "btnTestRemote";
            this.btnTestRemote.Size = new System.Drawing.Size(75, 30);
            this.btnTestRemote.TabIndex = 5;
            this.btnTestRemote.Text = "Test";
            this.btnTestRemote.UseVisualStyleBackColor = true;
            // 
            // lblLocalPath
            // 
            this.lblLocalPath.AutoSize = true;
            this.lblLocalPath.Font = new System.Drawing.Font("微軟正黑體", 10.2F);
            this.lblLocalPath.Location = new System.Drawing.Point(10, 151);
            this.lblLocalPath.Name = "lblLocalPath";
            this.lblLocalPath.Size = new System.Drawing.Size(86, 22);
            this.lblLocalPath.TabIndex = 6;
            this.lblLocalPath.Text = "Local Log";
            // 
            // txtLocalPath
            // 
            this.txtLocalPath.Font = new System.Drawing.Font("微軟正黑體", 10.2F);
            this.txtLocalPath.Location = new System.Drawing.Point(97, 146);
            this.txtLocalPath.Name = "txtLocalPath";
            this.txtLocalPath.Size = new System.Drawing.Size(144, 30);
            this.txtLocalPath.TabIndex = 7;
            // 
            // btnBrowseLocal
            // 
            this.btnBrowseLocal.Font = new System.Drawing.Font("微軟正黑體", 10.2F);
            this.btnBrowseLocal.Location = new System.Drawing.Point(247, 146);
            this.btnBrowseLocal.Name = "btnBrowseLocal";
            this.btnBrowseLocal.Size = new System.Drawing.Size(75, 30);
            this.btnBrowseLocal.TabIndex = 8;
            this.btnBrowseLocal.Text = "Browse";
            this.btnBrowseLocal.UseVisualStyleBackColor = true;
            // 
            // lblSourceStatusTitle
            // 
            this.lblSourceStatusTitle.AutoSize = true;
            this.lblSourceStatusTitle.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblSourceStatusTitle.Location = new System.Drawing.Point(10, 189);
            this.lblSourceStatusTitle.Name = "lblSourceStatusTitle";
            this.lblSourceStatusTitle.Size = new System.Drawing.Size(67, 22);
            this.lblSourceStatusTitle.TabIndex = 9;
            this.lblSourceStatusTitle.Text = "Status:";
            // 
            // lblSourceStatus
            // 
            this.lblSourceStatus.AutoEllipsis = true;
            this.lblSourceStatus.Font = new System.Drawing.Font("微軟正黑體", 10.2F);
            this.lblSourceStatus.Location = new System.Drawing.Point(94, 189);
            this.lblSourceStatus.Name = "lblSourceStatus";
            this.lblSourceStatus.Size = new System.Drawing.Size(228, 24);
            this.lblSourceStatus.TabIndex = 10;
            this.lblSourceStatus.Text = "Idle";
            // 
            // gbFilters
            // 
            this.gbFilters.Controls.Add(this.tlpFilters);
            this.gbFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFilters.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold);
            this.gbFilters.Location = new System.Drawing.Point(3, 233);
            this.gbFilters.Name = "gbFilters";
            this.gbFilters.Size = new System.Drawing.Size(334, 584);
            this.gbFilters.TabIndex = 1;
            this.gbFilters.TabStop = false;
            this.gbFilters.Text = "Filters";
            // 
            // tlpFilters
            // 
            this.tlpFilters.ColumnCount = 1;
            this.tlpFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFilters.Controls.Add(this.panelDateFilter, 0, 0);
            this.tlpFilters.Controls.Add(this.panelMachines, 0, 1);
            this.tlpFilters.Controls.Add(this.panelCodeFilter, 0, 2);
            this.tlpFilters.Controls.Add(this.gbWarnCode, 0, 3);
            this.tlpFilters.Controls.Add(this.btnApply, 0, 4);
            this.tlpFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFilters.Location = new System.Drawing.Point(3, 34);
            this.tlpFilters.Name = "tlpFilters";
            this.tlpFilters.RowCount = 5;
            this.tlpFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tlpFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 260F));
            this.tlpFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpFilters.Size = new System.Drawing.Size(328, 547);
            this.tlpFilters.TabIndex = 0;
            // 
            // panelDateFilter
            // 
            this.panelDateFilter.Controls.Add(this.ckbDateRangeEnable);
            this.panelDateFilter.Controls.Add(this.lblStartDate);
            this.panelDateFilter.Controls.Add(this.lblEndDate);
            this.panelDateFilter.Controls.Add(this.dtpFrom);
            this.panelDateFilter.Controls.Add(this.dtpTo);
            this.panelDateFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDateFilter.Location = new System.Drawing.Point(3, 3);
            this.panelDateFilter.Name = "panelDateFilter";
            this.panelDateFilter.Size = new System.Drawing.Size(322, 134);
            this.panelDateFilter.TabIndex = 0;
            // 
            // ckbDateRangeEnable
            // 
            this.ckbDateRangeEnable.AutoSize = true;
            this.ckbDateRangeEnable.Font = new System.Drawing.Font("微軟正黑體", 10.8F);
            this.ckbDateRangeEnable.Location = new System.Drawing.Point(8, 7);
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
            this.panelMachines.Location = new System.Drawing.Point(3, 143);
            this.panelMachines.Name = "panelMachines";
            this.panelMachines.Size = new System.Drawing.Size(322, 254);
            this.panelMachines.TabIndex = 1;
            // 
            // lblMachines
            // 
            this.lblMachines.AutoSize = true;
            this.lblMachines.Font = new System.Drawing.Font("微軟正黑體", 10.8F);
            this.lblMachines.Location = new System.Drawing.Point(7, 8);
            this.lblMachines.Name = "lblMachines";
            this.lblMachines.Size = new System.Drawing.Size(91, 23);
            this.lblMachines.TabIndex = 0;
            this.lblMachines.Text = "Machines";
            // 
            // clbMachines
            // 
            this.clbMachines.Font = new System.Drawing.Font("微軟正黑體", 13.8F);
            this.clbMachines.FormattingEnabled = true;
            this.clbMachines.Location = new System.Drawing.Point(8, 41);
            this.clbMachines.Name = "clbMachines";
            this.clbMachines.Size = new System.Drawing.Size(301, 136);
            this.clbMachines.TabIndex = 1;
            // 
            // btnMachinesAll
            // 
            this.btnMachinesAll.Font = new System.Drawing.Font("微軟正黑體", 13.8F);
            this.btnMachinesAll.Location = new System.Drawing.Point(8, 205);
            this.btnMachinesAll.Name = "btnMachinesAll";
            this.btnMachinesAll.Size = new System.Drawing.Size(144, 40);
            this.btnMachinesAll.TabIndex = 2;
            this.btnMachinesAll.Text = "All";
            this.btnMachinesAll.UseVisualStyleBackColor = true;
            // 
            // btnMachinesClear
            // 
            this.btnMachinesClear.Font = new System.Drawing.Font("微軟正黑體", 13.8F);
            this.btnMachinesClear.Location = new System.Drawing.Point(165, 205);
            this.btnMachinesClear.Name = "btnMachinesClear";
            this.btnMachinesClear.Size = new System.Drawing.Size(144, 40);
            this.btnMachinesClear.TabIndex = 3;
            this.btnMachinesClear.Text = "Clear";
            this.btnMachinesClear.UseVisualStyleBackColor = true;
            // 
            // panelCodeFilter
            // 
            this.panelCodeFilter.Controls.Add(this.lblWarnCodeFilter);
            this.panelCodeFilter.Controls.Add(this.txtWarnCodeFilter);
            this.panelCodeFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCodeFilter.Location = new System.Drawing.Point(3, 403);
            this.panelCodeFilter.Name = "panelCodeFilter";
            this.panelCodeFilter.Size = new System.Drawing.Size(322, 44);
            this.panelCodeFilter.TabIndex = 2;
            // 
            // lblWarnCodeFilter
            // 
            this.lblWarnCodeFilter.AutoSize = true;
            this.lblWarnCodeFilter.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.lblWarnCodeFilter.Location = new System.Drawing.Point(7, 8);
            this.lblWarnCodeFilter.Name = "lblWarnCodeFilter";
            this.lblWarnCodeFilter.Size = new System.Drawing.Size(112, 25);
            this.lblWarnCodeFilter.TabIndex = 0;
            this.lblWarnCodeFilter.Text = "WarnCode";
            // 
            // txtWarnCodeFilter
            // 
            this.txtWarnCodeFilter.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.txtWarnCodeFilter.Location = new System.Drawing.Point(117, 5);
            this.txtWarnCodeFilter.Name = "txtWarnCodeFilter";
            this.txtWarnCodeFilter.Size = new System.Drawing.Size(192, 34);
            this.txtWarnCodeFilter.TabIndex = 1;
            // 
            // gbWarnCode
            // 
            this.gbWarnCode.Controls.Add(this.dgvWareCode);
            this.gbWarnCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbWarnCode.Font = new System.Drawing.Font("微軟正黑體", 10.8F);
            this.gbWarnCode.Location = new System.Drawing.Point(3, 453);
            this.gbWarnCode.Name = "gbWarnCode";
            this.gbWarnCode.Size = new System.Drawing.Size(322, 41);
            this.gbWarnCode.TabIndex = 3;
            this.gbWarnCode.TabStop = false;
            this.gbWarnCode.Text = "Warn Code";
            // 
            // dgvWareCode
            // 
            this.dgvWareCode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWareCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWareCode.Location = new System.Drawing.Point(3, 27);
            this.dgvWareCode.Name = "dgvWareCode";
            this.dgvWareCode.RowHeadersWidth = 51;
            this.dgvWareCode.RowTemplate.Height = 27;
            this.dgvWareCode.Size = new System.Drawing.Size(316, 11);
            this.dgvWareCode.TabIndex = 0;
            // 
            // btnApply
            // 
            this.btnApply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnApply.Font = new System.Drawing.Font("微軟正黑體", 13.8F);
            this.btnApply.Location = new System.Drawing.Point(3, 500);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(322, 44);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            // 
            // panelDashboard
            // 
            this.panelDashboard.Controls.Add(this.tlpPlots);
            this.panelDashboard.Controls.Add(this.panelPaging);
            this.panelDashboard.Controls.Add(this.dgvAlarmTable);
            this.panelDashboard.Controls.Add(this.tlpKpi);
            this.panelDashboard.Controls.Add(this.panelStatus);
            this.panelDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDashboard.Location = new System.Drawing.Point(340, 0);
            this.panelDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Size = new System.Drawing.Size(940, 820);
            this.panelDashboard.TabIndex = 1;
            // 
            // tlpPlots
            // 
            this.tlpPlots.ColumnCount = 2;
            this.tlpPlots.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPlots.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPlots.Controls.Add(this.fpCodeBar, 0, 0);
            this.tlpPlots.Controls.Add(this.fpMachineBar, 1, 0);
            this.tlpPlots.Controls.Add(this.fpPareto, 0, 1);
            this.tlpPlots.Controls.Add(this.fpDailyTrend, 1, 1);
            this.tlpPlots.Controls.Add(this.fpHourHistogram, 0, 2);
            this.tlpPlots.Controls.Add(this.panelPlotSpacer, 1, 2);
            this.tlpPlots.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPlots.Location = new System.Drawing.Point(0, 144);
            this.tlpPlots.Name = "tlpPlots";
            this.tlpPlots.RowCount = 3;
            this.tlpPlots.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tlpPlots.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpPlots.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpPlots.Size = new System.Drawing.Size(940, 418);
            this.tlpPlots.TabIndex = 4;
            // 
            // fpCodeBar
            // 
            this.fpCodeBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpCodeBar.Location = new System.Drawing.Point(16, 12);
            this.fpCodeBar.Margin = new System.Windows.Forms.Padding(16, 12, 16, 12);
            this.fpCodeBar.Name = "fpCodeBar";
            this.fpCodeBar.Size = new System.Drawing.Size(438, 115);
            this.fpCodeBar.TabIndex = 0;
            // 
            // fpMachineBar
            // 
            this.fpMachineBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpMachineBar.Location = new System.Drawing.Point(486, 12);
            this.fpMachineBar.Margin = new System.Windows.Forms.Padding(16, 12, 16, 12);
            this.fpMachineBar.Name = "fpMachineBar";
            this.fpMachineBar.Size = new System.Drawing.Size(438, 115);
            this.fpMachineBar.TabIndex = 1;
            // 
            // fpPareto
            // 
            this.fpPareto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpPareto.Location = new System.Drawing.Point(16, 151);
            this.fpPareto.Margin = new System.Windows.Forms.Padding(16, 12, 16, 12);
            this.fpPareto.Name = "fpPareto";
            this.fpPareto.Size = new System.Drawing.Size(438, 115);
            this.fpPareto.TabIndex = 2;
            // 
            // fpDailyTrend
            // 
            this.fpDailyTrend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpDailyTrend.Location = new System.Drawing.Point(486, 151);
            this.fpDailyTrend.Margin = new System.Windows.Forms.Padding(16, 12, 16, 12);
            this.fpDailyTrend.Name = "fpDailyTrend";
            this.fpDailyTrend.Size = new System.Drawing.Size(438, 115);
            this.fpDailyTrend.TabIndex = 3;
            // 
            // fpHourHistogram
            // 
            this.fpHourHistogram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpHourHistogram.Location = new System.Drawing.Point(16, 290);
            this.fpHourHistogram.Margin = new System.Windows.Forms.Padding(16, 12, 16, 12);
            this.fpHourHistogram.Name = "fpHourHistogram";
            this.fpHourHistogram.Size = new System.Drawing.Size(438, 116);
            this.fpHourHistogram.TabIndex = 4;
            // 
            // panelPlotSpacer
            // 
            this.panelPlotSpacer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPlotSpacer.Location = new System.Drawing.Point(470, 278);
            this.panelPlotSpacer.Margin = new System.Windows.Forms.Padding(0);
            this.panelPlotSpacer.Name = "panelPlotSpacer";
            this.panelPlotSpacer.Size = new System.Drawing.Size(470, 140);
            this.panelPlotSpacer.TabIndex = 5;
            // 
            // panelPaging
            // 
            this.panelPaging.Controls.Add(this.btnPrevPage);
            this.panelPaging.Controls.Add(this.btnNextPage);
            this.panelPaging.Controls.Add(this.lblPagingStatus);
            this.panelPaging.Controls.Add(this.txtJumpPage);
            this.panelPaging.Controls.Add(this.btnJumpPage);
            this.panelPaging.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPaging.Location = new System.Drawing.Point(0, 562);
            this.panelPaging.Name = "panelPaging";
            this.panelPaging.Size = new System.Drawing.Size(940, 38);
            this.panelPaging.TabIndex = 3;
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.Font = new System.Drawing.Font("微軟正黑體", 9.5F);
            this.btnPrevPage.Location = new System.Drawing.Point(16, 4);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(85, 30);
            this.btnPrevPage.TabIndex = 0;
            this.btnPrevPage.Text = "Prev";
            this.btnPrevPage.UseVisualStyleBackColor = true;
            // 
            // btnNextPage
            // 
            this.btnNextPage.Font = new System.Drawing.Font("微軟正黑體", 9.5F);
            this.btnNextPage.Location = new System.Drawing.Point(107, 4);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(85, 30);
            this.btnNextPage.TabIndex = 1;
            this.btnNextPage.Text = "Next";
            this.btnNextPage.UseVisualStyleBackColor = true;
            // 
            // lblPagingStatus
            // 
            this.lblPagingStatus.Font = new System.Drawing.Font("微軟正黑體", 10.2F);
            this.lblPagingStatus.Location = new System.Drawing.Point(208, 8);
            this.lblPagingStatus.Name = "lblPagingStatus";
            this.lblPagingStatus.Size = new System.Drawing.Size(240, 22);
            this.lblPagingStatus.TabIndex = 2;
            this.lblPagingStatus.Text = "Page 0 / 0";
            // 
            // txtJumpPage
            // 
            this.txtJumpPage.Font = new System.Drawing.Font("微軟正黑體", 10.2F);
            this.txtJumpPage.Location = new System.Drawing.Point(458, 4);
            this.txtJumpPage.Name = "txtJumpPage";
            this.txtJumpPage.Size = new System.Drawing.Size(70, 30);
            this.txtJumpPage.TabIndex = 3;
            // 
            // btnJumpPage
            // 
            this.btnJumpPage.Font = new System.Drawing.Font("微軟正黑體", 9.5F);
            this.btnJumpPage.Location = new System.Drawing.Point(535, 4);
            this.btnJumpPage.Name = "btnJumpPage";
            this.btnJumpPage.Size = new System.Drawing.Size(65, 30);
            this.btnJumpPage.TabIndex = 4;
            this.btnJumpPage.Text = "Go";
            this.btnJumpPage.UseVisualStyleBackColor = true;
            // 
            // dgvAlarmTable
            // 
            this.dgvAlarmTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlarmTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAlarmTable.Location = new System.Drawing.Point(0, 600);
            this.dgvAlarmTable.Name = "dgvAlarmTable";
            this.dgvAlarmTable.RowHeadersWidth = 51;
            this.dgvAlarmTable.RowTemplate.Height = 27;
            this.dgvAlarmTable.Size = new System.Drawing.Size(940, 220);
            this.dgvAlarmTable.TabIndex = 2;
            // 
            // tlpKpi
            // 
            this.tlpKpi.ColumnCount = 3;
            this.tlpKpi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tlpKpi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tlpKpi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 500F));
            this.tlpKpi.Controls.Add(this.gbTotalAlarms, 0, 0);
            this.tlpKpi.Controls.Add(this.gbMaxAlarm, 1, 0);
            this.tlpKpi.Controls.Add(this.gbMaxMachine, 2, 0);
            this.tlpKpi.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpKpi.Location = new System.Drawing.Point(0, 44);
            this.tlpKpi.Name = "tlpKpi";
            this.tlpKpi.RowCount = 1;
            this.tlpKpi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpKpi.Size = new System.Drawing.Size(940, 100);
            this.tlpKpi.TabIndex = 1;
            // 
            // gbTotalAlarms
            // 
            this.gbTotalAlarms.Controls.Add(this.lblTotalAlarms);
            this.gbTotalAlarms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTotalAlarms.Font = new System.Drawing.Font("微軟正黑體", 10.8F);
            this.gbTotalAlarms.Location = new System.Drawing.Point(3, 3);
            this.gbTotalAlarms.Name = "gbTotalAlarms";
            this.gbTotalAlarms.Size = new System.Drawing.Size(214, 94);
            this.gbTotalAlarms.TabIndex = 0;
            this.gbTotalAlarms.TabStop = false;
            this.gbTotalAlarms.Text = "Total Alarms";
            // 
            // lblTotalAlarms
            // 
            this.lblTotalAlarms.AutoSize = true;
            this.lblTotalAlarms.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold);
            this.lblTotalAlarms.Location = new System.Drawing.Point(6, 32);
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
            this.gbMaxAlarm.Location = new System.Drawing.Point(223, 3);
            this.gbMaxAlarm.Name = "gbMaxAlarm";
            this.gbMaxAlarm.Size = new System.Drawing.Size(214, 94);
            this.gbMaxAlarm.TabIndex = 1;
            this.gbMaxAlarm.TabStop = false;
            this.gbMaxAlarm.Text = "Max Code";
            // 
            // lblMaxAlarmCode
            // 
            this.lblMaxAlarmCode.AutoSize = true;
            this.lblMaxAlarmCode.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold);
            this.lblMaxAlarmCode.Location = new System.Drawing.Point(6, 29);
            this.lblMaxAlarmCode.Name = "lblMaxAlarmCode";
            this.lblMaxAlarmCode.Size = new System.Drawing.Size(74, 42);
            this.lblMaxAlarmCode.TabIndex = 0;
            this.lblMaxAlarmCode.Text = "----";
            // 
            // lblMaxAlarmCodeTimes
            // 
            this.lblMaxAlarmCodeTimes.AutoSize = true;
            this.lblMaxAlarmCodeTimes.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblMaxAlarmCodeTimes.Location = new System.Drawing.Point(7, 69);
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
            this.gbMaxMachine.Location = new System.Drawing.Point(443, 3);
            this.gbMaxMachine.Name = "gbMaxMachine";
            this.gbMaxMachine.Size = new System.Drawing.Size(494, 94);
            this.gbMaxMachine.TabIndex = 2;
            this.gbMaxMachine.TabStop = false;
            this.gbMaxMachine.Text = "Max Machine";
            // 
            // lblMaxMachine
            // 
            this.lblMaxMachine.AutoSize = true;
            this.lblMaxMachine.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold);
            this.lblMaxMachine.Location = new System.Drawing.Point(6, 32);
            this.lblMaxMachine.Name = "lblMaxMachine";
            this.lblMaxMachine.Size = new System.Drawing.Size(74, 42);
            this.lblMaxMachine.TabIndex = 0;
            this.lblMaxMachine.Text = "----";
            // 
            // panelStatus
            // 
            this.panelStatus.Controls.Add(this.lblCurrentModeTitle);
            this.panelStatus.Controls.Add(this.lblCurrentMode);
            this.panelStatus.Controls.Add(this.lblDatabasePathTitle);
            this.panelStatus.Controls.Add(this.lblDatabasePath);
            this.panelStatus.Controls.Add(this.btnExportWarnCodesCsv);
            this.panelStatus.Controls.Add(this.btnExportAlarmsCsv);
            this.panelStatus.Controls.Add(this.btnExportAllAlarmsCsv);
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStatus.Location = new System.Drawing.Point(0, 0);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(940, 44);
            this.panelStatus.TabIndex = 0;
            // 
            // lblCurrentModeTitle
            // 
            this.lblCurrentModeTitle.AutoSize = true;
            this.lblCurrentModeTitle.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblCurrentModeTitle.Location = new System.Drawing.Point(12, 10);
            this.lblCurrentModeTitle.Name = "lblCurrentModeTitle";
            this.lblCurrentModeTitle.Size = new System.Drawing.Size(100, 22);
            this.lblCurrentModeTitle.TabIndex = 0;
            this.lblCurrentModeTitle.Text = "Run Mode:";
            // 
            // lblCurrentMode
            // 
            this.lblCurrentMode.AutoSize = true;
            this.lblCurrentMode.Font = new System.Drawing.Font("微軟正黑體", 10.2F);
            this.lblCurrentMode.Location = new System.Drawing.Point(114, 10);
            this.lblCurrentMode.Name = "lblCurrentMode";
            this.lblCurrentMode.Size = new System.Drawing.Size(74, 22);
            this.lblCurrentMode.TabIndex = 1;
            this.lblCurrentMode.Text = "Remote";
            // 
            // lblDatabasePathTitle
            // 
            this.lblDatabasePathTitle.AutoSize = true;
            this.lblDatabasePathTitle.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblDatabasePathTitle.Location = new System.Drawing.Point(235, 10);
            this.lblDatabasePathTitle.Name = "lblDatabasePathTitle";
            this.lblDatabasePathTitle.Size = new System.Drawing.Size(81, 22);
            this.lblDatabasePathTitle.TabIndex = 2;
            this.lblDatabasePathTitle.Text = "DB Path:";
            // 
            // lblDatabasePath
            // 
            this.lblDatabasePath.AutoEllipsis = true;
            this.lblDatabasePath.Font = new System.Drawing.Font("微軟正黑體", 10.2F);
            this.lblDatabasePath.Location = new System.Drawing.Point(317, 10);
            this.lblDatabasePath.Name = "lblDatabasePath";
            this.lblDatabasePath.Size = new System.Drawing.Size(290, 22);
            this.lblDatabasePath.TabIndex = 3;
            this.lblDatabasePath.Text = "-";
            // 
            // btnExportWarnCodesCsv
            // 
            this.btnExportWarnCodesCsv.Font = new System.Drawing.Font("微軟正黑體", 9.2F);
            this.btnExportWarnCodesCsv.Location = new System.Drawing.Point(614, 6);
            this.btnExportWarnCodesCsv.Name = "btnExportWarnCodesCsv";
            this.btnExportWarnCodesCsv.Size = new System.Drawing.Size(100, 30);
            this.btnExportWarnCodesCsv.TabIndex = 4;
            this.btnExportWarnCodesCsv.Text = "Export Codes";
            this.btnExportWarnCodesCsv.UseVisualStyleBackColor = true;
            // 
            // btnExportAlarmsCsv
            // 
            this.btnExportAlarmsCsv.Font = new System.Drawing.Font("微軟正黑體", 9.2F);
            this.btnExportAlarmsCsv.Location = new System.Drawing.Point(720, 6);
            this.btnExportAlarmsCsv.Name = "btnExportAlarmsCsv";
            this.btnExportAlarmsCsv.Size = new System.Drawing.Size(100, 30);
            this.btnExportAlarmsCsv.TabIndex = 5;
            this.btnExportAlarmsCsv.Text = "Export Page";
            this.btnExportAlarmsCsv.UseVisualStyleBackColor = true;
            // 
            // btnExportAllAlarmsCsv
            // 
            this.btnExportAllAlarmsCsv.Font = new System.Drawing.Font("微軟正黑體", 9.2F);
            this.btnExportAllAlarmsCsv.Location = new System.Drawing.Point(826, 6);
            this.btnExportAllAlarmsCsv.Name = "btnExportAllAlarmsCsv";
            this.btnExportAllAlarmsCsv.Size = new System.Drawing.Size(100, 30);
            this.btnExportAllAlarmsCsv.TabIndex = 6;
            this.btnExportAllAlarmsCsv.Text = "Export All";
            this.btnExportAllAlarmsCsv.UseVisualStyleBackColor = true;
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
            this.tlpLeft.ResumeLayout(false);
            this.gbSource.ResumeLayout(false);
            this.gbSource.PerformLayout();
            this.gbFilters.ResumeLayout(false);
            this.tlpFilters.ResumeLayout(false);
            this.panelDateFilter.ResumeLayout(false);
            this.panelDateFilter.PerformLayout();
            this.panelMachines.ResumeLayout(false);
            this.panelMachines.PerformLayout();
            this.panelCodeFilter.ResumeLayout(false);
            this.panelCodeFilter.PerformLayout();
            this.gbWarnCode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWareCode)).EndInit();
            this.panelDashboard.ResumeLayout(false);
            this.tlpPlots.ResumeLayout(false);
            this.panelPaging.ResumeLayout(false);
            this.panelPaging.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlarmTable)).EndInit();
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
        private System.Windows.Forms.TableLayoutPanel tlpLeft;
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
        private System.Windows.Forms.Label lblSourceStatusTitle;
        private System.Windows.Forms.Label lblSourceStatus;
        private System.Windows.Forms.GroupBox gbFilters;
        private System.Windows.Forms.TableLayoutPanel tlpFilters;
        private System.Windows.Forms.Panel panelDateFilter;
        private System.Windows.Forms.CheckBox ckbDateRangeEnable;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Panel panelMachines;
        private System.Windows.Forms.Label lblMachines;
        private System.Windows.Forms.CheckedListBox clbMachines;
        private System.Windows.Forms.Button btnMachinesAll;
        private System.Windows.Forms.Button btnMachinesClear;
        private System.Windows.Forms.Panel panelCodeFilter;
        private System.Windows.Forms.Label lblWarnCodeFilter;
        private System.Windows.Forms.TextBox txtWarnCodeFilter;
        private System.Windows.Forms.GroupBox gbWarnCode;
        private System.Windows.Forms.DataGridView dgvWareCode;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Panel panelDashboard;
        private System.Windows.Forms.TableLayoutPanel tlpPlots;
        private ScottPlot.FormsPlot fpCodeBar;
        private ScottPlot.FormsPlot fpMachineBar;
        private ScottPlot.FormsPlot fpPareto;
        private ScottPlot.FormsPlot fpDailyTrend;
        private ScottPlot.FormsPlot fpHourHistogram;
        private System.Windows.Forms.Panel panelPlotSpacer;
        private System.Windows.Forms.Panel panelPaging;
        private System.Windows.Forms.Button btnPrevPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Label lblPagingStatus;
        private System.Windows.Forms.TextBox txtJumpPage;
        private System.Windows.Forms.Button btnJumpPage;
        private System.Windows.Forms.DataGridView dgvAlarmTable;
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
        private System.Windows.Forms.Button btnExportWarnCodesCsv;
        private System.Windows.Forms.Button btnExportAlarmsCsv;
        private System.Windows.Forms.Button btnExportAllAlarmsCsv;
    }
}
