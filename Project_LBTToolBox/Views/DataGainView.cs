using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YYControls.Dialogs;

namespace Project_LBTToolBox.Views
{
    public partial class DataGainView : UserControl
    {
        enum EGainTerm { PowerFront, PowerRear }

        string _folderPath;

        public DataGainView()
        {
            InitializeComponent();
            IinitializeDataGridView(dgvGainSet);


            btnBrowse.Click += BtnBrowse_Click;
            btnGainData.Click += BtnGainData_Click;
        }

        private void IinitializeDataGridView(DataGridView dataGridView)
        {
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoGenerateColumns = false;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.MultiSelect = false;
            dataGridView.RowHeadersVisible = false; // 隱藏最左邊空白列
            // 設定欄位
            dataGridView.Columns.Add("Term", "Gain Term");
            dataGridView.Columns.Add("A", "Coefficient (a)");
            dataGridView.Columns.Add("B", "Offset (b)");

            foreach (EGainTerm eGainTerm in Enum.GetValues(typeof(EGainTerm)))
            {
                dataGridView.Rows.Add(
                    eGainTerm.ToString(),
                    1.0, // 預設係數 a
                    0.0  // 預設偏移 b
                );
            }
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            using (FolderPickerDialog folderPickerDialog = new FolderPickerDialog())
            {
                if (folderPickerDialog.ShowDialog(this) == DialogResult.OK)
                {
                    txtFolderPath.Text = folderPickerDialog.DirectoryPath;
                    _folderPath = folderPickerDialog.DirectoryPath;
                }
            }
        }

        private void BtnGainData_Click(object sender, EventArgs e)
        {
            // 確保已選擇資料夾
            if (string.IsNullOrWhiteSpace(_folderPath) || !System.IO.Directory.Exists(_folderPath))
            {
                MessageBox.Show("請先選擇有效的資料夾。");
                return;
            }

            // 從 DataGridView 取得各 Term 的 (a, b)
            var gainMap = ReadGainsFromGrid(dgvGainSet); // 你自己的 DataGridView 變數名

            // 取得資料夾內子資料夾
            string[] subFolders = System.IO.Directory.GetDirectories(_folderPath);

            // 依照順序取得子資料夾內的csv檔案
            foreach (string subFolder in subFolders)
            {
                ProcessSubFolder(subFolder, gainMap);
            }

            MessageBox.Show("數據處理完成。");
        }

        private void ProcessSubFolder(string subFolder, Dictionary<EGainTerm, (double a, double b)> gainMap)
        {
            // 取得子資料夾內的csv檔案
            string[] csvFiles = System.IO.Directory.GetFiles(subFolder, "*.csv");
            foreach (string csvFile in csvFiles)
            {
                // 讀取CSV檔案並處理數據
                ProcessCsvFile(csvFile, gainMap);
            }
        }

        private void ProcessCsvFile(string csvFile, Dictionary<EGainTerm, (double a, double b)> gainMap)
        {
            DataTable dataTable = ReadCsvToDataTable(csvFile);

            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show($"CSV檔案 {csvFile} 沒有數據。");
                return;
            }

            // 確認LD_PowerFront和LD_PowerRear欄位存在
            if ((!dataTable.Columns.Contains("LD_FrontPower") || !dataTable.Columns.Contains("LD_P")) &&
                !dataTable.Columns.Contains("LD_BackPower"))
            {
                //MessageBox.Show($"CSV檔案 {csvFile} 缺少必要的欄位。");
                return;
            }

            bool isPowerFront = dataTable.Columns.Contains("LD_FrontPower");

            // 依據GainMap計算新的數據
            foreach (DataRow row in dataTable.Rows)
            {
                if (isPowerFront)
                {
                    double originalValue = Convert.ToDouble(row["LD_FrontPower"]);
                    if (gainMap.TryGetValue(EGainTerm.PowerFront, out var gain))
                    {
                        double newValue = gain.a * originalValue + gain.b;
                        row["LD_FrontPower"] = newValue;
                    }
                }
                else
                {
                    double originalValue = Convert.ToDouble(row["LD_P"]);
                    if (gainMap.TryGetValue(EGainTerm.PowerFront, out var gain))
                    {
                        double newValue = gain.a * originalValue + gain.b;
                        row["LD_P"] = newValue;
                    }
                }

                if (dataTable.Columns.Contains("LD_BackPower"))
                {
                    double originalValue = Convert.ToDouble(row["LD_BackPower"]);
                    if (gainMap.TryGetValue(EGainTerm.PowerRear, out var gain))
                    {
                        double newValue = gain.a * originalValue + gain.b;
                        row["LD_BackPower"] = newValue;
                    }
                }
            }

            // 儲存處理後的數據到新的CSV檔案
            SaveDataTableToCsv(dataTable, csvFile);
        }

        private void SaveDataTableToCsv(DataTable dataTable, string outputFilePath)
        {
            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                // 過濾掉 "ColumnX" 這種自動生成的欄位
                var validCols = dataTable.Columns.Cast<DataColumn>()
                                  .Where(c => !c.ColumnName.StartsWith("Column"))
                                  .ToList();

                // 寫入標題行
                string header = string.Join(",", validCols.Select(c => c.ColumnName));
                writer.WriteLine(header);
                // 寫入數據行
                foreach (DataRow row in dataTable.Rows)
                {
                    string line = string.Join(",", row.ItemArray.Select(item => item.ToString()));
                    writer.WriteLine(line);
                }
            }
        }

        DataTable ReadCsvToDataTable(string csvFile)
        {
            DataTable dataTable = new DataTable();
            using (StreamReader reader = new StreamReader(csvFile))
            {
                string headerLine = reader.ReadLine();
                if (headerLine != null)
                {
                    string[] headers = headerLine.Split(',');
                    foreach (string header in headers)
                    {
                        dataTable.Columns.Add(header.Trim());
                    }
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        if (line != null)
                        {
                            string[] values = line.Split(',');
                            dataTable.Rows.Add(values);
                        }
                    }
                }
            }
            return dataTable;
        }

        private Dictionary<EGainTerm, (double a, double b)> ReadGainsFromGrid(DataGridView dgv)
        {
            var dict = new Dictionary<EGainTerm, (double a, double b)>();
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.IsNewRow) continue;

                var termStr = Convert.ToString(row.Cells["Term"].Value);
                if (!Enum.TryParse(termStr, out EGainTerm term))
                    continue;

                double a = 1.0, b = 0.0;
                double.TryParse(Convert.ToString(row.Cells["A"].Value), out a);
                double.TryParse(Convert.ToString(row.Cells["B"].Value), out b);

                dict[term] = (a, b);
            }
            return dict;
        }
    }
}
