namespace Project_LBTToolBox.Views.Alarms
{
    partial class AlarmDashboardView2
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tlp1_Left = new System.Windows.Forms.TableLayoutPanel();
            this.gbPaths = new System.Windows.Forms.GroupBox();
            this.btnBrowseFolder = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.gbOperate = new System.Windows.Forms.GroupBox();
            this.lblMachines = new System.Windows.Forms.Label();
            this.clbMachines = new System.Windows.Forms.CheckedListBox();
            this.btnMachinesClear = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnMachinesAll = new System.Windows.Forms.Button();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.ckbDateRangeEnable = new System.Windows.Forms.CheckBox();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.panelDashBoard = new System.Windows.Forms.Panel();
            this.dgvAlarmTable = new System.Windows.Forms.DataGridView();
            this.tpl3_KPI = new System.Windows.Forms.TableLayoutPanel();
            this.gbMaxAlarm = new System.Windows.Forms.GroupBox();
            this.lblMaxAlarmCodeTimes = new System.Windows.Forms.Label();
            this.gbTotalAlarms = new System.Windows.Forms.GroupBox();
            this.lblTotalAlarms = new System.Windows.Forms.Label();
            this.gbMaxMachine = new System.Windows.Forms.GroupBox();
            this.lblMaxMachine = new System.Windows.Forms.Label();
            this.lblMaxAlarmCode = new System.Windows.Forms.Label();
            this.tlp4_FormsPlot = new System.Windows.Forms.TableLayoutPanel();
            this.fpCodeBar = new ScottPlot.FormsPlot();
            this.fpMachineBar = new ScottPlot.FormsPlot();
            this.fpDailyTrend = new ScottPlot.FormsPlot();
            this.fpHourHistogram = new ScottPlot.FormsPlot();
            this.tpl2_Operate = new System.Windows.Forms.TableLayoutPanel();
            this.panelDateFilter = new System.Windows.Forms.Panel();
            this.panelMachines = new System.Windows.Forms.Panel();
            this.dgvWareCode = new System.Windows.Forms.DataGridView();
            this.gbWarnCode = new System.Windows.Forms.GroupBox();
            this.tlp1_Left.SuspendLayout();
            this.gbPaths.SuspendLayout();
            this.gbOperate.SuspendLayout();
            this.panelDashBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlarmTable)).BeginInit();
            this.tpl3_KPI.SuspendLayout();
            this.gbMaxAlarm.SuspendLayout();
            this.gbTotalAlarms.SuspendLayout();
            this.gbMaxMachine.SuspendLayout();
            this.tlp4_FormsPlot.SuspendLayout();
            this.tpl2_Operate.SuspendLayout();
            this.panelDateFilter.SuspendLayout();
            this.panelMachines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWareCode)).BeginInit();
            this.gbWarnCode.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp1_Left
            // 
            this.tlp1_Left.ColumnCount = 1;
            this.tlp1_Left.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp1_Left.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp1_Left.Controls.Add(this.gbPaths, 0, 0);
            this.tlp1_Left.Controls.Add(this.gbOperate, 0, 1);
            this.tlp1_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.tlp1_Left.Location = new System.Drawing.Point(0, 0);
            this.tlp1_Left.Name = "tlp1_Left";
            this.tlp1_Left.RowCount = 2;
            this.tlp1_Left.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.46442F));
            this.tlp1_Left.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.53558F));
            this.tlp1_Left.Size = new System.Drawing.Size(304, 773);
            this.tlp1_Left.TabIndex = 0;
            // 
            // gbPaths
            // 
            this.gbPaths.Controls.Add(this.btnBrowseFolder);
            this.gbPaths.Controls.Add(this.txtPath);
            this.gbPaths.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPaths.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbPaths.Location = new System.Drawing.Point(3, 3);
            this.gbPaths.Name = "gbPaths";
            this.gbPaths.Size = new System.Drawing.Size(298, 128);
            this.gbPaths.TabIndex = 1;
            this.gbPaths.TabStop = false;
            this.gbPaths.Text = "Main Folder";
            // 
            // btnBrowseFolder
            // 
            this.btnBrowseFolder.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBrowseFolder.Location = new System.Drawing.Point(154, 78);
            this.btnBrowseFolder.Name = "btnBrowseFolder";
            this.btnBrowseFolder.Size = new System.Drawing.Size(138, 42);
            this.btnBrowseFolder.TabIndex = 1;
            this.btnBrowseFolder.Text = "Browse";
            this.btnBrowseFolder.UseVisualStyleBackColor = true;
            // 
            // txtPath
            // 
            this.txtPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPath.Location = new System.Drawing.Point(3, 34);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(292, 38);
            this.txtPath.TabIndex = 0;
            // 
            // gbOperate
            // 
            this.gbOperate.Controls.Add(this.tpl2_Operate);
            this.gbOperate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbOperate.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbOperate.Location = new System.Drawing.Point(3, 137);
            this.gbOperate.Name = "gbOperate";
            this.gbOperate.Size = new System.Drawing.Size(298, 633);
            this.gbOperate.TabIndex = 2;
            this.gbOperate.TabStop = false;
            this.gbOperate.Text = "操作與篩選";
            // 
            // lblMachines
            // 
            this.lblMachines.AutoSize = true;
            this.lblMachines.Location = new System.Drawing.Point(3, 8);
            this.lblMachines.Name = "lblMachines";
            this.lblMachines.Size = new System.Drawing.Size(119, 29);
            this.lblMachines.TabIndex = 1;
            this.lblMachines.Text = "Machines";
            // 
            // clbMachines
            // 
            this.clbMachines.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.clbMachines.FormattingEnabled = true;
            this.clbMachines.Location = new System.Drawing.Point(8, 41);
            this.clbMachines.Name = "clbMachines";
            this.clbMachines.Size = new System.Drawing.Size(270, 202);
            this.clbMachines.TabIndex = 1;
            // 
            // btnMachinesClear
            // 
            this.btnMachinesClear.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMachinesClear.Location = new System.Drawing.Point(148, 249);
            this.btnMachinesClear.Name = "btnMachinesClear";
            this.btnMachinesClear.Size = new System.Drawing.Size(130, 42);
            this.btnMachinesClear.TabIndex = 14;
            this.btnMachinesClear.Text = "Clear";
            this.btnMachinesClear.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            this.btnApply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnApply.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnApply.Location = new System.Drawing.Point(3, 549);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(286, 44);
            this.btnApply.TabIndex = 12;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            // 
            // btnMachinesAll
            // 
            this.btnMachinesAll.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMachinesAll.Location = new System.Drawing.Point(8, 248);
            this.btnMachinesAll.Name = "btnMachinesAll";
            this.btnMachinesAll.Size = new System.Drawing.Size(130, 42);
            this.btnMachinesAll.TabIndex = 13;
            this.btnMachinesAll.Text = "All";
            this.btnMachinesAll.UseVisualStyleBackColor = true;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblEndDate.Location = new System.Drawing.Point(22, 93);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(46, 29);
            this.lblEndDate.TabIndex = 9;
            this.lblEndDate.Text = "To:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblStartDate.Location = new System.Drawing.Point(3, 49);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(75, 29);
            this.lblStartDate.TabIndex = 2;
            this.lblStartDate.Text = "From:";
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "yyyy-MM-dd";
            this.dtpFrom.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(77, 42);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(173, 38);
            this.dtpFrom.TabIndex = 6;
            // 
            // ckbDateRangeEnable
            // 
            this.ckbDateRangeEnable.AutoSize = true;
            this.ckbDateRangeEnable.Location = new System.Drawing.Point(3, 3);
            this.ckbDateRangeEnable.Name = "ckbDateRangeEnable";
            this.ckbDateRangeEnable.Size = new System.Drawing.Size(172, 33);
            this.ckbDateRangeEnable.TabIndex = 1;
            this.ckbDateRangeEnable.Text = "Date Ramge\r\n";
            this.ckbDateRangeEnable.UseVisualStyleBackColor = true;
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "yyyy-MM-dd";
            this.dtpTo.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(74, 86);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(173, 38);
            this.dtpTo.TabIndex = 8;
            // 
            // panelDashBoard
            // 
            this.panelDashBoard.Controls.Add(this.tlp4_FormsPlot);
            this.panelDashBoard.Controls.Add(this.dgvAlarmTable);
            this.panelDashBoard.Controls.Add(this.tpl3_KPI);
            this.panelDashBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDashBoard.Location = new System.Drawing.Point(304, 0);
            this.panelDashBoard.Name = "panelDashBoard";
            this.panelDashBoard.Size = new System.Drawing.Size(878, 773);
            this.panelDashBoard.TabIndex = 1;
            // 
            // dgvAlarmTable
            // 
            this.dgvAlarmTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlarmTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAlarmTable.Location = new System.Drawing.Point(0, 573);
            this.dgvAlarmTable.Name = "dgvAlarmTable";
            this.dgvAlarmTable.RowHeadersWidth = 51;
            this.dgvAlarmTable.RowTemplate.Height = 27;
            this.dgvAlarmTable.Size = new System.Drawing.Size(878, 200);
            this.dgvAlarmTable.TabIndex = 1;
            // 
            // tpl3_KPI
            // 
            this.tpl3_KPI.ColumnCount = 4;
            this.tpl3_KPI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tpl3_KPI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tpl3_KPI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tpl3_KPI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 226F));
            this.tpl3_KPI.Controls.Add(this.gbMaxMachine, 2, 0);
            this.tpl3_KPI.Controls.Add(this.gbMaxAlarm, 1, 0);
            this.tpl3_KPI.Controls.Add(this.gbTotalAlarms, 0, 0);
            this.tpl3_KPI.Dock = System.Windows.Forms.DockStyle.Top;
            this.tpl3_KPI.Location = new System.Drawing.Point(0, 0);
            this.tpl3_KPI.Name = "tpl3_KPI";
            this.tpl3_KPI.RowCount = 1;
            this.tpl3_KPI.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpl3_KPI.Size = new System.Drawing.Size(878, 100);
            this.tpl3_KPI.TabIndex = 0;
            // 
            // gbMaxAlarm
            // 
            this.gbMaxAlarm.BackColor = System.Drawing.Color.White;
            this.gbMaxAlarm.Controls.Add(this.lblMaxAlarmCodeTimes);
            this.gbMaxAlarm.Controls.Add(this.lblMaxAlarmCode);
            this.gbMaxAlarm.Cursor = System.Windows.Forms.Cursors.No;
            this.gbMaxAlarm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMaxAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbMaxAlarm.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbMaxAlarm.Location = new System.Drawing.Point(178, 3);
            this.gbMaxAlarm.Name = "gbMaxAlarm";
            this.gbMaxAlarm.Size = new System.Drawing.Size(169, 94);
            this.gbMaxAlarm.TabIndex = 3;
            this.gbMaxAlarm.TabStop = false;
            this.gbMaxAlarm.Text = "Max Code";
            // 
            // lblMaxAlarmCodeTimes
            // 
            this.lblMaxAlarmCodeTimes.AutoSize = true;
            this.lblMaxAlarmCodeTimes.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMaxAlarmCodeTimes.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMaxAlarmCodeTimes.Location = new System.Drawing.Point(60, 68);
            this.lblMaxAlarmCodeTimes.Name = "lblMaxAlarmCodeTimes";
            this.lblMaxAlarmCodeTimes.Size = new System.Drawing.Size(103, 23);
            this.lblMaxAlarmCodeTimes.TabIndex = 2;
            this.lblMaxAlarmCodeTimes.Text = "(Times ---)";
            this.lblMaxAlarmCodeTimes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbTotalAlarms
            // 
            this.gbTotalAlarms.BackColor = System.Drawing.Color.White;
            this.gbTotalAlarms.Controls.Add(this.lblTotalAlarms);
            this.gbTotalAlarms.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbTotalAlarms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTotalAlarms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbTotalAlarms.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbTotalAlarms.Location = new System.Drawing.Point(3, 3);
            this.gbTotalAlarms.Name = "gbTotalAlarms";
            this.gbTotalAlarms.Size = new System.Drawing.Size(169, 94);
            this.gbTotalAlarms.TabIndex = 2;
            this.gbTotalAlarms.TabStop = false;
            this.gbTotalAlarms.Text = "Total Alarms";
            // 
            // lblTotalAlarms
            // 
            this.lblTotalAlarms.AutoSize = true;
            this.lblTotalAlarms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalAlarms.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotalAlarms.Location = new System.Drawing.Point(3, 34);
            this.lblTotalAlarms.Name = "lblTotalAlarms";
            this.lblTotalAlarms.Size = new System.Drawing.Size(79, 43);
            this.lblTotalAlarms.TabIndex = 2;
            this.lblTotalAlarms.Text = "----";
            this.lblTotalAlarms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbMaxMachine
            // 
            this.gbMaxMachine.BackColor = System.Drawing.Color.White;
            this.gbMaxMachine.Controls.Add(this.lblMaxMachine);
            this.gbMaxMachine.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbMaxMachine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMaxMachine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbMaxMachine.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbMaxMachine.Location = new System.Drawing.Point(353, 3);
            this.gbMaxMachine.Name = "gbMaxMachine";
            this.gbMaxMachine.Size = new System.Drawing.Size(169, 94);
            this.gbMaxMachine.TabIndex = 4;
            this.gbMaxMachine.TabStop = false;
            this.gbMaxMachine.Text = "Max Mach.";
            // 
            // lblMaxMachine
            // 
            this.lblMaxMachine.AutoSize = true;
            this.lblMaxMachine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaxMachine.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMaxMachine.Location = new System.Drawing.Point(3, 34);
            this.lblMaxMachine.Name = "lblMaxMachine";
            this.lblMaxMachine.Size = new System.Drawing.Size(79, 43);
            this.lblMaxMachine.TabIndex = 2;
            this.lblMaxMachine.Text = "----";
            this.lblMaxMachine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaxAlarmCode
            // 
            this.lblMaxAlarmCode.AutoSize = true;
            this.lblMaxAlarmCode.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMaxAlarmCode.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMaxAlarmCode.Location = new System.Drawing.Point(6, 29);
            this.lblMaxAlarmCode.Name = "lblMaxAlarmCode";
            this.lblMaxAlarmCode.Size = new System.Drawing.Size(79, 43);
            this.lblMaxAlarmCode.TabIndex = 3;
            this.lblMaxAlarmCode.Text = "----";
            this.lblMaxAlarmCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlp4_FormsPlot
            // 
            this.tlp4_FormsPlot.ColumnCount = 2;
            this.tlp4_FormsPlot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp4_FormsPlot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp4_FormsPlot.Controls.Add(this.fpHourHistogram, 1, 1);
            this.tlp4_FormsPlot.Controls.Add(this.fpDailyTrend, 0, 1);
            this.tlp4_FormsPlot.Controls.Add(this.fpMachineBar, 1, 0);
            this.tlp4_FormsPlot.Controls.Add(this.fpCodeBar, 0, 0);
            this.tlp4_FormsPlot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp4_FormsPlot.Location = new System.Drawing.Point(0, 100);
            this.tlp4_FormsPlot.Name = "tlp4_FormsPlot";
            this.tlp4_FormsPlot.RowCount = 2;
            this.tlp4_FormsPlot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp4_FormsPlot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp4_FormsPlot.Size = new System.Drawing.Size(878, 473);
            this.tlp4_FormsPlot.TabIndex = 2;
            // 
            // fpCodeBar
            // 
            this.fpCodeBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpCodeBar.Location = new System.Drawing.Point(9, 6);
            this.fpCodeBar.Margin = new System.Windows.Forms.Padding(9, 6, 9, 6);
            this.fpCodeBar.Name = "fpCodeBar";
            this.fpCodeBar.Size = new System.Drawing.Size(421, 224);
            this.fpCodeBar.TabIndex = 0;
            // 
            // fpMachineBar
            // 
            this.fpMachineBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpMachineBar.Location = new System.Drawing.Point(455, 12);
            this.fpMachineBar.Margin = new System.Windows.Forms.Padding(16, 12, 16, 12);
            this.fpMachineBar.Name = "fpMachineBar";
            this.fpMachineBar.Size = new System.Drawing.Size(407, 212);
            this.fpMachineBar.TabIndex = 1;
            // 
            // fpDailyTrend
            // 
            this.fpDailyTrend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpDailyTrend.Location = new System.Drawing.Point(16, 248);
            this.fpDailyTrend.Margin = new System.Windows.Forms.Padding(16, 12, 16, 12);
            this.fpDailyTrend.Name = "fpDailyTrend";
            this.fpDailyTrend.Size = new System.Drawing.Size(407, 213);
            this.fpDailyTrend.TabIndex = 2;
            // 
            // fpHourHistogram
            // 
            this.fpHourHistogram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpHourHistogram.Location = new System.Drawing.Point(455, 248);
            this.fpHourHistogram.Margin = new System.Windows.Forms.Padding(16, 12, 16, 12);
            this.fpHourHistogram.Name = "fpHourHistogram";
            this.fpHourHistogram.Size = new System.Drawing.Size(407, 213);
            this.fpHourHistogram.TabIndex = 3;
            // 
            // tpl2_Operate
            // 
            this.tpl2_Operate.ColumnCount = 1;
            this.tpl2_Operate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpl2_Operate.Controls.Add(this.btnApply, 0, 3);
            this.tpl2_Operate.Controls.Add(this.panelDateFilter, 0, 0);
            this.tpl2_Operate.Controls.Add(this.panelMachines, 0, 1);
            this.tpl2_Operate.Controls.Add(this.gbWarnCode, 0, 2);
            this.tpl2_Operate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpl2_Operate.Location = new System.Drawing.Point(3, 34);
            this.tpl2_Operate.Name = "tpl2_Operate";
            this.tpl2_Operate.RowCount = 4;
            this.tpl2_Operate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tpl2_Operate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tpl2_Operate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpl2_Operate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tpl2_Operate.Size = new System.Drawing.Size(292, 596);
            this.tpl2_Operate.TabIndex = 15;
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
            this.panelDateFilter.Size = new System.Drawing.Size(286, 134);
            this.panelDateFilter.TabIndex = 13;
            // 
            // panelMachines
            // 
            this.panelMachines.Controls.Add(this.lblMachines);
            this.panelMachines.Controls.Add(this.btnMachinesClear);
            this.panelMachines.Controls.Add(this.clbMachines);
            this.panelMachines.Controls.Add(this.btnMachinesAll);
            this.panelMachines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMachines.Location = new System.Drawing.Point(3, 143);
            this.panelMachines.Name = "panelMachines";
            this.panelMachines.Size = new System.Drawing.Size(286, 294);
            this.panelMachines.TabIndex = 14;
            // 
            // dgvWareCode
            // 
            this.dgvWareCode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWareCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWareCode.Location = new System.Drawing.Point(3, 34);
            this.dgvWareCode.Name = "dgvWareCode";
            this.dgvWareCode.RowHeadersWidth = 51;
            this.dgvWareCode.RowTemplate.Height = 27;
            this.dgvWareCode.Size = new System.Drawing.Size(280, 63);
            this.dgvWareCode.TabIndex = 15;
            // 
            // gbWarnCode
            // 
            this.gbWarnCode.Controls.Add(this.dgvWareCode);
            this.gbWarnCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbWarnCode.Location = new System.Drawing.Point(3, 443);
            this.gbWarnCode.Name = "gbWarnCode";
            this.gbWarnCode.Size = new System.Drawing.Size(286, 100);
            this.gbWarnCode.TabIndex = 15;
            this.gbWarnCode.TabStop = false;
            this.gbWarnCode.Text = "Warn Code";
            // 
            // AlarmDashboardView2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelDashBoard);
            this.Controls.Add(this.tlp1_Left);
            this.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "AlarmDashboardView2";
            this.Size = new System.Drawing.Size(1182, 773);
            this.tlp1_Left.ResumeLayout(false);
            this.gbPaths.ResumeLayout(false);
            this.gbPaths.PerformLayout();
            this.gbOperate.ResumeLayout(false);
            this.panelDashBoard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlarmTable)).EndInit();
            this.tpl3_KPI.ResumeLayout(false);
            this.gbMaxAlarm.ResumeLayout(false);
            this.gbMaxAlarm.PerformLayout();
            this.gbTotalAlarms.ResumeLayout(false);
            this.gbTotalAlarms.PerformLayout();
            this.gbMaxMachine.ResumeLayout(false);
            this.gbMaxMachine.PerformLayout();
            this.tlp4_FormsPlot.ResumeLayout(false);
            this.tpl2_Operate.ResumeLayout(false);
            this.panelDateFilter.ResumeLayout(false);
            this.panelDateFilter.PerformLayout();
            this.panelMachines.ResumeLayout(false);
            this.panelMachines.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWareCode)).EndInit();
            this.gbWarnCode.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp1_Left;
        private System.Windows.Forms.GroupBox gbPaths;
        private System.Windows.Forms.Button btnBrowseFolder;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.GroupBox gbOperate;
        public System.Windows.Forms.DateTimePicker dtpFrom;
        public System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.CheckBox ckbDateRangeEnable;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Button btnMachinesAll;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Button btnMachinesClear;
        private System.Windows.Forms.CheckedListBox clbMachines;
        private System.Windows.Forms.Label lblMachines;
        private System.Windows.Forms.Panel panelDashBoard;
        private System.Windows.Forms.TableLayoutPanel tpl3_KPI;
        private System.Windows.Forms.GroupBox gbTotalAlarms;
        private System.Windows.Forms.GroupBox gbMaxAlarm;
        private System.Windows.Forms.Label lblMaxAlarmCodeTimes;
        private System.Windows.Forms.Label lblTotalAlarms;
        private System.Windows.Forms.DataGridView dgvAlarmTable;
        private System.Windows.Forms.GroupBox gbMaxMachine;
        private System.Windows.Forms.Label lblMaxMachine;
        private System.Windows.Forms.Label lblMaxAlarmCode;
        private System.Windows.Forms.TableLayoutPanel tlp4_FormsPlot;
        private ScottPlot.FormsPlot fpHourHistogram;
        private ScottPlot.FormsPlot fpDailyTrend;
        private ScottPlot.FormsPlot fpMachineBar;
        private ScottPlot.FormsPlot fpCodeBar;
        private System.Windows.Forms.TableLayoutPanel tpl2_Operate;
        private System.Windows.Forms.Panel panelDateFilter;
        private System.Windows.Forms.Panel panelMachines;
        private System.Windows.Forms.DataGridView dgvWareCode;
        private System.Windows.Forms.GroupBox gbWarnCode;
    }
}
