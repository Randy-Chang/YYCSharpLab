namespace Project_LBTToolBox.Views
{
    partial class ChipIdCorrectionView
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
            this.dgvChipList = new System.Windows.Forms.DataGridView();
            this.lbFolderPath = new System.Windows.Forms.Label();
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lbIndex = new System.Windows.Forms.Label();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.btnApplyFix = new System.Windows.Forms.Button();
            this.lbOCR = new System.Windows.Forms.Label();
            this.txtOCR = new System.Windows.Forms.TextBox();
            this.grpFixPanel = new System.Windows.Forms.GroupBox();
            this.gbChipList = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChipList)).BeginInit();
            this.grpFixPanel.SuspendLayout();
            this.gbChipList.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvChipList
            // 
            this.dgvChipList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChipList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChipList.Location = new System.Drawing.Point(3, 34);
            this.dgvChipList.Name = "dgvChipList";
            this.dgvChipList.RowHeadersWidth = 51;
            this.dgvChipList.RowTemplate.Height = 27;
            this.dgvChipList.Size = new System.Drawing.Size(425, 558);
            this.dgvChipList.TabIndex = 0;
            // 
            // lbFolderPath
            // 
            this.lbFolderPath.AutoSize = true;
            this.lbFolderPath.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbFolderPath.Location = new System.Drawing.Point(17, 16);
            this.lbFolderPath.Name = "lbFolderPath";
            this.lbFolderPath.Size = new System.Drawing.Size(276, 29);
            this.lbFolderPath.TabIndex = 1;
            this.lbFolderPath.Text = "資料夾路徑 (Folder Path)\r\n";
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.Location = new System.Drawing.Point(22, 50);
            this.txtFolderPath.Multiline = true;
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.Size = new System.Drawing.Size(563, 92);
            this.txtFolderPath.TabIndex = 2;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(606, 50);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(118, 92);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            // 
            // lbIndex
            // 
            this.lbIndex.AutoSize = true;
            this.lbIndex.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbIndex.Location = new System.Drawing.Point(48, 47);
            this.lbIndex.Name = "lbIndex";
            this.lbIndex.Size = new System.Drawing.Size(161, 29);
            this.lbIndex.TabIndex = 4;
            this.lbIndex.Text = "索引值 Index :\r\n";
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(215, 44);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(94, 38);
            this.txtIndex.TabIndex = 5;
            // 
            // btnApplyFix
            // 
            this.btnApplyFix.Location = new System.Drawing.Point(19, 152);
            this.btnApplyFix.Name = "btnApplyFix";
            this.btnApplyFix.Size = new System.Drawing.Size(290, 46);
            this.btnApplyFix.TabIndex = 6;
            this.btnApplyFix.Text = "Apply Fix";
            this.btnApplyFix.UseVisualStyleBackColor = true;
            // 
            // lbOCR
            // 
            this.lbOCR.AutoSize = true;
            this.lbOCR.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbOCR.Location = new System.Drawing.Point(14, 101);
            this.lbOCR.Name = "lbOCR";
            this.lbOCR.Size = new System.Drawing.Size(195, 29);
            this.lbOCR.TabIndex = 7;
            this.lbOCR.Text = "光學辨識碼 OCR :\r\n";
            // 
            // txtOCR
            // 
            this.txtOCR.Location = new System.Drawing.Point(215, 98);
            this.txtOCR.Name = "txtOCR";
            this.txtOCR.Size = new System.Drawing.Size(94, 38);
            this.txtOCR.TabIndex = 8;
            // 
            // grpFixPanel
            // 
            this.grpFixPanel.Controls.Add(this.lbIndex);
            this.grpFixPanel.Controls.Add(this.txtIndex);
            this.grpFixPanel.Controls.Add(this.txtOCR);
            this.grpFixPanel.Controls.Add(this.btnApplyFix);
            this.grpFixPanel.Controls.Add(this.lbOCR);
            this.grpFixPanel.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpFixPanel.Location = new System.Drawing.Point(489, 164);
            this.grpFixPanel.Name = "grpFixPanel";
            this.grpFixPanel.Size = new System.Drawing.Size(327, 209);
            this.grpFixPanel.TabIndex = 10;
            this.grpFixPanel.TabStop = false;
            this.grpFixPanel.Text = "修復面板 (Fix Panel)";
            // 
            // gbChipList
            // 
            this.gbChipList.Controls.Add(this.dgvChipList);
            this.gbChipList.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbChipList.Location = new System.Drawing.Point(22, 164);
            this.gbChipList.Name = "gbChipList";
            this.gbChipList.Size = new System.Drawing.Size(431, 595);
            this.gbChipList.TabIndex = 11;
            this.gbChipList.TabStop = false;
            this.gbChipList.Text = "晶粒清單 (Chip List)";
            // 
            // ChipIdCorrectionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbChipList);
            this.Controls.Add(this.grpFixPanel);
            this.Controls.Add(this.txtFolderPath);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.lbFolderPath);
            this.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "ChipIdCorrectionView";
            this.Size = new System.Drawing.Size(1182, 773);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChipList)).EndInit();
            this.grpFixPanel.ResumeLayout(false);
            this.grpFixPanel.PerformLayout();
            this.gbChipList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChipList;
        private System.Windows.Forms.Label lbFolderPath;
        private System.Windows.Forms.TextBox txtFolderPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lbIndex;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.Button btnApplyFix;
        private System.Windows.Forms.Label lbOCR;
        private System.Windows.Forms.TextBox txtOCR;
        private System.Windows.Forms.GroupBox grpFixPanel;
        private System.Windows.Forms.GroupBox gbChipList;
    }
}
