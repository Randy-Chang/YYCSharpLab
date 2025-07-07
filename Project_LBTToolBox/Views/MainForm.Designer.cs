namespace Project_LBTToolBox.Views
{
    partial class MainForm
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

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelView = new System.Windows.Forms.Panel();
            this.btnChipIdCorrection = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnSetting);
            this.panelMenu.Controls.Add(this.btnChipIdCorrection);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1182, 80);
            this.panelMenu.TabIndex = 0;
            // 
            // panelView
            // 
            this.panelView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelView.Location = new System.Drawing.Point(0, 80);
            this.panelView.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(1182, 773);
            this.panelView.TabIndex = 1;
            // 
            // btnChipIdCorrection
            // 
            this.btnChipIdCorrection.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnChipIdCorrection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChipIdCorrection.ForeColor = System.Drawing.Color.White;
            this.btnChipIdCorrection.Location = new System.Drawing.Point(0, 0);
            this.btnChipIdCorrection.Name = "btnChipIdCorrection";
            this.btnChipIdCorrection.Size = new System.Drawing.Size(289, 80);
            this.btnChipIdCorrection.TabIndex = 0;
            this.btnChipIdCorrection.Text = "Chip ID Correction";
            this.btnChipIdCorrection.UseVisualStyleBackColor = true;
            // 
            // btnSetting
            // 
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.ForeColor = System.Drawing.Color.White;
            this.btnSetting.Location = new System.Drawing.Point(289, 0);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(166, 80);
            this.btnSetting.TabIndex = 1;
            this.btnSetting.Text = "Setting";
            this.btnSetting.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 853);
            this.Controls.Add(this.panelView);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelView;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnChipIdCorrection;
    }
}

