using Project_LBTToolBox.Services.Alarms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Project_LBTToolBox.Views.Alarms
{
    /// <summary>
    /// 放大檢視 Warn Code 表格的獨立視窗。
    /// </summary>
    public class WarnCodeViewerForm : Form
    {
        private readonly DataGridView _dgvWarnCodes;

        /// <summary>
        /// 建立 Warn Code 檢視視窗。
        /// </summary>
        /// <param name="warnCodeWithMessage">目前畫面上的 Warn Code 資料。</param>
        public WarnCodeViewerForm(Dictionary<string, string> warnCodeWithMessage)
        {
            Text = "Warn Code Viewer";
            StartPosition = FormStartPosition.CenterParent;
            MinimumSize = new Size(720, 480);
            Size = new Size(980, 640);

            _dgvWarnCodes = new DataGridView
            {
                Dock = DockStyle.Fill
            };

            Controls.Add(_dgvWarnCodes);

            AlarmGridHelper.ShowWarnCodeInGrid(_dgvWarnCodes, warnCodeWithMessage);
            ConfigureColumns();
        }

        private void ConfigureColumns()
        {
            if (_dgvWarnCodes.Columns.Count == 0)
                return;

            DataGridViewColumn codeColumn = _dgvWarnCodes.Columns
                .Cast<DataGridViewColumn>()
                .FirstOrDefault(c => c.DataPropertyName == "Code");
            if (codeColumn != null)
            {
                codeColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                codeColumn.Width = 100;
            }

            DataGridViewColumn messageColumn = _dgvWarnCodes.Columns
                .Cast<DataGridViewColumn>()
                .FirstOrDefault(c => c.DataPropertyName == "Message");
            if (messageColumn != null)
            {
                messageColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                messageColumn.MinimumWidth = 300;
            }
        }
    }
}
