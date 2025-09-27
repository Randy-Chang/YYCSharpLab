namespace Project_LBTToolBox.Views
{
    partial class AlarmSettingsView
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

        #region 元件設計工具產生的程式碼 Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tlpRoot = new System.Windows.Forms.TableLayoutPanel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.gbIgnore = new System.Windows.Forms.GroupBox();
            this.txtIgnoreKeywords = new System.Windows.Forms.TextBox();
            this.gbMachines = new System.Windows.Forms.GroupBox();
            this.dgvMachineMap = new System.Windows.Forms.DataGridView();
            this.gbPaths = new System.Windows.Forms.GroupBox();
            this.lbPaths = new System.Windows.Forms.ListBox();
            this.flpPathBtns = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddPath = new System.Windows.Forms.Button();
            this.btnRemovePath = new System.Windows.Forms.Button();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.gbCodeRules = new System.Windows.Forms.GroupBox();
            this.dgvCodeRules = new System.Windows.Forms.DataGridView();
            this.pnlPreview = new System.Windows.Forms.Panel();
            this.flpPreview = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPreview = new System.Windows.Forms.Button();
            this.lblPreviewResult = new System.Windows.Forms.Label();
            this.txtPreviewInput = new System.Windows.Forms.TextBox();
            this.lblPreview = new System.Windows.Forms.Label();
            this.gbIngestion = new System.Windows.Forms.GroupBox();
            this.chkDeduplicate = new System.Windows.Forms.CheckBox();
            this.chkIncremental = new System.Windows.Forms.CheckBox();
            this.chkSaveOnlyWarn = new System.Windows.Forms.CheckBox();
            this.flpOps = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRebuildDb = new System.Windows.Forms.Button();
            this.btnRescanIncremental = new System.Windows.Forms.Button();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.statusSettings = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpRoot.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.gbIgnore.SuspendLayout();
            this.gbMachines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMachineMap)).BeginInit();
            this.gbPaths.SuspendLayout();
            this.flpPathBtns.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.gbCodeRules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCodeRules)).BeginInit();
            this.pnlPreview.SuspendLayout();
            this.flpPreview.SuspendLayout();
            this.gbIngestion.SuspendLayout();
            this.flpOps.SuspendLayout();
            this.statusSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpRoot
            // 
            this.tlpRoot.ColumnCount = 2;
            this.tlpRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tlpRoot.Controls.Add(this.pnlLeft, 0, 0);
            this.tlpRoot.Controls.Add(this.pnlRight, 1, 0);
            this.tlpRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRoot.Location = new System.Drawing.Point(0, 0);
            this.tlpRoot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tlpRoot.Name = "tlpRoot";
            this.tlpRoot.RowCount = 1;
            this.tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRoot.Size = new System.Drawing.Size(1182, 773);
            this.tlpRoot.TabIndex = 0;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.gbIgnore);
            this.pnlLeft.Controls.Add(this.gbMachines);
            this.pnlLeft.Controls.Add(this.gbPaths);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeft.Location = new System.Drawing.Point(4, 4);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(11, 11, 11, 11);
            this.pnlLeft.Size = new System.Drawing.Size(405, 765);
            this.pnlLeft.TabIndex = 0;
            // 
            // gbIgnore
            // 
            this.gbIgnore.Controls.Add(this.txtIgnoreKeywords);
            this.gbIgnore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbIgnore.Location = new System.Drawing.Point(11, 451);
            this.gbIgnore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbIgnore.Name = "gbIgnore";
            this.gbIgnore.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbIgnore.Size = new System.Drawing.Size(383, 303);
            this.gbIgnore.TabIndex = 2;
            this.gbIgnore.TabStop = false;
            this.gbIgnore.Text = "忽略關鍵字（每行一個）";
            // 
            // txtIgnoreKeywords
            // 
            this.txtIgnoreKeywords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtIgnoreKeywords.Location = new System.Drawing.Point(4, 27);
            this.txtIgnoreKeywords.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIgnoreKeywords.Multiline = true;
            this.txtIgnoreKeywords.Name = "txtIgnoreKeywords";
            this.txtIgnoreKeywords.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtIgnoreKeywords.Size = new System.Drawing.Size(375, 272);
            this.txtIgnoreKeywords.TabIndex = 0;
            // 
            // gbMachines
            // 
            this.gbMachines.Controls.Add(this.dgvMachineMap);
            this.gbMachines.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbMachines.Location = new System.Drawing.Point(11, 231);
            this.gbMachines.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbMachines.Name = "gbMachines";
            this.gbMachines.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.gbMachines.Size = new System.Drawing.Size(383, 220);
            this.gbMachines.TabIndex = 1;
            this.gbMachines.TabStop = false;
            this.gbMachines.Text = "機台代號對照";
            // 
            // dgvMachineMap
            // 
            this.dgvMachineMap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMachineMap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMachineMap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvMachineMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMachineMap.Location = new System.Drawing.Point(6, 30);
            this.dgvMachineMap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMachineMap.Name = "dgvMachineMap";
            this.dgvMachineMap.RowHeadersVisible = false;
            this.dgvMachineMap.RowHeadersWidth = 51;
            this.dgvMachineMap.RowTemplate.Height = 25;
            this.dgvMachineMap.Size = new System.Drawing.Size(371, 183);
            this.dgvMachineMap.TabIndex = 0;
            // 
            // gbPaths
            // 
            this.gbPaths.Controls.Add(this.lbPaths);
            this.gbPaths.Controls.Add(this.flpPathBtns);
            this.gbPaths.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbPaths.Location = new System.Drawing.Point(11, 11);
            this.gbPaths.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbPaths.Name = "gbPaths";
            this.gbPaths.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbPaths.Size = new System.Drawing.Size(383, 220);
            this.gbPaths.TabIndex = 0;
            this.gbPaths.TabStop = false;
            this.gbPaths.Text = "Log 路徑";
            // 
            // lbPaths
            // 
            this.lbPaths.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPaths.FormattingEnabled = true;
            this.lbPaths.ItemHeight = 22;
            this.lbPaths.Location = new System.Drawing.Point(4, 27);
            this.lbPaths.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbPaths.Name = "lbPaths";
            this.lbPaths.Size = new System.Drawing.Size(375, 147);
            this.lbPaths.TabIndex = 0;
            // 
            // flpPathBtns
            // 
            this.flpPathBtns.Controls.Add(this.btnAddPath);
            this.flpPathBtns.Controls.Add(this.btnRemovePath);
            this.flpPathBtns.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpPathBtns.Location = new System.Drawing.Point(4, 174);
            this.flpPathBtns.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flpPathBtns.Name = "flpPathBtns";
            this.flpPathBtns.Size = new System.Drawing.Size(375, 42);
            this.flpPathBtns.TabIndex = 1;
            // 
            // btnAddPath
            // 
            this.btnAddPath.Location = new System.Drawing.Point(4, 4);
            this.btnAddPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddPath.Name = "btnAddPath";
            this.btnAddPath.Size = new System.Drawing.Size(109, 35);
            this.btnAddPath.TabIndex = 0;
            this.btnAddPath.Text = "新增路徑…";
            this.btnAddPath.UseVisualStyleBackColor = true;
            // 
            // btnRemovePath
            // 
            this.btnRemovePath.Location = new System.Drawing.Point(121, 4);
            this.btnRemovePath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemovePath.Name = "btnRemovePath";
            this.btnRemovePath.Size = new System.Drawing.Size(91, 35);
            this.btnRemovePath.TabIndex = 1;
            this.btnRemovePath.Text = "移除";
            this.btnRemovePath.UseVisualStyleBackColor = true;
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.gbCodeRules);
            this.pnlRight.Controls.Add(this.pnlPreview);
            this.pnlRight.Controls.Add(this.gbIngestion);
            this.pnlRight.Controls.Add(this.statusSettings);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(417, 4);
            this.pnlRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Padding = new System.Windows.Forms.Padding(11, 11, 11, 11);
            this.pnlRight.Size = new System.Drawing.Size(761, 765);
            this.pnlRight.TabIndex = 1;
            // 
            // gbCodeRules
            // 
            this.gbCodeRules.Controls.Add(this.dgvCodeRules);
            this.gbCodeRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCodeRules.Location = new System.Drawing.Point(11, 11);
            this.gbCodeRules.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbCodeRules.Name = "gbCodeRules";
            this.gbCodeRules.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbCodeRules.Size = new System.Drawing.Size(739, 445);
            this.gbCodeRules.TabIndex = 0;
            this.gbCodeRules.TabStop = false;
            this.gbCodeRules.Text = "警報代碼規則（關鍵字→代碼）";
            // 
            // dgvCodeRules
            // 
            this.dgvCodeRules.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCodeRules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCodeRules.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvCodeRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCodeRules.Location = new System.Drawing.Point(4, 27);
            this.dgvCodeRules.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCodeRules.Name = "dgvCodeRules";
            this.dgvCodeRules.RowHeadersVisible = false;
            this.dgvCodeRules.RowHeadersWidth = 51;
            this.dgvCodeRules.RowTemplate.Height = 25;
            this.dgvCodeRules.Size = new System.Drawing.Size(731, 414);
            this.dgvCodeRules.TabIndex = 0;
            // 
            // pnlPreview
            // 
            this.pnlPreview.Controls.Add(this.flpPreview);
            this.pnlPreview.Controls.Add(this.txtPreviewInput);
            this.pnlPreview.Controls.Add(this.lblPreview);
            this.pnlPreview.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPreview.Location = new System.Drawing.Point(11, 456);
            this.pnlPreview.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlPreview.Name = "pnlPreview";
            this.pnlPreview.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlPreview.Size = new System.Drawing.Size(739, 99);
            this.pnlPreview.TabIndex = 1;
            // 
            // flpPreview
            // 
            this.flpPreview.Controls.Add(this.btnPreview);
            this.flpPreview.Controls.Add(this.lblPreviewResult);
            this.flpPreview.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpPreview.Location = new System.Drawing.Point(6, 56);
            this.flpPreview.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flpPreview.Name = "flpPreview";
            this.flpPreview.Size = new System.Drawing.Size(727, 37);
            this.flpPreview.TabIndex = 2;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(4, 4);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(89, 33);
            this.btnPreview.TabIndex = 0;
            this.btnPreview.Text = "測試";
            this.btnPreview.UseVisualStyleBackColor = true;
            // 
            // lblPreviewResult
            // 
            this.lblPreviewResult.AutoSize = true;
            this.lblPreviewResult.Location = new System.Drawing.Point(99, 7);
            this.lblPreviewResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPreviewResult.Name = "lblPreviewResult";
            this.lblPreviewResult.Size = new System.Drawing.Size(100, 18);
            this.lblPreviewResult.TabIndex = 1;
            this.lblPreviewResult.Text = "結果：—";
            // 
            // txtPreviewInput
            // 
            this.txtPreviewInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPreviewInput.Location = new System.Drawing.Point(6, 28);
            this.txtPreviewInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPreviewInput.Name = "txtPreviewInput";
            this.txtPreviewInput.Size = new System.Drawing.Size(727, 30);
            this.txtPreviewInput.TabIndex = 1;
            // 
            // lblPreview
            // 
            this.lblPreview.AutoSize = true;
            this.lblPreview.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPreview.Location = new System.Drawing.Point(6, 6);
            this.lblPreview.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(181, 22);
            this.lblPreview.TabIndex = 0;
            this.lblPreview.Text = "預覽測試：貼一行 Log";
            // 
            // gbIngestion
            // 
            this.gbIngestion.Controls.Add(this.chkDeduplicate);
            this.gbIngestion.Controls.Add(this.chkIncremental);
            this.gbIngestion.Controls.Add(this.chkSaveOnlyWarn);
            this.gbIngestion.Controls.Add(this.flpOps);
            this.gbIngestion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbIngestion.Location = new System.Drawing.Point(11, 555);
            this.gbIngestion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbIngestion.Name = "gbIngestion";
            this.gbIngestion.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbIngestion.Size = new System.Drawing.Size(739, 174);
            this.gbIngestion.TabIndex = 2;
            this.gbIngestion.TabStop = false;
            this.gbIngestion.Text = "匯入策略與操作";
            // 
            // chkDeduplicate
            // 
            this.chkDeduplicate.AutoSize = true;
            this.chkDeduplicate.Checked = true;
            this.chkDeduplicate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDeduplicate.Location = new System.Drawing.Point(20, 97);
            this.chkDeduplicate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkDeduplicate.Name = "chkDeduplicate";
            this.chkDeduplicate.Size = new System.Drawing.Size(219, 26);
            this.chkDeduplicate.TabIndex = 3;
            this.chkDeduplicate.Text = "避免重覆寫入（建議開）";
            this.chkDeduplicate.UseVisualStyleBackColor = true;
            // 
            // chkIncremental
            // 
            this.chkIncremental.AutoSize = true;
            this.chkIncremental.Checked = true;
            this.chkIncremental.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIncremental.Location = new System.Drawing.Point(20, 68);
            this.chkIncremental.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkIncremental.Name = "chkIncremental";
            this.chkIncremental.Size = new System.Drawing.Size(236, 26);
            this.chkIncremental.TabIndex = 2;
            this.chkIncremental.Text = "增量更新（只吃新增內容）";
            this.chkIncremental.UseVisualStyleBackColor = true;
            // 
            // chkSaveOnlyWarn
            // 
            this.chkSaveOnlyWarn.AutoSize = true;
            this.chkSaveOnlyWarn.Checked = true;
            this.chkSaveOnlyWarn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSaveOnlyWarn.Location = new System.Drawing.Point(20, 37);
            this.chkSaveOnlyWarn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkSaveOnlyWarn.Name = "chkSaveOnlyWarn";
            this.chkSaveOnlyWarn.Size = new System.Drawing.Size(141, 26);
            this.chkSaveOnlyWarn.TabIndex = 1;
            this.chkSaveOnlyWarn.Text = "僅儲存 WARN";
            this.chkSaveOnlyWarn.UseVisualStyleBackColor = true;
            // 
            // flpOps
            // 
            this.flpOps.Controls.Add(this.btnRebuildDb);
            this.flpOps.Controls.Add(this.btnRescanIncremental);
            this.flpOps.Controls.Add(this.btnSaveSettings);
            this.flpOps.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpOps.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpOps.Location = new System.Drawing.Point(4, 124);
            this.flpOps.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flpOps.Name = "flpOps";
            this.flpOps.Size = new System.Drawing.Size(731, 46);
            this.flpOps.TabIndex = 0;
            // 
            // btnRebuildDb
            // 
            this.btnRebuildDb.Location = new System.Drawing.Point(621, 4);
            this.btnRebuildDb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRebuildDb.Name = "btnRebuildDb";
            this.btnRebuildDb.Size = new System.Drawing.Size(106, 35);
            this.btnRebuildDb.TabIndex = 2;
            this.btnRebuildDb.Text = "重建資料庫";
            this.btnRebuildDb.UseVisualStyleBackColor = true;
            // 
            // btnRescanIncremental
            // 
            this.btnRescanIncremental.Location = new System.Drawing.Point(507, 4);
            this.btnRescanIncremental.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRescanIncremental.Name = "btnRescanIncremental";
            this.btnRescanIncremental.Size = new System.Drawing.Size(106, 35);
            this.btnRescanIncremental.TabIndex = 1;
            this.btnRescanIncremental.Text = "重新掃描";
            this.btnRescanIncremental.UseVisualStyleBackColor = true;
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(393, 4);
            this.btnSaveSettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(106, 35);
            this.btnSaveSettings.TabIndex = 0;
            this.btnSaveSettings.Text = "儲存設定";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            // 
            // statusSettings
            // 
            this.statusSettings.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusSettings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusSettings.Location = new System.Drawing.Point(11, 729);
            this.statusSettings.Name = "statusSettings";
            this.statusSettings.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusSettings.Size = new System.Drawing.Size(739, 25);
            this.statusSettings.SizingGrip = false;
            this.statusSettings.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(39, 19);
            this.lblStatus.Text = "就緒";
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
            // AlarmSettingsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpRoot);
            this.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AlarmSettingsView";
            this.Size = new System.Drawing.Size(1182, 773);
            this.tlpRoot.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.gbIgnore.ResumeLayout(false);
            this.gbIgnore.PerformLayout();
            this.gbMachines.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMachineMap)).EndInit();
            this.gbPaths.ResumeLayout(false);
            this.flpPathBtns.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.gbCodeRules.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCodeRules)).EndInit();
            this.pnlPreview.ResumeLayout(false);
            this.pnlPreview.PerformLayout();
            this.flpPreview.ResumeLayout(false);
            this.flpPreview.PerformLayout();
            this.gbIngestion.ResumeLayout(false);
            this.gbIngestion.PerformLayout();
            this.flpOps.ResumeLayout(false);
            this.statusSettings.ResumeLayout(false);
            this.statusSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpRoot;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.GroupBox gbIgnore;
        public System.Windows.Forms.TextBox txtIgnoreKeywords;
        private System.Windows.Forms.GroupBox gbMachines;
        public System.Windows.Forms.DataGridView dgvMachineMap;
        private System.Windows.Forms.GroupBox gbPaths;
        public System.Windows.Forms.ListBox lbPaths;
        private System.Windows.Forms.FlowLayoutPanel flpPathBtns;
        public System.Windows.Forms.Button btnAddPath;
        public System.Windows.Forms.Button btnRemovePath;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.GroupBox gbCodeRules;
        public System.Windows.Forms.DataGridView dgvCodeRules;
        private System.Windows.Forms.Panel pnlPreview;
        private System.Windows.Forms.FlowLayoutPanel flpPreview;
        public System.Windows.Forms.Button btnPreview;
        public System.Windows.Forms.Label lblPreviewResult;
        public System.Windows.Forms.TextBox txtPreviewInput;
        private System.Windows.Forms.Label lblPreview;
        private System.Windows.Forms.GroupBox gbIngestion;
        public System.Windows.Forms.CheckBox chkDeduplicate;
        public System.Windows.Forms.CheckBox chkIncremental;
        public System.Windows.Forms.CheckBox chkSaveOnlyWarn;
        private System.Windows.Forms.FlowLayoutPanel flpOps;
        public System.Windows.Forms.Button btnRebuildDb;
        public System.Windows.Forms.Button btnRescanIncremental;
        public System.Windows.Forms.Button btnSaveSettings;
        public System.Windows.Forms.StatusStrip statusSettings;
        public System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}
