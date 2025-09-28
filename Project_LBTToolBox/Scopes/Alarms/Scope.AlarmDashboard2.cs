using Project_LBTToolBox.Services.Alarms;
using Project_LBTToolBox.Views.Alarms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_LBTToolBox.Scopes
{
    public partial class Scope
    {
        static AlarmDashboardView2 alarmDashboardView2;
        static string logMainFolderPath;

        AlarmService alarmService;
        AlarmStatistics alarmStatistics;

        List<string> ignoreKeyword = new List<string>
        {
            "機台軟體啟動",
            "初始化完成",
            "全自動完成",
            "請檢察此外觀",
            "EMO : EMOActivated",
            "請確認輸入的產品資訊是否正確",
        };

        void InitializeAlarmDashboard2View()
        {
            alarmDashboardView2 = new AlarmDashboardView2();
            alarmService = new AlarmService();

            alarmDashboardView2.BtnBrowseFolder.Click += AlarmDashboardView2_BtnBrowseFolder_Click;
            alarmDashboardView2.TxtPath.TextChanged += AlarmDashboardView2_TxtPath_TextChanged;
            alarmDashboardView2.BtnApply.Click += AlarmDashboardView2_BtnApply_Click;
            alarmDashboardView2.BtnMachinesAll.Click += AlarmDashboardView2_BtnMachinesAll_Click;
            alarmDashboardView2.BtnMachinesClear.Click += AlarmDashboardView2_BtnMachinesClear_Click;
        }

        private void UpdateMachineList(string rootPath, CheckedListBox checkedListBox)
        {
            checkedListBox.Items.Clear();

            if (!Directory.Exists(rootPath))
                return;

            // 找出所有子資料夾
            string[] machineDirs = Directory.GetDirectories(rootPath);

            foreach (var dir in machineDirs)
            {
                // 只取資料夾名稱，不要整個路徑
                string machineName = Path.GetFileName(dir);
                checkedListBox.Items.Add(machineName, true); // 預設勾選
            }
        }

        private List<(string Name, bool IsChecked)> GetAllMachines(CheckedListBox checkedListBox)
        {
            List<(string Name, bool IsChecked)> machines = new List<(string Name, bool IsChecked)>();
            
            foreach (var item in checkedListBox.Items)
            {
                string name = item.ToString();
                bool isChecked = checkedListBox.CheckedItems.Contains(item);
                machines.Add((name, isChecked));
            }

            return machines;
        }

        private void AlarmDashboardView2_BtnBrowseFolder_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new YYControls.Dialogs.FolderPickerDialog())
            {
                if (folderDialog.ShowDialog(alarmDashboardView2) == DialogResult.OK)
                {
                    alarmDashboardView2.TxtPath.Text = folderDialog.DirectoryPath;
                    logMainFolderPath = folderDialog.DirectoryPath;

                    UpdateMachineList(logMainFolderPath, alarmDashboardView2.ClbMachines);
                }
            }
        }

        private void AlarmDashboardView2_TxtPath_TextChanged(object sender, EventArgs e)
        {
            logMainFolderPath = alarmDashboardView2.TxtPath.Text;

            UpdateMachineList(logMainFolderPath, alarmDashboardView2.ClbMachines);
        }

        private void AlarmDashboardView2_BtnMachinesAll_Click(object sender, EventArgs e)
        {
            CheckedListBox checkedListBox = alarmDashboardView2.ClbMachines;

            if(checkedListBox.Items.Count == 0) return;

            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                checkedListBox.SetItemChecked(i, true);
            }
        }

        private void AlarmDashboardView2_BtnMachinesClear_Click(object sender, EventArgs e)
        {
            CheckedListBox checkedListBox = alarmDashboardView2.ClbMachines;

            if (checkedListBox.Items.Count == 0) return;

            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                checkedListBox.SetItemChecked(i, false);
            }
        }

        private void AlarmDashboardView2_BtnApply_Click(object sender, EventArgs e)
        {
            AlarmDashboardView2 view2 = alarmDashboardView2;
            if (logMainFolderPath == null || logMainFolderPath == "") return;

            // 取得篩選條件
            bool isFilterDate = view2.CkbDateRangeEnable.Checked;
            DateTime dateTimeFrom = view2.dateTimeFrom;
            DateTime dateTimeTo = view2.dateTimeTo;
            List<(string Name, bool IsChecked)> allMachines = GetAllMachines(view2.ClbMachines);

            // 取得警報記錄
            List<AlarmRecord> alarmRecords;

            alarmService.SetLogMainFolderPath(logMainFolderPath);
            alarmRecords = alarmService.GetAlarmRecords(isFilterDate, dateTimeFrom, dateTimeTo, allMachines);

            // 移除非 Warn 的記錄
            alarmRecords = AlarmCleaner.FilterRecordByIgnoreMessage(alarmRecords, ignoreKeyword);

            // Warn Code 定義轉換器
            Dictionary<string, string> warnCodeWithMessage;
            AlarmCodeHelper.AttachedWarnCode(ref alarmRecords, out warnCodeWithMessage);

            // 顯示在 DataGridView - Log Table
            DataGridView dgvLogTable = view2.DgvAlarmTable;
            AlarmGridHelper.ShowAlarmsInGrid(dgvLogTable, alarmRecords);

            // 顯示在 DataGridView - Ware Code
            DataGridView dgvWareCode = view2.DgvWareCode;
            AlarmGridHelper.ShowWarnCodeInGrid(dgvWareCode, warnCodeWithMessage);


            alarmStatistics = AlarmStatistics.Build(alarmRecords);

            // 更新 Dashboard 顯示
            var total = alarmStatistics.TotalCount;                          // KPI
            var codeBar = alarmStatistics.CountsByCode;                      // 類型頻率（Bar）
            var machineBar = alarmStatistics.CountsByMachine;                // 機台警報次數（Bar）
            var dailyLine = alarmStatistics.DailyCounts;                     // 整體趨勢（Line）
            var top5Codes = alarmStatistics.GetTopCodes(5);                  // Top N
            var mTrend = alarmStatistics.GetTrendForMachine("01");         // 單機台趨勢
            var mCodes = alarmStatistics.GetCodesForMachine("01");         // 單機台各代碼
            var hourHist = alarmStatistics.HourOfDayHistogram;               // 24 小時分佈
            var maxMachine = alarmStatistics.GetMaxCountMachineNumber();

            view2.LblTotalAlarms.Text = total.ToString();
            view2.LblMaxAlarmCode.Text = top5Codes.Count > 0 ? $"{top5Codes[0].Key}" : "N/A";
            view2.LblMaxAlarmCodeTimes.Text = top5Codes.Count > 0 ? $"(Times {top5Codes[0].Value})" : "(Times N/A)";
            view2.LblMaxMachine.Text = maxMachine;


            AlarmChartsV4.PlotCodeBar(view2.FpCodeBar, alarmStatistics.CountsByCode, topN: 10);
            AlarmChartsV4.PlotMachineBar(view2.FpMachineBar, alarmStatistics.CountsByMachine, topN: 20);
            AlarmChartsV4.PlotDailyTrend(view2.FpDailyTrend, alarmStatistics.DailyCounts);
            AlarmChartsV4.PlotHourHistogram(view2.FpHourHistogram, alarmStatistics.HourOfDayHistogram);

            MessageBox.Show("Applied.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



    }
}
