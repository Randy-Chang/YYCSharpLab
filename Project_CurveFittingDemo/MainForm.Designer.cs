namespace Project_CurveFittingDemo
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
            this.panelChart = new System.Windows.Forms.Panel();
            this.btnRunDemo = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelOperate = new System.Windows.Forms.Panel();
            this.panelOperate.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelChart
            // 
            this.panelChart.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChart.Location = new System.Drawing.Point(0, 74);
            this.panelChart.Name = "panelChart";
            this.panelChart.Size = new System.Drawing.Size(782, 479);
            this.panelChart.TabIndex = 0;
            // 
            // btnRunDemo
            // 
            this.btnRunDemo.Location = new System.Drawing.Point(12, 12);
            this.btnRunDemo.Name = "btnRunDemo";
            this.btnRunDemo.Size = new System.Drawing.Size(205, 40);
            this.btnRunDemo.TabIndex = 1;
            this.btnRunDemo.Text = "RunDemo";
            this.btnRunDemo.UseVisualStyleBackColor = true;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.SkyBlue;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 64);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(782, 10);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // panelOperate
            // 
            this.panelOperate.Controls.Add(this.btnRunDemo);
            this.panelOperate.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOperate.Location = new System.Drawing.Point(0, 0);
            this.panelOperate.Name = "panelOperate";
            this.panelOperate.Size = new System.Drawing.Size(782, 64);
            this.panelOperate.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.panelChart);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelOperate);
            this.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.panelOperate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChart;
        private System.Windows.Forms.Button btnRunDemo;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panelOperate;
    }
}

