using System.Drawing;
using System.Windows.Forms;

namespace Project_LBTToolBox.Views.Alarms
{
    partial class AlarmSettingsView
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private TableLayoutPanel tlpRoot, leftCol, rightCol;

        private GroupBox gbPaths; public ListBox lbPaths; public Button btnAddPath, btnRemovePath;
        private GroupBox gbMachines; public DataGridView dgvMachineMap;
        private GroupBox gbIgnore; public TextBox txtIgnore;

        private GroupBox gbRules; public DataGridView dgvRules;
        private GroupBox gbOps; public CheckBox chkWarnOnly, chkIncremental, chkDedup;
        public Button btnSave, btnRescan, btnRebuild;

        private void InitializeComponent()
        {
            this.tlpRoot = new System.Windows.Forms.TableLayoutPanel();
            this.leftCol = new System.Windows.Forms.TableLayoutPanel();
            this.gbPaths = new System.Windows.Forms.GroupBox();
            this.lbPaths = new System.Windows.Forms.ListBox();
            this.btnAddPath = new System.Windows.Forms.Button();
            this.btnRemovePath = new System.Windows.Forms.Button();
            this.gbMachines = new System.Windows.Forms.GroupBox();
            this.dgvMachineMap = new System.Windows.Forms.DataGridView();
            this.gbIgnore = new System.Windows.Forms.GroupBox();
            this.txtIgnore = new System.Windows.Forms.TextBox();
            this.rightCol = new System.Windows.Forms.TableLayoutPanel();
            this.gbRules = new System.Windows.Forms.GroupBox();
            this.dgvRules = new System.Windows.Forms.DataGridView();
            this.gbOps = new System.Windows.Forms.GroupBox();
            this.chkWarnOnly = new System.Windows.Forms.CheckBox();
            this.chkIncremental = new System.Windows.Forms.CheckBox();
            this.chkDedup = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRescan = new System.Windows.Forms.Button();
            this.btnRebuild = new System.Windows.Forms.Button();
            this.tlpRoot.SuspendLayout();
            this.leftCol.SuspendLayout();
            this.gbPaths.SuspendLayout();
            this.gbMachines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMachineMap)).BeginInit();
            this.gbIgnore.SuspendLayout();
            this.rightCol.SuspendLayout();
            this.gbRules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRules)).BeginInit();
            this.gbOps.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpRoot
            // 
            this.tlpRoot.ColumnCount = 2;
            this.tlpRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.tlpRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62F));
            this.tlpRoot.Controls.Add(this.leftCol, 0, 0);
            this.tlpRoot.Controls.Add(this.rightCol, 1, 0);
            this.tlpRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRoot.Location = new System.Drawing.Point(0, 0);
            this.tlpRoot.Name = "tlpRoot";
            this.tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpRoot.Size = new System.Drawing.Size(1182, 773);
            this.tlpRoot.TabIndex = 0;
            // 
            // leftCol
            // 
            this.leftCol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.leftCol.Controls.Add(this.gbPaths, 0, 0);
            this.leftCol.Controls.Add(this.gbMachines, 0, 1);
            this.leftCol.Controls.Add(this.gbIgnore, 0, 2);
            this.leftCol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftCol.Location = new System.Drawing.Point(3, 3);
            this.leftCol.Name = "leftCol";
            this.leftCol.RowCount = 3;
            this.leftCol.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.leftCol.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.leftCol.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.leftCol.Size = new System.Drawing.Size(443, 767);
            this.leftCol.TabIndex = 0;
            // 
            // gbPaths
            // 
            this.gbPaths.Controls.Add(this.lbPaths);
            this.gbPaths.Controls.Add(this.btnAddPath);
            this.gbPaths.Controls.Add(this.btnRemovePath);
            this.gbPaths.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPaths.Location = new System.Drawing.Point(3, 3);
            this.gbPaths.Name = "gbPaths";
            this.gbPaths.Size = new System.Drawing.Size(437, 174);
            this.gbPaths.TabIndex = 0;
            this.gbPaths.TabStop = false;
            this.gbPaths.Text = "Log 根路徑";
            // 
            // lbPaths
            // 
            this.lbPaths.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbPaths.ItemHeight = 22;
            this.lbPaths.Location = new System.Drawing.Point(3, 79);
            this.lbPaths.Name = "lbPaths";
            this.lbPaths.Size = new System.Drawing.Size(431, 92);
            this.lbPaths.TabIndex = 0;
            // 
            // btnAddPath
            // 
            this.btnAddPath.Location = new System.Drawing.Point(6, 28);
            this.btnAddPath.Name = "btnAddPath";
            this.btnAddPath.Size = new System.Drawing.Size(111, 35);
            this.btnAddPath.TabIndex = 1;
            this.btnAddPath.Text = "新增路徑";
            // 
            // btnRemovePath
            // 
            this.btnRemovePath.Location = new System.Drawing.Point(123, 28);
            this.btnRemovePath.Name = "btnRemovePath";
            this.btnRemovePath.Size = new System.Drawing.Size(111, 35);
            this.btnRemovePath.TabIndex = 2;
            this.btnRemovePath.Text = "移除";
            // 
            // gbMachines
            // 
            this.gbMachines.Controls.Add(this.dgvMachineMap);
            this.gbMachines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMachines.Location = new System.Drawing.Point(3, 183);
            this.gbMachines.Name = "gbMachines";
            this.gbMachines.Size = new System.Drawing.Size(437, 214);
            this.gbMachines.TabIndex = 1;
            this.gbMachines.TabStop = false;
            this.gbMachines.Text = "機台代號對照";
            // 
            // dgvMachineMap
            // 
            this.dgvMachineMap.ColumnHeadersHeight = 29;
            this.dgvMachineMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMachineMap.Location = new System.Drawing.Point(3, 25);
            this.dgvMachineMap.Name = "dgvMachineMap";
            this.dgvMachineMap.RowHeadersWidth = 51;
            this.dgvMachineMap.Size = new System.Drawing.Size(431, 186);
            this.dgvMachineMap.TabIndex = 0;
            // 
            // gbIgnore
            // 
            this.gbIgnore.Controls.Add(this.txtIgnore);
            this.gbIgnore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbIgnore.Location = new System.Drawing.Point(3, 403);
            this.gbIgnore.Name = "gbIgnore";
            this.gbIgnore.Size = new System.Drawing.Size(437, 361);
            this.gbIgnore.TabIndex = 2;
            this.gbIgnore.TabStop = false;
            this.gbIgnore.Text = "忽略關鍵字";
            // 
            // txtIgnore
            // 
            this.txtIgnore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtIgnore.Location = new System.Drawing.Point(3, 25);
            this.txtIgnore.Multiline = true;
            this.txtIgnore.Name = "txtIgnore";
            this.txtIgnore.Size = new System.Drawing.Size(431, 333);
            this.txtIgnore.TabIndex = 0;
            // 
            // rightCol
            // 
            this.rightCol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.rightCol.Controls.Add(this.gbRules, 0, 0);
            this.rightCol.Controls.Add(this.gbOps, 0, 1);
            this.rightCol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightCol.Location = new System.Drawing.Point(452, 3);
            this.rightCol.Name = "rightCol";
            this.rightCol.RowCount = 2;
            this.rightCol.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rightCol.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.rightCol.Size = new System.Drawing.Size(727, 767);
            this.rightCol.TabIndex = 1;
            // 
            // gbRules
            // 
            this.gbRules.Controls.Add(this.dgvRules);
            this.gbRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbRules.Location = new System.Drawing.Point(3, 3);
            this.gbRules.Name = "gbRules";
            this.gbRules.Size = new System.Drawing.Size(721, 581);
            this.gbRules.TabIndex = 0;
            this.gbRules.TabStop = false;
            this.gbRules.Text = "警報代碼規則";
            // 
            // dgvRules
            // 
            this.dgvRules.ColumnHeadersHeight = 29;
            this.dgvRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRules.Location = new System.Drawing.Point(3, 25);
            this.dgvRules.Name = "dgvRules";
            this.dgvRules.RowHeadersWidth = 51;
            this.dgvRules.Size = new System.Drawing.Size(715, 553);
            this.dgvRules.TabIndex = 0;
            // 
            // gbOps
            // 
            this.gbOps.Controls.Add(this.chkWarnOnly);
            this.gbOps.Controls.Add(this.chkIncremental);
            this.gbOps.Controls.Add(this.chkDedup);
            this.gbOps.Controls.Add(this.btnSave);
            this.gbOps.Controls.Add(this.btnRescan);
            this.gbOps.Controls.Add(this.btnRebuild);
            this.gbOps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbOps.Location = new System.Drawing.Point(3, 590);
            this.gbOps.Name = "gbOps";
            this.gbOps.Size = new System.Drawing.Size(721, 174);
            this.gbOps.TabIndex = 1;
            this.gbOps.TabStop = false;
            this.gbOps.Text = "操作";
            // 
            // chkWarnOnly
            // 
            this.chkWarnOnly.Location = new System.Drawing.Point(6, 28);
            this.chkWarnOnly.Name = "chkWarnOnly";
            this.chkWarnOnly.Size = new System.Drawing.Size(104, 24);
            this.chkWarnOnly.TabIndex = 0;
            this.chkWarnOnly.Text = "僅儲存 WARN";
            // 
            // chkIncremental
            // 
            this.chkIncremental.Location = new System.Drawing.Point(6, 58);
            this.chkIncremental.Name = "chkIncremental";
            this.chkIncremental.Size = new System.Drawing.Size(104, 24);
            this.chkIncremental.TabIndex = 1;
            this.chkIncremental.Text = "增量更新";
            // 
            // chkDedup
            // 
            this.chkDedup.Location = new System.Drawing.Point(6, 88);
            this.chkDedup.Name = "chkDedup";
            this.chkDedup.Size = new System.Drawing.Size(104, 24);
            this.chkDedup.TabIndex = 2;
            this.chkDedup.Text = "避免重複寫入";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(6, 132);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(138, 36);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "儲存設定";
            // 
            // btnRescan
            // 
            this.btnRescan.Location = new System.Drawing.Point(150, 132);
            this.btnRescan.Name = "btnRescan";
            this.btnRescan.Size = new System.Drawing.Size(138, 36);
            this.btnRescan.TabIndex = 4;
            this.btnRescan.Text = "重新掃描";
            // 
            // btnRebuild
            // 
            this.btnRebuild.Location = new System.Drawing.Point(294, 132);
            this.btnRebuild.Name = "btnRebuild";
            this.btnRebuild.Size = new System.Drawing.Size(138, 36);
            this.btnRebuild.TabIndex = 5;
            this.btnRebuild.Text = "重建資料庫";
            // 
            // AlarmSettingsView
            // 
            this.Controls.Add(this.tlpRoot);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F);
            this.Name = "AlarmSettingsView";
            this.Size = new System.Drawing.Size(1182, 773);
            this.tlpRoot.ResumeLayout(false);
            this.leftCol.ResumeLayout(false);
            this.gbPaths.ResumeLayout(false);
            this.gbMachines.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMachineMap)).EndInit();
            this.gbIgnore.ResumeLayout(false);
            this.gbIgnore.PerformLayout();
            this.rightCol.ResumeLayout(false);
            this.gbRules.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRules)).EndInit();
            this.gbOps.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
