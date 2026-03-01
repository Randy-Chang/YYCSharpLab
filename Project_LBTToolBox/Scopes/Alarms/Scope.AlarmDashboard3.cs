using Project_LBTToolBox.Services.Alarms;
using Project_LBTToolBox.Services.AlarmsV2;
using Project_LBTToolBox.Services.AlarmsV3;
using Project_LBTToolBox.Views.Alarms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScottPlot;

namespace Project_LBTToolBox.Scopes
{
    public partial class Scope
    {
        private static AlarmDashboardView3 alarmDashboardView3;
        private bool alarmDashboard3IsBusy;
        private readonly List<string> alarmDashboard3IgnoreKeyword = new List<string>
        {
            "機台軟體啟動",
            "初始化完成",
            "全自動完成",
            "請檢察此外觀",
            "EMO : EMOActivated",
            "請確認輸入的產品資訊是否正確",
        };

        private Dictionary<string, string> alarmDashboard3WarnCodes = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        private List<AlarmRecord> alarmDashboard3CurrentRecords = new List<AlarmRecord>();
        private List<string> alarmDashboard3TopCodeLabels = new List<string>();
        private string alarmDashboard3SelectedWarnCode = string.Empty;
        private int alarmDashboard3CurrentPage = 1;
        private const int AlarmDashboard3PageSize = 500;

        private sealed class AlarmDashboard3AnalysisResult
        {
            public string SqliteDbPath { get; set; }
            public List<AlarmRecord> AlarmRecords { get; set; }
            public Dictionary<string, string> WarnCodeWithMessage { get; set; }
            public AlarmStatistics Statistics { get; set; }
            public string SelectedWareCode { get; set; }
        }

        private void InitializeAlarmDashboard3View()
        {
            alarmDashboardView3 = new AlarmDashboardView3();

            alarmDashboardView3.BtnBrowseRemote.Click += AlarmDashboardView3_BtnBrowseRemote_Click;
            alarmDashboardView3.BtnBrowseLocal.Click += AlarmDashboardView3_BtnBrowseLocal_Click;
            alarmDashboardView3.BtnTestRemote.Click += AlarmDashboardView3_BtnTestRemote_Click;
            alarmDashboardView3.BtnApply.Click += AlarmDashboardView3_BtnApply_Click;
            alarmDashboardView3.BtnExportAllAlarmsCsv.Click += AlarmDashboardView3_BtnExportAllAlarmsCsv_Click;
            alarmDashboardView3.BtnExportAlarmsCsv.Click += AlarmDashboardView3_BtnExportAlarmsCsv_Click;
            alarmDashboardView3.BtnExportWarnCodesCsv.Click += AlarmDashboardView3_BtnExportWarnCodesCsv_Click;
            alarmDashboardView3.BtnPrevPage.Click += AlarmDashboardView3_BtnPrevPage_Click;
            alarmDashboardView3.BtnNextPage.Click += AlarmDashboardView3_BtnNextPage_Click;
            alarmDashboardView3.BtnJumpPage.Click += AlarmDashboardView3_BtnJumpPage_Click;
            alarmDashboardView3.TxtJumpPage.KeyDown += AlarmDashboardView3_TxtJumpPage_KeyDown;
            alarmDashboardView3.BtnMachinesAll.Click += AlarmDashboardView3_BtnMachinesAll_Click;
            alarmDashboardView3.BtnMachinesClear.Click += AlarmDashboardView3_BtnMachinesClear_Click;
            alarmDashboardView3.RdbRemote.CheckedChanged += AlarmDashboardView3_SourceModeChanged;
            alarmDashboardView3.RdbLocal.CheckedChanged += AlarmDashboardView3_SourceModeChanged;
            alarmDashboardView3.TxtRemotePath.TextChanged += AlarmDashboardView3_PathTextChanged;
            alarmDashboardView3.TxtLocalPath.TextChanged += AlarmDashboardView3_PathTextChanged;
            alarmDashboardView3.GbWarnCode.DoubleClick += AlarmDashboardView3_WarnCode_DoubleClick;
            alarmDashboardView3.DgvWareCode.CellDoubleClick += AlarmDashboardView3_DgvWareCode_CellDoubleClick;
            alarmDashboardView3.FpCodeBar.MouseDoubleClick += AlarmDashboardView3_FpCodeBar_MouseDoubleClick;
            alarmDashboardView3.FpPareto.MouseDoubleClick += AlarmDashboardView3_FpPareto_MouseDoubleClick;

            LoadAlarmDashboard3Preferences();
            UpdateAlarmDashboard3SourceUi();
            UpdateAlarmDashboard3MachineList();
        }

