using System.IO;
using System;
using System.Windows.Forms;
using YYControls.Controls.WaferMap;

namespace Project_ControlWaferMapDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var wafer = new WaferMapControl
            {
                Dock = DockStyle.Fill,
                ShowCellText = true,
                ShowGridLines = true
            };
            panelWafer.Controls.Add(wafer);

            // 取得 bin/Debug/net48 等執行資料夾
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            // 回到專案根目錄（假設 csproj 在 bin 資料夾的上兩層）
            string projectDir = Directory.GetParent(baseDir).Parent.Parent.FullName;

            // 載入你的 BarOCRMap.csv / map.csv（矩陣：每列是 Row，每欄是 Col）
            wafer.LoadMapCsv($@"{projectDir}\BarOCRMap.csv");
            //wafer.LoadMapCsv($@"{projectDir}\BarOCRMap_Mini.csv");

            // 點擊回報
            wafer.DieClicked += (s, ev) =>
            {
                this.Text = $"Row={ev.Row}, Col={ev.Col}, Key={ev.CellText}";
            };
        }
    }
}
