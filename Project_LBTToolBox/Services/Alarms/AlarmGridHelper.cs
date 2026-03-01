using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_LBTToolBox.Services.Alarms
{
    public static class AlarmGridHelper
    {
        /// <summary>
        /// 在 DataGridView 中顯示 AlarmRecord 清單
        /// </summary>
        public static void ShowAlarmsInGrid(DataGridView dgv, List<AlarmRecord> records)
        {
            if (dgv == null) return;

            // 基本設定
            dgv.AutoGenerateColumns = false;
            dgv.Columns.Clear();
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.MultiSelect = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.ScrollBars = ScrollBars.Both;
            dgv.RowTemplate.Height = 22;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgv.DefaultCellStyle.WrapMode = DataGridViewTriState.False;

            // 表頭高度也固定（可選）
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            // 左側行頭（箭頭那欄）固定或關掉
            dgv.RowHeadersVisible = false;
            dgv.ColumnHeadersHeight = 30;

            // 時間
            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Timestamp",
                HeaderText = "時間",
                Width = 170,
                DefaultCellStyle = { Format = "yyyy-MM-dd HH:mm:ss" }
            });

            // 機台
            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Machine",
                HeaderText = "機台",
                Width = 90
            });

            // Level
            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Level",
                HeaderText = "等級",
                Width = 70
            });

            // Code
            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Code",
                HeaderText = "代碼",
                Width = 90
            });

            // Message
            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Message",
                HeaderText = "訊息內容",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            // FilePath (可選，調試用)
            //dgv.Columns.Add(new DataGridViewTextBoxColumn
            //{
            //    DataPropertyName = "FilePath",
            //    HeaderText = "來源檔案",
            //    Width = 200
            //});

            // 綁定資料
            dgv.DataSource = null;
            dgv.DataSource = records ?? new List<AlarmRecord>();
        }

        /// <summary>
        /// 在 DataGridView 中顯示 Warn Code 對應的訊息說明
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="warnCodeWithMessage"></param>
        public static void ShowWarnCodeInGrid(DataGridView dgv, Dictionary<string, string> warnCodeWithMessage)
        {
            if (dgv == null) return;

            dgv.AutoGenerateColumns = false;
            dgv.Columns.Clear();
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.MultiSelect = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // ❗關鍵：不要自動撐滿、不要自動換行、固定列高、允許卷動
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgv.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dgv.ScrollBars = ScrollBars.Both;
            dgv.RowTemplate.Height = 22;

            // 表頭高度也固定（可選）
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            // 左側行頭（箭頭那欄）固定或關掉
            dgv.RowHeadersVisible = false;
            dgv.ColumnHeadersHeight = 30;

            // Code 欄
            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Code",
                HeaderText = "代碼",
                Width = 90,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            });

            // 規則 / 訊息 欄（固定大一點）
            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Message",
                HeaderText = "規則 / 範例訊息",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                MinimumWidth = 240,
                DefaultCellStyle = { WrapMode = DataGridViewTriState.False }
            });

            var rows = new List<WarnCodeRow>();
            if (warnCodeWithMessage != null)
            {
                foreach (var kv in warnCodeWithMessage.OrderBy(k => k.Key, StringComparer.OrdinalIgnoreCase))
                    rows.Add(new WarnCodeRow { Code = kv.Key ?? string.Empty, Message = kv.Value ?? string.Empty });
            }

            dgv.DataSource = null;
            dgv.DataSource = rows;
        }

        private class WarnCodeRow
        {
            public string Code { get; set; }
            public string Message { get; set; }
        }
    }
}
