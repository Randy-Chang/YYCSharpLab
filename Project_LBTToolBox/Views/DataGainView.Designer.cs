namespace Project_LBTToolBox.Views
{
    partial class DataGainView
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
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.gbFolderPath = new System.Windows.Forms.GroupBox();
            this.dgvGainSet = new System.Windows.Forms.DataGridView();
            this.btnGainData = new System.Windows.Forms.Button();
            this.gbFolderPath.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGainSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.Location = new System.Drawing.Point(6, 37);
            this.txtFolderPath.Multiline = true;
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.Size = new System.Drawing.Size(563, 92);
            this.txtFolderPath.TabIndex = 4;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(575, 37);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(118, 92);
            this.btnBrowse.TabIndex = 5;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            // 
            // gbFolderPath
            // 
            this.gbFolderPath.Controls.Add(this.txtFolderPath);
            this.gbFolderPath.Controls.Add(this.btnBrowse);
            this.gbFolderPath.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbFolderPath.Location = new System.Drawing.Point(18, 15);
            this.gbFolderPath.Name = "gbFolderPath";
            this.gbFolderPath.Size = new System.Drawing.Size(707, 145);
            this.gbFolderPath.TabIndex = 6;
            this.gbFolderPath.TabStop = false;
            this.gbFolderPath.Text = "資料夾路徑 (Folder Path)";
            // 
            // dgvGainSet
            // 
            this.dgvGainSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGainSet.Location = new System.Drawing.Point(18, 186);
            this.dgvGainSet.Name = "dgvGainSet";
            this.dgvGainSet.RowHeadersWidth = 51;
            this.dgvGainSet.RowTemplate.Height = 27;
            this.dgvGainSet.Size = new System.Drawing.Size(435, 231);
            this.dgvGainSet.TabIndex = 7;
            // 
            // btnGainData
            // 
            this.btnGainData.Location = new System.Drawing.Point(292, 423);
            this.btnGainData.Name = "btnGainData";
            this.btnGainData.Size = new System.Drawing.Size(161, 55);
            this.btnGainData.TabIndex = 8;
            this.btnGainData.Text = "Gain Data";
            this.btnGainData.UseVisualStyleBackColor = true;
            // 
            // DataGainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnGainData);
            this.Controls.Add(this.dgvGainSet);
            this.Controls.Add(this.gbFolderPath);
            this.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "DataGainView";
            this.Size = new System.Drawing.Size(1182, 773);
            this.gbFolderPath.ResumeLayout(false);
            this.gbFolderPath.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGainSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtFolderPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.GroupBox gbFolderPath;
        private System.Windows.Forms.DataGridView dgvGainSet;
        private System.Windows.Forms.Button btnGainData;
    }
}
