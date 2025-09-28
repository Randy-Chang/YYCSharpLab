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
            this.tlp1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbPaths = new System.Windows.Forms.GroupBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnChooseFolder = new System.Windows.Forms.Button();
            this.gbOperate = new System.Windows.Forms.GroupBox();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.ckbFilterData = new System.Windows.Forms.CheckBox();
            this.tlp1.SuspendLayout();
            this.gbPaths.SuspendLayout();
            this.gbOperate.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp1
            // 
            this.tlp1.ColumnCount = 2;
            this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.86295F));
            this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.13705F));
            this.tlp1.Controls.Add(this.gbOperate, 1, 0);
            this.tlp1.Controls.Add(this.gbPaths, 0, 0);
            this.tlp1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlp1.Location = new System.Drawing.Point(0, 0);
            this.tlp1.Name = "tlp1";
            this.tlp1.RowCount = 1;
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp1.Size = new System.Drawing.Size(1182, 140);
            this.tlp1.TabIndex = 0;
            // 
            // gbPaths
            // 
            this.gbPaths.Controls.Add(this.btnChooseFolder);
            this.gbPaths.Controls.Add(this.txtPath);
            this.gbPaths.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPaths.Location = new System.Drawing.Point(3, 3);
            this.gbPaths.Name = "gbPaths";
            this.gbPaths.Size = new System.Drawing.Size(477, 134);
            this.gbPaths.TabIndex = 1;
            this.gbPaths.TabStop = false;
            this.gbPaths.Text = "Log 主資料夾路徑";
            // 
            // txtPath
            // 
            this.txtPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPath.Location = new System.Drawing.Point(3, 34);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(471, 38);
            this.txtPath.TabIndex = 0;
            // 
            // btnChooseFolder
            // 
            this.btnChooseFolder.Location = new System.Drawing.Point(3, 78);
            this.btnChooseFolder.Name = "btnChooseFolder";
            this.btnChooseFolder.Size = new System.Drawing.Size(214, 42);
            this.btnChooseFolder.TabIndex = 1;
            this.btnChooseFolder.Text = "Choose Folder";
            this.btnChooseFolder.UseVisualStyleBackColor = true;
            // 
            // gbOperate
            // 
            this.gbOperate.Controls.Add(this.ckbFilterData);
            this.gbOperate.Controls.Add(this.dtpFrom);
            this.gbOperate.Controls.Add(this.lblTo);
            this.gbOperate.Controls.Add(this.dtpTo);
            this.gbOperate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbOperate.Location = new System.Drawing.Point(486, 3);
            this.gbOperate.Name = "gbOperate";
            this.gbOperate.Size = new System.Drawing.Size(693, 134);
            this.gbOperate.TabIndex = 2;
            this.gbOperate.TabStop = false;
            this.gbOperate.Text = "操作與篩選";
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "yyyy-MM-dd";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(133, 30);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 38);
            this.dtpFrom.TabIndex = 6;
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "yyyy-MM-dd";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(383, 30);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 38);
            this.dtpTo.TabIndex = 8;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(339, 37);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(38, 29);
            this.lblTo.TabIndex = 7;
            this.lblTo.Text = "—";
            // 
            // ckbFilterData
            // 
            this.ckbFilterData.AutoSize = true;
            this.ckbFilterData.Location = new System.Drawing.Point(6, 37);
            this.ckbFilterData.Name = "ckbFilterData";
            this.ckbFilterData.Size = new System.Drawing.Size(127, 33);
            this.ckbFilterData.TabIndex = 1;
            this.ckbFilterData.Text = "篩選日期";
            this.ckbFilterData.UseVisualStyleBackColor = true;
            // 
            // AlarmDashboardView2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlp1);
            this.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "AlarmDashboardView2";
            this.Size = new System.Drawing.Size(1182, 773);
            this.tlp1.ResumeLayout(false);
            this.gbPaths.ResumeLayout(false);
            this.gbPaths.PerformLayout();
            this.gbOperate.ResumeLayout(false);
            this.gbOperate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp1;
        private System.Windows.Forms.GroupBox gbPaths;
        private System.Windows.Forms.Button btnChooseFolder;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.GroupBox gbOperate;
        public System.Windows.Forms.DateTimePicker dtpFrom;
        public System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.CheckBox ckbFilterData;
        private System.Windows.Forms.Label lblTo;
    }
}
