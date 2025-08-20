namespace Project_ControlWaferMapDemo
{
    partial class Form1
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
            this.panelWafer = new System.Windows.Forms.Panel();
            this.panelOperate = new System.Windows.Forms.Panel();
            this.splitterMid = new System.Windows.Forms.Splitter();
            this.btnLoadDatFile = new System.Windows.Forms.Button();
            this.panelOperate.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelWafer
            // 
            this.panelWafer.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelWafer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWafer.Location = new System.Drawing.Point(0, 105);
            this.panelWafer.Name = "panelWafer";
            this.panelWafer.Size = new System.Drawing.Size(902, 768);
            this.panelWafer.TabIndex = 0;
            // 
            // panelOperate
            // 
            this.panelOperate.BackColor = System.Drawing.SystemColors.Control;
            this.panelOperate.Controls.Add(this.btnLoadDatFile);
            this.panelOperate.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOperate.Location = new System.Drawing.Point(0, 0);
            this.panelOperate.Name = "panelOperate";
            this.panelOperate.Size = new System.Drawing.Size(902, 95);
            this.panelOperate.TabIndex = 1;
            // 
            // splitterMid
            // 
            this.splitterMid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.splitterMid.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterMid.Location = new System.Drawing.Point(0, 95);
            this.splitterMid.Name = "splitterMid";
            this.splitterMid.Size = new System.Drawing.Size(902, 10);
            this.splitterMid.TabIndex = 2;
            this.splitterMid.TabStop = false;
            // 
            // btnLoadDatFile
            // 
            this.btnLoadDatFile.Location = new System.Drawing.Point(12, 12);
            this.btnLoadDatFile.Name = "btnLoadDatFile";
            this.btnLoadDatFile.Size = new System.Drawing.Size(245, 72);
            this.btnLoadDatFile.TabIndex = 0;
            this.btnLoadDatFile.Text = "Load Data File";
            this.btnLoadDatFile.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 873);
            this.Controls.Add(this.panelWafer);
            this.Controls.Add(this.splitterMid);
            this.Controls.Add(this.panelOperate);
            this.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelOperate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelWafer;
        private System.Windows.Forms.Panel panelOperate;
        private System.Windows.Forms.Splitter splitterMid;
        private System.Windows.Forms.Button btnLoadDatFile;
    }
}