        private void LoadAlarmDashboard3Preferences()
        {
            AlarmDashboard3Preferences preferences = AlarmDashboard3PreferencesStore.Load();
            alarmDashboardView3.TxtRemotePath.Text = preferences.RemotePath ?? string.Empty;
            alarmDashboardView3.TxtLocalPath.Text = preferences.LocalPath ?? string.Empty;

            bool isRemote = !string.Equals(preferences.LastMode, AlarmDashboard3SourceMode.Local.ToString(), StringComparison.OrdinalIgnoreCase);
            alarmDashboardView3.RdbRemote.Checked = isRemote;
            alarmDashboardView3.RdbLocal.Checked = !isRemote;
        }

        private void SaveAlarmDashboard3Preferences()
        {
            AlarmDashboard3PreferencesStore.Save(new AlarmDashboard3Preferences
            {
                RemotePath = alarmDashboardView3.TxtRemotePath.Text?.Trim() ?? string.Empty,
                LocalPath = alarmDashboardView3.TxtLocalPath.Text?.Trim() ?? string.Empty,
                LastMode = GetAlarmDashboard3SourceMode().ToString()
            });
        }

        private AlarmDashboard3SourceMode GetAlarmDashboard3SourceMode()
        {
            return alarmDashboardView3.RdbRemote.Checked ? AlarmDashboard3SourceMode.Remote : AlarmDashboard3SourceMode.Local;
        }

        private string GetAlarmDashboard3SourcePath()
        {
            return GetAlarmDashboard3SourceMode() == AlarmDashboard3SourceMode.Remote
                ? alarmDashboardView3.TxtRemotePath.Text?.Trim() ?? string.Empty
                : alarmDashboardView3.TxtLocalPath.Text?.Trim() ?? string.Empty;
        }

        private string GetAlarmDashboard3DbPath(string sourcePath)
        {
            if (GetAlarmDashboard3SourceMode() == AlarmDashboard3SourceMode.Local)
                return Path.Combine(sourcePath, "alarms-v3.sqlite");

            string hashedRemotePath = GetAlarmDashboard3RemoteCacheKey(sourcePath);
            string cacheDir = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "Project_LBTToolBox",
                "AlarmDashboardView3",
                "RemoteCache",
                hashedRemotePath);
            return Path.Combine(cacheDir, "alarms-v3.sqlite");
        }

        private string GetAlarmDashboard3RemoteCacheKey(string remotePath)
        {
            string normalizedPath = (remotePath ?? string.Empty).Trim().ToUpperInvariant();
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(normalizedPath));
                StringBuilder builder = new StringBuilder(16);
                for (int i = 0; i < 8; i++)
                {
                    builder.Append(hashBytes[i].ToString("X2"));
                }

