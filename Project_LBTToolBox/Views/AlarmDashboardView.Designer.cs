namespace Project_LBTToolBox.Views
{
    partial class AlarmDashboardView
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

        #region Designer code

        private void InitializeComponent()
        {
            this.tlpDash = new System.Windows.Forms.TableLayoutPanel();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.tlpFilter = new System.Windows.Forms.TableLayoutPanel();
            this.flpTop = new System.Windows.Forms.FlowLayoutPanel();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cboLevel = new System.Windows.Forms.ComboBox();
            this.btnApplyFilters = new System.Windows.Forms.Button();
            this.btnResetFilters = new System.Windows.Forms.Button();
            this.flpRight = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRescanQuick = new System.Windows.Forms.Button();
            this.btnExportCsv = new System.Windows.Forms.Button();
            this.flpBottom = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlMachines = new System.Windows.Forms.Panel();
            this.clbMachines = new System.Windows.Forms.CheckedListBox();
            this.lblMachines = new System.Windows.Forms.Label();
            this.pnlCodes = new System.Windows.Forms.Panel();
            this.clbAlarmCodes = new System.Windows.Forms.CheckedListBox();
            this.lblCodes = new System.Windows.Forms.Label();
            this.splitCharts = new System.Windows.Forms.SplitContainer();
            this.splitLeft = new System.Windows.Forms.SplitContainer();
            this.gbByMachine = new System.Windows.Forms.GroupBox();
            this.fpByMachine = new ScottPlot.WinForms.FormsPlot();
            this.gbByCode = new System.Windows.Forms.GroupBox();
            this.fpByCode = new ScottPlot.WinForms.FormsPlot();
            this.gbTrend = new System.Windows.Forms.GroupBox();
            this.fpTrend = new ScottPlot.WinForms.FormsPlot();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpDash.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            this.tlpFilter.SuspendLayout();
            this.flpTop.SuspendLayout();
            this.flpRight.SuspendLayout();
            this.flpBottom.SuspendLayout();
            this.pnlMachines.SuspendLayout();
            this.pnlCodes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitCharts)).BeginInit();
            this.splitCharts.Panel1.SuspendLayout();
            this.splitCharts.Panel2.SuspendLayout();
            this.splitCharts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitLeft)).BeginInit();
            this.splitLeft.Panel1.SuspendLayout();
            this.splitLeft.Panel2.SuspendLayout();
            this.splitLeft.SuspendLayout();
            this.gbByMachine.SuspendLayout();
            this.gbByCode.SuspendLayout();
            this.gbTrend.SuspendLayout();
            this.gbDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpDash
            // 
            this.tlpDash.ColumnCount = 1;
            this.tlpDash.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDash.Controls.Add(this.pnlFilter, 0, 0);
            this.tlpDash.Controls.Add(this.splitCharts, 0, 1);
            this.tlpDash.Controls.Add(this.gbDetails, 0, 2);
            this.tlpDash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDash.Location = new System.Drawing.Point(0, 0);
            this.tlpDash.Name = "tlpDash";
            this.tlpDash.RowCount = 3;
            this.tlpDash.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDash.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDash.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDash.Size = new System.Drawing.Size(1200, 800);
            this.tlpDash.TabIndex = 0;
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.tlpFilter);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.Location = new System.Drawing.Point(3, 3);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Padding = new System.Windows.Forms.Padding(8);
            this.pnlFilter.Size = new System.Drawing.Size(1194, 110);
            this.pnlFilter.TabIndex = 0;
            // 
            // tlpFilter
            // 
            this.tlpFilter.ColumnCount = 1;
            this.tlpFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFilter.Controls.Add(this.flpTop, 0, 0);
            this.tlpFilter.Controls.Add(this.flpBottom, 0, 1);
            this.tlpFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFilter.Location = new System.Drawing.Point(8, 8);
            this.tlpFilter.Name = "tlpFilter";
            this.tlpFilter.RowCount = 2;
            this.tlpFilter.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFilter.Size = new System.Drawing.Size(1178, 94);
            this.tlpFilter.TabIndex = 0;
            // 
            // flpTop
            // 
            this.flpTop.Controls.Add(this.lblFrom);
            this.flpTop.Controls.Add(this.dtpFrom);
            this.flpTop.Controls.Add(this.lblTo);
            this.flpTop.Controls.Add(this.dtpTo);
            this.flpTop.Controls.Add(this.txtSearch);
            this.flpTop.Controls.Add(this.cboLevel);
            this.flpTop.Controls.Add(this.btnApplyFilters);
            this.flpTop.Controls.Add(this.btnResetFilters);
            this.flpTop.Controls.Add(this.flpRight);
            this.flpTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpTop.Location = new System.Drawing.Point(3, 3);
            this.flpTop.Name = "flpTop";
            this.flpTop.Size = new System.Drawing.Size(1172, 32);
            this.flpTop.TabIndex = 0;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(3, 6);
            this.lblFrom.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(24, 19);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "起";
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "yyyy-MM-dd";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(33, 3);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(120, 27);
            this.dtpFrom.TabIndex = 1;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(159, 6);
            this.lblTo.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(24, 19);
            this.lblTo.TabIndex = 2;
            this.lblTo.Text = "迄";
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "yyyy-MM-dd";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(189, 3);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(120, 27);
            this.dtpTo.TabIndex = 3;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(315, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(220, 27);
            this.txtSearch.TabIndex = 4;
            // 
            // cboLevel
            // 
            this.cboLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLevel.FormattingEnabled = true;
            this.cboLevel.Items.AddRange(new object[] {
            "WARN",
            "ERROR",
            "INFO",
            "ALL"});
            this.cboLevel.Location = new System.Drawing.Point(541, 3);
            this.cboLevel.Name = "cboLevel";
            this.cboLevel.Size = new System.Drawing.Size(90, 27);
            this.cboLevel.TabIndex = 5;
            // 
            // btnApplyFilters
            // 
            this.btnApplyFilters.Location = new System.Drawing.Point(637, 3);
            this.btnApplyFilters.Name = "btnApplyFilters";
            this.btnApplyFilters.Size = new System.Drawing.Size(70, 26);
            this.btnApplyFilters.TabIndex = 6;
            this.btnApplyFilters.Text = "套用";
            this.btnApplyFilters.UseVisualStyleBackColor = true;
            // 
            // btnResetFilters
            // 
            this.btnResetFilters.Location = new System.Drawing.Point(713, 3);
            this.btnResetFilters.Name = "btnResetFilters";
            this.btnResetFilters.Size = new System.Drawing.Size(70, 26);
            this.btnResetFilters.TabIndex = 7;
            this.btnResetFilters.Text = "重置";
            this.btnResetFilters.UseVisualStyleBackColor = true;
            // 
            // flpRight
            // 
            this.flpRight.Controls.Add(this.btnRescanQuick);
            this.flpRight.Controls.Add(this.btnExportCsv);
            this.flpRight.Location = new System.Drawing.Point(789, 3);
            this.flpRight.Name = "flpRight";
            this.flpRight.Size = new System.Drawing.Size(200, 26);
            this.flpRight.TabIndex = 8;
            // 
            // btnRescanQuick
            // 
            this.btnRescanQuick.Location = new System.Drawing.Point(3, 3);
            this.btnRescanQuick.Name = "btnRescanQuick";
            this.btnRescanQuick.Size = new System.Drawing.Size(82, 23);
            this.btnRescanQuick.TabIndex = 0;
            this.btnRescanQuick.Text = "重新掃描";
            this.btnRescanQuick.UseVisualStyleBackColor = true;
            // 
            // btnExportCsv
            // 
            this.btnExportCsv.Location = new System.Drawing.Point(91, 3);
            this.btnExportCsv.Name = "btnExportCsv";
            this.btnExportCsv.Size = new System.Drawing.Size(82, 23);
            this.btnExportCsv.TabIndex = 1;
            this.btnExportCsv.Text = "匯出CSV";
            this.btnExportCsv.UseVisualStyleBackColor = true;
            // 
            // flpBottom
            // 
            this.flpBottom.Controls.Add(this.pnlMachines);
            this.flpBottom.Controls.Add(this.pnlCodes);
            this.flpBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpBottom.Location = new System.Drawing.Point(3, 41);
            this.flpBottom.Name = "flpBottom";
            this.flpBottom.Size = new System.Drawing.Size(1172, 50);
            this.flpBottom.TabIndex = 1;
            // 
            // pnlMachines
            // 
            this.pnlMachines.Controls.Add(this.clbMachines);
            this.pnlMachines.Controls.Add(this.lblMachines);
            this.pnlMachines.Location = new System.Drawing.Point(3, 3);
            this.pnlMachines.Name = "pnlMachines";
            this.pnlMachines.Size = new System.Drawing.Size(350, 45);
            this.pnlMachines.TabIndex = 0;
            // 
            // clbMachines
            // 
            this.clbMachines.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.clbMachines.FormattingEnabled = true;
            this.clbMachines.Location = new System.Drawing.Point(0, 19);
            this.clbMachines.Name = "clbMachines";
            this.clbMachines.Size = new System.Drawing.Size(350, 26);
            this.clbMachines.TabIndex = 1;
            // 
            // lblMachines
            // 
            this.lblMachines.AutoSize = true;
            this.lblMachines.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMachines.Location = new System.Drawing.Point(0, 0);
            this.lblMachines.Name = "lblMachines";
            this.lblMachines.Size = new System.Drawing.Size(39, 19);
            this.lblMachines.TabIndex = 0;
            this.lblMachines.Text = "機台";
            // 
            // pnlCodes
            // 
            this.pnlCodes.Controls.Add(this.clbAlarmCodes);
            this.pnlCodes.Controls.Add(this.lblCodes);
            this.pnlCodes.Location = new System.Drawing.Point(359, 3);
            this.pnlCodes.Name = "pnlCodes";
            this.pnlCodes.Size = new System.Drawing.Size(500, 45);
            this.pnlCodes.TabIndex = 1;
            // 
            // clbAlarmCodes
            // 
            this.clbAlarmCodes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.clbAlarmCodes.FormattingEnabled = true;
            this.clbAlarmCodes.Location = new System.Drawing.Point(0, 19);
            this.clbAlarmCodes.Name = "clbAlarmCodes";
            this.clbAlarmCodes.Size = new System.Drawing.Size(500, 26);
            this.clbAlarmCodes.TabIndex = 1;
            // 
            // lblCodes
            // 
            this.lblCodes.AutoSize = true;
            this.lblCodes.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCodes.Location = new System.Drawing.Point(0, 0);
            this.lblCodes.Name = "lblCodes";
            this.lblCodes.Size = new System.Drawing.Size(69, 19);
            this.lblCodes.TabIndex = 0;
            this.lblCodes.Text = "警報代碼";
            // 
            // splitCharts
            // 
            this.splitCharts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitCharts.Location = new System.Drawing.Point(3, 119);
            this.splitCharts.Name = "splitCharts";
            // 
            // splitCharts.Panel1
            // 
            this.splitCharts.Panel1.Controls.Add(this.splitLeft);
            // 
            // splitCharts.Panel2
            // 
            this.splitCharts.Panel2.Controls.Add(this.gbTrend);
            this.splitCharts.Size = new System.Drawing.Size(1194, 336);
            this.splitCharts.SplitterDistance = 650;
            this.splitCharts.TabIndex = 1;
            // 
            // splitLeft
            // 
            this.splitLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitLeft.Location = new System.Drawing.Point(0, 0);
            this.splitLeft.Name = "splitLeft";
            this.splitLeft.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitLeft.Panel1
            // 
            this.splitLeft.Panel1.Controls.Add(this.gbByMachine);
            // 
            // splitLeft.Panel2
            // 
            this.splitLeft.Panel2.Controls.Add(this.gbByCode);
            this.splitLeft.Size = new System.Drawing.Size(650, 336);
            this.splitLeft.SplitterDistance = 164;
            this.splitLeft.TabIndex = 0;
            // 
            // gbByMachine
            // 
            this.gbByMachine.Controls.Add(this.fpByMachine);
            this.gbByMachine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbByMachine.Location = new System.Drawing.Point(0, 0);
            this.gbByMachine.Name = "gbByMachine";
            this.gbByMachine.Padding = new System.Windows.Forms.Padding(6);
            this.gbByMachine.Size = new System.Drawing.Size(650, 164);
            this.gbByMachine.TabIndex = 0;
            this.gbByMachine.TabStop = false;
            this.gbByMachine.Text = "各機台 WARN 次數";
            // 
            // fpByMachine
            // 
            this.fpByMachine.DisplayScale = 0F;
            this.fpByMachine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpByMachine.Location = new System.Drawing.Point(6, 26);
            this.fpByMachine.Name = "fpByMachine";
            this.fpByMachine.Size = new System.Drawing.Size(638, 132);
            this.fpByMachine.TabIndex = 0;
            // 
            // gbByCode
            // 
            this.gbByCode.Controls.Add(this.fpByCode);
            this.gbByCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbByCode.Location = new System.Drawing.Point(0, 0);
            this.gbByCode.Name = "gbByCode";
            this.gbByCode.Padding = new System.Windows.Forms.Padding(6);
            this.gbByCode.Size = new System.Drawing.Size(650, 168);
            this.gbByCode.TabIndex = 0;
            this.gbByCode.TabStop = false;
            this.gbByCode.Text = "各警報代碼 WARN 次數";
            // 
            // fpByCode
            // 
            this.fpByCode.DisplayScale = 0F;
            this.fpByCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpByCode.Location = new System.Drawing.Point(6, 26);
            this.fpByCode.Name = "fpByCode";
            this.fpByCode.Size = new System.Drawing.Size(638, 136);
            this.fpByCode.TabIndex = 0;
            // 
            // gbTrend
            // 
            this.gbTrend.Controls.Add(this.fpTrend);
            this.gbTrend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTrend.Location = new System.Drawing.Point(0, 0);
            this.gbTrend.Name = "gbTrend";
            this.gbTrend.Padding = new System.Windows.Forms.Padding(6);
            this.gbTrend.Size = new System.Drawing.Size(540, 336);
            this.gbTrend.TabIndex = 0;
            this.gbTrend.TabStop = false;
            this.gbTrend.Text = "每日 WARN 趨勢";
            // 
            // fpTrend
            // 
            this.fpTrend.DisplayScale = 0F;
            this.fpTrend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpTrend.Location = new System.Drawing.Point(6, 26);
            this.fpTrend.Name = "fpTrend";
            this.fpTrend.Size = new System.Drawing.Size(528, 304);
            this.fpTrend.TabIndex = 0;
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.dgvDetails);
            this.gbDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDetails.Location = new System.Drawing.Point(3, 461);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Padding = new System.Windows.Forms.Padding(6);
            this.gbDetails.Size = new System.Drawing.Size(1194, 336);
            this.gbDetails.TabIndex = 2;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "明細";
            // 
            // dgvDetails
            // 
            this.dgvDetails.AllowUserToOrderColumns = true;
            this.dgvDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetails.Location = new System.Drawing.Point(6, 26);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.RowHeadersVisible = false;
            this.dgvDetails.RowHeadersWidth = 51;
            this.dgvDetails.RowTemplate.Height = 25;
            this.dgvDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetails.Size = new System.Drawing.Size(1182, 304);
            this.dgvDetails.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // AlarmDashboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpDash);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.Name = "AlarmDashboardView";
            this.Size = new System.Drawing.Size(1200, 800);
            this.tlpDash.ResumeLayout(false);
            this.pnlFilter.ResumeLayout(false);
            this.tlpFilter.ResumeLayout(false);
            this.flpTop.ResumeLayout(false);
            this.flpTop.PerformLayout();
            this.flpRight.ResumeLayout(false);
            this.flpBottom.ResumeLayout(false);
            this.pnlMachines.ResumeLayout(false);
            this.pnlMachines.PerformLayout();
            this.pnlCodes.ResumeLayout(false);
            this.pnlCodes.PerformLayout();
            this.splitCharts.Panel1.ResumeLayout(false);
            this.splitCharts.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitCharts)).EndInit();
            this.splitCharts.ResumeLayout(false);
            this.splitLeft.Panel1.ResumeLayout(false);
            this.splitLeft.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitLeft)).EndInit();
            this.splitLeft.ResumeLayout(false);
            this.gbByMachine.ResumeLayout(false);
            this.gbByCode.ResumeLayout(false);
            this.gbTrend.ResumeLayout(false);
            this.gbDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpDash;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.TableLayoutPanel tlpFilter;
        private System.Windows.Forms.FlowLayoutPanel flpTop;
        private System.Windows.Forms.Label lblFrom;
        public System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblTo;
        public System.Windows.Forms.DateTimePicker dtpTo;
        public System.Windows.Forms.TextBox txtSearch;
        public System.Windows.Forms.ComboBox cboLevel;
        public System.Windows.Forms.Button btnApplyFilters;
        public System.Windows.Forms.Button btnResetFilters;
        private System.Windows.Forms.FlowLayoutPanel flpRight;
        public System.Windows.Forms.Button btnRescanQuick;
        public System.Windows.Forms.Button btnExportCsv;
        private System.Windows.Forms.FlowLayoutPanel flpBottom;
        private System.Windows.Forms.Panel pnlMachines;
        private System.Windows.Forms.Label lblMachines;
        public System.Windows.Forms.CheckedListBox clbMachines;
        private System.Windows.Forms.Panel pnlCodes;
        private System.Windows.Forms.Label lblCodes;
        public System.Windows.Forms.CheckedListBox clbAlarmCodes;
        private System.Windows.Forms.SplitContainer splitCharts;
        private System.Windows.Forms.SplitContainer splitLeft;
        private System.Windows.Forms.GroupBox gbByMachine;
        public ScottPlot.WinForms.FormsPlot fpByMachine;
        private System.Windows.Forms.GroupBox gbByCode;
        public ScottPlot.WinForms.FormsPlot fpByCode;
        private System.Windows.Forms.GroupBox gbTrend;
        public ScottPlot.WinForms.FormsPlot fpTrend;
        private System.Windows.Forms.GroupBox gbDetails;
        public System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}
