using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using LoggingUtilities;
using Project_LBTToolBox.Services.ChipIdCorrection.Interface;
using Project_LBTToolBox.Services.ChipIdCorrection;

namespace Project_LBTToolBox.Services.LotFileDisplay
{
    public class LotFileDisplayService
    {
        private readonly ILotFileParser _parser;

        public LotFileDisplayService(ILotFileParser parser)
        {
            _parser = parser;
        }

        /// <summary>
        /// 載入指定資料夾中的主 lotFile.csv，顯示至指定 DataGridView，並標記重複 OCR。
        /// </summary>
        /// <param name="folderPath">主 lotFile 所在的資料夾</param>
        /// <param name="dgv">要顯示的 DataGridView（需有 Index/OCR 欄）</param>
        public void LoadAndDisplay(string folderPath, DataGridView dgv)
        {
            try
            {
                dgv.Rows.Clear();

                string lotFilePath = Directory
                    .GetFiles(folderPath, "*_lotFile.csv", SearchOption.TopDirectoryOnly)
                    .FirstOrDefault();

                if (string.IsNullOrEmpty(lotFilePath))
                {
                    LoggerService.Instance.Error("找不到主 lotFile.csv 檔案");
                    MessageBox.Show("找不到主 lotFile.csv 檔案", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                LotFile lot = _parser.LoadLotFile(lotFilePath, 2);

                // 分析重複的 OCR 值（ChipID）
                var duplicatedOcrs = lot.Records
                    .Where(r => !string.IsNullOrWhiteSpace(r.OCR))
                    .GroupBy(r => r.OCR)
                    .Where(g => g.Count() > 1)
                    .Select(g => g.Key)
                    .ToHashSet();

                // 顯示資料列
                foreach (var record in lot.Records.OrderBy(r => r.Index))
                {
                    int rowIndex = dgv.Rows.Add();
                    dgv.Rows[rowIndex].Cells[0].Value = record.Index; // Index 欄位
                    dgv.Rows[rowIndex].Cells[1].Value = record.OCR;   // OCR 欄位（即 ChipID）

                    // 若 OCR 是重複的，加上背景色標記
                    if (duplicatedOcrs.Contains(record.OCR))
                    {
                        dgv.Rows[rowIndex].DefaultCellStyle.BackColor = Color.LightPink;
                    }
                }

                string msg = $"載入完成：共 {lot.Records.Count} 筆，重複 OCR 數量：{duplicatedOcrs.Count}";
                LoggerService.Instance.Info(msg);
                MessageBox.Show(msg, "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                LoggerService.Instance.Error(ex);
                MessageBox.Show("載入失敗：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