                return builder.ToString();
            }
        }

        private void UpdateAlarmDashboard3SourceUi()
        {
            bool isRemote = GetAlarmDashboard3SourceMode() == AlarmDashboard3SourceMode.Remote;

            alarmDashboardView3.TxtRemotePath.Enabled = isRemote;
            alarmDashboardView3.BtnBrowseRemote.Enabled = isRemote;
            alarmDashboardView3.BtnTestRemote.Enabled = isRemote;

            alarmDashboardView3.TxtLocalPath.Enabled = !isRemote;
            alarmDashboardView3.BtnBrowseLocal.Enabled = !isRemote;
            alarmDashboardView3.BtnApply.Enabled = !alarmDashboard3IsBusy;

            alarmDashboardView3.LblCurrentMode.Text = isRemote ? "Remote" : "Local";

            string sourcePath = GetAlarmDashboard3SourcePath();
            alarmDashboardView3.LblDatabasePath.Text = string.IsNullOrWhiteSpace(sourcePath) ? "-" : GetAlarmDashboard3DbPath(sourcePath);
            if (!alarmDashboard3IsBusy && string.IsNullOrWhiteSpace(alarmDashboardView3.LblSourceStatus.Text))
            {
                alarmDashboardView3.LblSourceStatus.Text = isRemote ? "Remote log source selected." : "Local log source selected.";
            }
        }

        private void SetAlarmDashboard3BusyState(bool isBusy, string statusText)
        {
            alarmDashboard3IsBusy = isBusy;

            alarmDashboardView3.RdbRemote.Enabled = !isBusy;
            alarmDashboardView3.RdbLocal.Enabled = !isBusy;
            alarmDashboardView3.TxtRemotePath.Enabled = !isBusy && alarmDashboardView3.RdbRemote.Checked;
            alarmDashboardView3.TxtLocalPath.Enabled = !isBusy && alarmDashboardView3.RdbLocal.Checked;
            alarmDashboardView3.BtnBrowseRemote.Enabled = !isBusy && alarmDashboardView3.RdbRemote.Checked;
            alarmDashboardView3.BtnBrowseLocal.Enabled = !isBusy && alarmDashboardView3.RdbLocal.Checked;
            alarmDashboardView3.BtnTestRemote.Enabled = !isBusy && alarmDashboardView3.RdbRemote.Checked;
            alarmDashboardView3.BtnApply.Enabled = !isBusy;
            alarmDashboardView3.BtnApply.Text = isBusy ? "Analyzing..." : "Apply";
            alarmDashboardView3.BtnMachinesAll.Enabled = !isBusy;
            alarmDashboardView3.BtnMachinesClear.Enabled = !isBusy;
            alarmDashboardView3.BtnExportAllAlarmsCsv.Enabled = !isBusy;
            alarmDashboardView3.BtnExportAlarmsCsv.Enabled = !isBusy;
            alarmDashboardView3.BtnExportWarnCodesCsv.Enabled = !isBusy;
            alarmDashboardView3.BtnPrevPage.Enabled = !isBusy;
            alarmDashboardView3.BtnNextPage.Enabled = !isBusy;
            alarmDashboardView3.BtnJumpPage.Enabled = !isBusy;
            alarmDashboardView3.ClbMachines.Enabled = !isBusy;
            alarmDashboardView3.CkbDateRangeEnable.Enabled = !isBusy;
            alarmDashboardView3.TxtWarnCodeFilter.Enabled = !isBusy;
            alarmDashboardView3.TxtJumpPage.Enabled = !isBusy;
            alarmDashboardView3.UseWaitCursor = isBusy;
            alarmDashboardView3.LblSourceStatus.Text = statusText;
            UpdateAlarmDashboard3SourceUi();
        }

        private void UpdateAlarmDashboard3MachineList()
        {
            CheckedListBox checkedListBox = alarmDashboardView3.ClbMachines;
            checkedListBox.Items.Clear();

            string sourcePath = GetAlarmDashboard3SourcePath();
            if (string.IsNullOrWhiteSpace(sourcePath) || !Directory.Exists(sourcePath))
                return;

            string[] machineDirs = Directory.GetDirectories(sourcePath);
            foreach (string dir in machineDirs)
            {
                checkedListBox.Items.Add(Path.GetFileName(dir), true);
            }
        }

        private List<(string Name, bool IsChecked)> GetAlarmDashboard3Machines()
        {
            List<(string Name, bool IsChecked)> machines = new List<(string Name, bool IsChecked)>();
            foreach (var item in alarmDashboardView3.ClbMachines.Items)
            {
                string name = item.ToString();
                bool isChecked = alarmDashboardView3.ClbMachines.CheckedItems.Contains(item);
                machines.Add((name, isChecked));
            }
            return machines;
        }

        private void AlarmDashboardView3_SourceModeChanged(object sender, EventArgs e)
        {
            UpdateAlarmDashboard3SourceUi();
            UpdateAlarmDashboard3MachineList();
            if (!alarmDashboard3IsBusy)
                SaveAlarmDashboard3Preferences();
        }

        private void AlarmDashboardView3_PathTextChanged(object sender, EventArgs e)
        {
            if (alarmDashboard3IsBusy)
                return;

            UpdateAlarmDashboard3SourceUi();

            if ((sender == alarmDashboardView3.TxtRemotePath && alarmDashboardView3.RdbRemote.Checked) ||
                (sender == alarmDashboardView3.TxtLocalPath && alarmDashboardView3.RdbLocal.Checked))
            {
                UpdateAlarmDashboard3MachineList();
            }
        }

        private void AlarmDashboardView3_BtnBrowseRemote_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new YYControls.Dialogs.FolderPickerDialog())
            {
                if (folderDialog.ShowDialog(alarmDashboardView3) == DialogResult.OK)
                {
                    alarmDashboardView3.TxtRemotePath.Text = folderDialog.DirectoryPath;
                    UpdateAlarmDashboard3SourceUi();
                    UpdateAlarmDashboard3MachineList();
                    SaveAlarmDashboard3Preferences();
                }
            }
        }

        private void AlarmDashboardView3_BtnBrowseLocal_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new YYControls.Dialogs.FolderPickerDialog())
            {
                if (folderDialog.ShowDialog(alarmDashboardView3) == DialogResult.OK)
                {
                    alarmDashboardView3.TxtLocalPath.Text = folderDialog.DirectoryPath;
                    UpdateAlarmDashboard3SourceUi();
                    UpdateAlarmDashboard3MachineList();
                    SaveAlarmDashboard3Preferences();
                }
            }
        }

        private void AlarmDashboardView3_BtnTestRemote_Click(object sender, EventArgs e)
        {
            string remotePath = alarmDashboardView3.TxtRemotePath.Text?.Trim() ?? string.Empty;
            bool exists = !string.IsNullOrWhiteSpace(remotePath) && Directory.Exists(remotePath);

            alarmDashboardView3.LblSourceStatus.Text = exists ? "Remote path available. Local cache will be used." : "Remote path unavailable.";
            if (exists)
            {
                UpdateAlarmDashboard3MachineList();
                SaveAlarmDashboard3Preferences();
            }

            MessageBox.Show(exists ? "Remote path connected." : "Remote path not found.",
                            "Info",
                            MessageBoxButtons.OK,
                            exists ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
        }

        private void AlarmDashboardView3_BtnMachinesAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < alarmDashboardView3.ClbMachines.Items.Count; i++)
            {
                alarmDashboardView3.ClbMachines.SetItemChecked(i, true);
            }
        }

        private void AlarmDashboardView3_BtnMachinesClear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < alarmDashboardView3.ClbMachines.Items.Count; i++)
            {
                alarmDashboardView3.ClbMachines.SetItemChecked(i, false);
            }
        }

        private void AlarmDashboardView3_BtnPrevPage_Click(object sender, EventArgs e)
        {
            if (alarmDashboard3CurrentPage <= 1)
                return;

            alarmDashboard3CurrentPage--;
            RefreshAlarmDashboard3AlarmGridPage();
        }

        private void AlarmDashboardView3_BtnNextPage_Click(object sender, EventArgs e)
        {
            int totalPages = GetAlarmDashboard3TotalPages();
            if (alarmDashboard3CurrentPage >= totalPages)
                return;

            alarmDashboard3CurrentPage++;
            RefreshAlarmDashboard3AlarmGridPage();
        }

        private void AlarmDashboardView3_BtnJumpPage_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(alarmDashboardView3.TxtJumpPage.Text?.Trim(), out int page))
            {
                MessageBox.Show("Please enter a valid page number.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int totalPages = GetAlarmDashboard3TotalPages();
            alarmDashboard3CurrentPage = Math.Max(1, Math.Min(page, totalPages));
            RefreshAlarmDashboard3AlarmGridPage();
        }

        private void AlarmDashboardView3_TxtJumpPage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            e.SuppressKeyPress = true;
            AlarmDashboardView3_BtnJumpPage_Click(sender, EventArgs.Empty);
        }

        private void AlarmDashboardView3_WarnCode_DoubleClick(object sender, EventArgs e)
        {
            if (alarmDashboard3WarnCodes == null || alarmDashboard3WarnCodes.Count == 0)
                return;

            WarnCodeViewerForm viewer = new WarnCodeViewerForm(alarmDashboard3WarnCodes);
            viewer.WarnCodeSelected += AlarmDashboardView3_Viewer_WarnCodeSelected;
            Form owner = alarmDashboardView3.FindForm();
            if (owner != null)
                viewer.Show(owner);
            else
                viewer.Show();
        }

        private void AlarmDashboardView3_DgvWareCode_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            string warnCode = GetAlarmDashboard3WarnCodeFromRow(alarmDashboardView3.DgvWareCode.Rows[e.RowIndex]);
            ApplyAlarmDashboard3WarnCodeFilter(warnCode);
        }

        private void AlarmDashboardView3_Viewer_WarnCodeSelected(string warnCode)
        {
            ApplyAlarmDashboard3WarnCodeFilter(warnCode);
        }

        private void AlarmDashboardView3_FpCodeBar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TryApplyAlarmDashboard3WarnCodeFromPlot(alarmDashboardView3.FpCodeBar, e);
        }

        private void AlarmDashboardView3_FpPareto_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TryApplyAlarmDashboard3WarnCodeFromPlot(alarmDashboardView3.FpPareto, e);
        }

        private void TryApplyAlarmDashboard3WarnCodeFromPlot(FormsPlot plot, MouseEventArgs e)
        {
            if (plot == null || e == null || e.Button != MouseButtons.Left || alarmDashboard3TopCodeLabels == null || alarmDashboard3TopCodeLabels.Count == 0)
                return;

            (double x, double y) = plot.GetMouseCoordinates(e.X, e.Y);
            int nearestIndex = (int)Math.Round(x);
            if (nearestIndex < 0 || nearestIndex >= alarmDashboard3TopCodeLabels.Count)
                return;

            if (Math.Abs(x - nearestIndex) > 0.45)
                return;

            string warnCode = alarmDashboard3TopCodeLabels[nearestIndex];
            ApplyAlarmDashboard3WarnCodeFilter(warnCode);
        }

        private void ApplyAlarmDashboard3WarnCodeFilter(string warnCode)
        {
            if (string.IsNullOrWhiteSpace(warnCode))
                return;

            alarmDashboardView3.TxtWarnCodeFilter.Text = warnCode.Trim();
            alarmDashboardView3.TxtWarnCodeFilter.Focus();
            alarmDashboardView3.TxtWarnCodeFilter.SelectionStart = alarmDashboardView3.TxtWarnCodeFilter.TextLength;
            if (!alarmDashboard3IsBusy)
                alarmDashboardView3.BtnApply.PerformClick();
        }

        private void AlarmDashboardView3_BtnExportAlarmsCsv_Click(object sender, EventArgs e)
        {
            List<AlarmRecord> pageRecords = GetAlarmDashboard3CurrentPageRecords();
            if (pageRecords.Count == 0)
            {
                MessageBox.Show("No current page records to export.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Title = "Export Current Page Alarm Records";
                dialog.Filter = "CSV files (*.csv)|*.csv";
                dialog.FileName = $"AlarmRecords_Page{alarmDashboard3CurrentPage}_{DateTime.Now:yyyyMMdd_HHmmss}.csv";
                if (dialog.ShowDialog(alarmDashboardView3) != DialogResult.OK)
                    return;

                ExportAlarmDashboard3AlarmRecordsCsv(dialog.FileName, pageRecords);
            }
        }

        private void AlarmDashboardView3_BtnExportAllAlarmsCsv_Click(object sender, EventArgs e)
        {
            if (alarmDashboard3CurrentRecords == null || alarmDashboard3CurrentRecords.Count == 0)
            {
                MessageBox.Show("No alarm records to export.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Title = "Export All Alarm Records";
                dialog.Filter = "CSV files (*.csv)|*.csv";
                dialog.FileName = $"AlarmRecords_All_{DateTime.Now:yyyyMMdd_HHmmss}.csv";
                if (dialog.ShowDialog(alarmDashboardView3) != DialogResult.OK)
                    return;

                ExportAlarmDashboard3AlarmRecordsCsv(dialog.FileName, alarmDashboard3CurrentRecords);
            }
        }

        private void AlarmDashboardView3_BtnExportWarnCodesCsv_Click(object sender, EventArgs e)
        {
            if (alarmDashboard3WarnCodes == null || alarmDashboard3WarnCodes.Count == 0)
            {
                MessageBox.Show("No warn codes to export.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Title = "Export Warn Codes";
                dialog.Filter = "CSV files (*.csv)|*.csv";
                dialog.FileName = $"WarnCodes_{DateTime.Now:yyyyMMdd_HHmmss}.csv";
                if (dialog.ShowDialog(alarmDashboardView3) != DialogResult.OK)
                    return;

                ExportAlarmDashboard3WarnCodesCsv(dialog.FileName, alarmDashboard3WarnCodes);
            }
        }

        private void ExportAlarmDashboard3AlarmRecordsCsv(string filePath, List<AlarmRecord> records)
        {
            List<string> lines = new List<string> { "Timestamp,Machine,Level,Code,Message" };
            foreach (AlarmRecord record in records)
            {
                lines.Add(string.Join(",",
                    EscapeAlarmDashboard3Csv(record.Timestamp.ToString("yyyy-MM-dd HH:mm:ss")),
                    EscapeAlarmDashboard3Csv(record.Machine),
                    EscapeAlarmDashboard3Csv(record.Level),
                    EscapeAlarmDashboard3Csv(record.Code),
                    EscapeAlarmDashboard3Csv(record.Message)));
            }

            File.WriteAllLines(filePath, lines, Encoding.UTF8);
            MessageBox.Show($"Alarm records exported:{Environment.NewLine}{filePath}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ExportAlarmDashboard3WarnCodesCsv(string filePath, Dictionary<string, string> warnCodes)
        {
            List<string> lines = new List<string> { "Code,Message" };
            foreach (KeyValuePair<string, string> item in warnCodes.OrderBy(k => k.Key, StringComparer.OrdinalIgnoreCase))
            {
                lines.Add(string.Join(",",
                    EscapeAlarmDashboard3Csv(item.Key),
                    EscapeAlarmDashboard3Csv(item.Value)));
            }

            File.WriteAllLines(filePath, lines, Encoding.UTF8);
            MessageBox.Show($"Warn codes exported:{Environment.NewLine}{filePath}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string EscapeAlarmDashboard3Csv(string value)
        {
            string text = value ?? string.Empty;
            if (text.Contains("\""))
                text = text.Replace("\"", "\"\"");

            if (text.IndexOfAny(new[] { ',', '"', '\r', '\n' }) >= 0)
                return $"\"{text}\"";

            return text;
        }

        private string GetAlarmDashboard3WarnCodeFromRow(DataGridViewRow row)
        {
            if (row == null)
                return string.Empty;

            foreach (DataGridViewCell cell in row.Cells)
            {
                string text = cell.Value?.ToString();
                if (!string.IsNullOrWhiteSpace(text))
                    return text.Trim();
            }

            return string.Empty;
        }

        private int GetAlarmDashboard3TotalPages()
        {
            int recordCount = alarmDashboard3CurrentRecords?.Count ?? 0;
            return Math.Max(1, (int)Math.Ceiling(recordCount / (double)AlarmDashboard3PageSize));
        }

        private List<AlarmRecord> GetAlarmDashboard3CurrentPageRecords()
        {
            List<AlarmRecord> source = alarmDashboard3CurrentRecords ?? new List<AlarmRecord>();
            return source
                .Skip((alarmDashboard3CurrentPage - 1) * AlarmDashboard3PageSize)
                .Take(AlarmDashboard3PageSize)
                .ToList();
        }

        private void RefreshAlarmDashboard3AlarmGridPage()
        {
            List<AlarmRecord> source = alarmDashboard3CurrentRecords ?? new List<AlarmRecord>();
            int totalRecords = source.Count;
            int totalPages = GetAlarmDashboard3TotalPages();

            if (alarmDashboard3CurrentPage < 1)
                alarmDashboard3CurrentPage = 1;
            if (alarmDashboard3CurrentPage > totalPages)
                alarmDashboard3CurrentPage = totalPages;

            List<AlarmRecord> pageRecords = GetAlarmDashboard3CurrentPageRecords();

            AlarmGridHelper.ShowAlarmsInGrid(alarmDashboardView3.DgvAlarmTable, pageRecords);
            alarmDashboardView3.LblPagingStatus.Text = totalRecords == 0
                ? "Page 0 / 0 (0 records)"
                : $"Page {alarmDashboard3CurrentPage} / {totalPages} ({totalRecords} records)";
            alarmDashboardView3.TxtJumpPage.Text = totalRecords == 0 ? string.Empty : alarmDashboard3CurrentPage.ToString();
            alarmDashboardView3.BtnPrevPage.Enabled = !alarmDashboard3IsBusy && alarmDashboard3CurrentPage > 1;
            alarmDashboardView3.BtnNextPage.Enabled = !alarmDashboard3IsBusy && alarmDashboard3CurrentPage < totalPages;
        }

        private async void AlarmDashboardView3_BtnApply_Click(object sender, EventArgs e)
        {
            if (alarmDashboard3IsBusy)
                return;

            string sourcePath = GetAlarmDashboard3SourcePath();
            if (string.IsNullOrWhiteSpace(sourcePath) || !Directory.Exists(sourcePath))
            {
                MessageBox.Show("Please select a valid source folder.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool isFilterDate = alarmDashboardView3.CkbDateRangeEnable.Checked;
            DateTime dateTimeFrom = alarmDashboardView3.DateTimeFrom;
            DateTime dateTimeTo = alarmDashboardView3.DateTimeTo;
            List<(string Name, bool IsChecked)> allMachines = GetAlarmDashboard3Machines();
            List<string> selectedMachines = allMachines.Where(m => m.IsChecked).Select(m => m.Name).ToList();
            string selectedWareCode = (alarmDashboardView3.TxtWarnCodeFilter.Text ?? string.Empty).Trim();
            string sqliteDbPath = GetAlarmDashboard3DbPath(sourcePath);

            try
            {
                SaveAlarmDashboard3Preferences();
                SetAlarmDashboard3BusyState(true, "Analyzing logs and updating cache...");

                AlarmDashboard3AnalysisResult result = await Task.Run(() =>
                    ExecuteAlarmDashboard3Analysis(
                        sourcePath,
                        sqliteDbPath,
                        isFilterDate,
                        dateTimeFrom,
                        dateTimeTo,
                        selectedMachines,
                        selectedWareCode));

                UpdateAlarmDashboard3AnalysisResult(result);
                SetAlarmDashboard3BusyState(false, "Analyzed successfully.");
            }
            catch (Exception ex)
            {
                SetAlarmDashboard3BusyState(false, "Analyze failed.");
                MessageBox.Show($"AlarmDashboardView3 apply failed.{Environment.NewLine}{ex}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private AlarmDashboard3AnalysisResult ExecuteAlarmDashboard3Analysis(
            string sourcePath,
            string sqliteDbPath,
            bool isFilterDate,
            DateTime dateTimeFrom,
            DateTime dateTimeTo,
            List<string> selectedMachines,
            string selectedWareCode)
        {
            string dbDirectory = Path.GetDirectoryName(sqliteDbPath);
            if (!string.IsNullOrWhiteSpace(dbDirectory))
                Directory.CreateDirectory(dbDirectory);

            IAlarmRepository repository = new SQLiteAlarmRepository(sqliteDbPath);
            AlarmIngestionService ingestionService = new AlarmIngestionService(repository);
            AlarmQueryService queryService = new AlarmQueryService(repository);

            ingestionService.Ingest(sourcePath);

            AlarmQuery query = new AlarmQuery
            {
                UseDateFilter = isFilterDate,
                DateFrom = dateTimeFrom,
                DateTo = dateTimeTo,
                SelectedMachines = selectedMachines,
                Level = "WARN",
                WareCode = selectedWareCode
            };

            List<AlarmRecord> alarmRecords = queryService.QueryAlarmRecords(query);
            alarmRecords = AlarmCleaner.FilterRecordByIgnoreMessage(alarmRecords, alarmDashboard3IgnoreKeyword);
            Dictionary<string, string> warnCodeWithMessage = queryService.BuildWareCodeMap(alarmRecords);

            return new AlarmDashboard3AnalysisResult
            {
                SqliteDbPath = sqliteDbPath,
                AlarmRecords = alarmRecords,
                WarnCodeWithMessage = warnCodeWithMessage,
                Statistics = AlarmStatistics.Build(alarmRecords),
                SelectedWareCode = selectedWareCode
            };
        }

        private void UpdateAlarmDashboard3AnalysisResult(AlarmDashboard3AnalysisResult result)
        {
            if (result == null)
                return;

            alarmDashboard3WarnCodes = new Dictionary<string, string>(result.WarnCodeWithMessage, StringComparer.OrdinalIgnoreCase);
            alarmDashboard3CurrentRecords = result.AlarmRecords ?? new List<AlarmRecord>();
            alarmDashboard3CurrentPage = 1;
            alarmDashboard3SelectedWarnCode = result.SelectedWareCode ?? string.Empty;
            AlarmGridHelper.ShowWarnCodeInGrid(alarmDashboardView3.DgvWareCode, result.WarnCodeWithMessage);

            AlarmStatistics statistics = result.Statistics ?? AlarmStatistics.Build(result.AlarmRecords ?? new List<AlarmRecord>());
            var top5Codes = statistics.GetTopCodes(5);
            alarmDashboard3TopCodeLabels = AlarmChartsV4.GetTopCodeItems(
                    statistics.CountsByCode,
                    10,
                    alarmDashboard3SelectedWarnCode)
                .Select(kv => kv.Key)
                .ToList();
            string codeSuffix = string.IsNullOrWhiteSpace(result.SelectedWareCode) ? string.Empty : $" ({result.SelectedWareCode})";

            alarmDashboardView3.LblDatabasePath.Text = result.SqliteDbPath;
            alarmDashboardView3.LblTotalAlarms.Text = statistics.TotalCount.ToString();
            alarmDashboardView3.LblMaxAlarmCode.Text = top5Codes.Count > 0 ? top5Codes[0].Key : "N/A";
            alarmDashboardView3.LblMaxAlarmCodeTimes.Text = top5Codes.Count > 0 ? $"(Times {top5Codes[0].Value})" : "(Times N/A)";
            alarmDashboardView3.LblMaxMachine.Text = statistics.GetMaxCountMachineNumber();

            RefreshAlarmDashboard3AlarmGridPage();
            AlarmChartsV4.PlotCodeBar(alarmDashboardView3.FpCodeBar, statistics.CountsByCode, topN: 10, title: "Code Frequency" + codeSuffix, highlightCode: alarmDashboard3SelectedWarnCode);
            AlarmChartsV4.PlotParetoChart(alarmDashboardView3.FpPareto, statistics.CountsByCode, topN: 10, title: "Pareto" + codeSuffix, highlightCode: alarmDashboard3SelectedWarnCode);
            AlarmChartsV4.PlotMachineBar(alarmDashboardView3.FpMachineBar, statistics.CountsByMachine, topN: 20, title: "Machine Distribution" + codeSuffix);
            AlarmChartsV4.PlotDailyTrend(alarmDashboardView3.FpDailyTrend, statistics.DailyCounts, title: "Daily Trend" + codeSuffix);
            AlarmChartsV4.PlotHourHistogram(alarmDashboardView3.FpHourHistogram, statistics.HourOfDayHistogram, title: "Hour-of-Day Histogram" + codeSuffix);
        }
    }
}
