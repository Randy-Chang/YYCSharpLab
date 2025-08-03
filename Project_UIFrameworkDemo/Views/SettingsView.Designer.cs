namespace Project_UIFrameworkDemo.Views
{
    partial class SettingsView
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
            this.btnThemeSwitch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnThemeSwitch
            // 
            this.btnThemeSwitch.Location = new System.Drawing.Point(70, 57);
            this.btnThemeSwitch.Name = "btnThemeSwitch";
            this.btnThemeSwitch.Size = new System.Drawing.Size(133, 53);
            this.btnThemeSwitch.TabIndex = 0;
            this.btnThemeSwitch.Text = "btnThemeSwitch";
            this.btnThemeSwitch.UseVisualStyleBackColor = true;
            // 
            // SettingsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnThemeSwitch);
            this.Name = "SettingsView";
            this.Size = new System.Drawing.Size(350, 426);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThemeSwitch;
    }
}
