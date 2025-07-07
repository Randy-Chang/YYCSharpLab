using Project_LBTToolBox.Interfaces;
using Project_LBTToolBox.Services.ChipIdCorrection.Interface;
using Project_LBTToolBox.Services.ChipIdCorrection;
using Project_LBTToolBox.Views;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using LoggingUtilities;

namespace Project_LBTToolBox.Scopes
{
    public partial class Scope
    {
        public static ChipIdCorrectionView chipIdCorrectionView;
        public static string folderPath;

        void InitializeChipIdCorrectionView()
        {
            chipIdCorrectionView = new ChipIdCorrectionView(new ChipIdCorrectionViewPack());
            InitializeChipListGrid(chipIdCorrectionView.DgvChipList);
            chipIdCorrectionView.BtnBrowse.Click += (s, e) => BtnBrowse_Click();
            chipIdCorrectionView.TextFolderPath.KeyDown += TextFolderPath_KeyDownEnter;
            chipIdCorrectionView.BtnApplyFix.Click += (s, e) => BtnApplyFix_Click();
        }

        void BtnBrowse_Click()
        {
            using (YYCSharpLab.CustomControls.Dialogs.FolderBrowserDialog folderBrowserDialog = new YYCSharpLab.CustomControls.Dialogs.FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog(mainForm) == DialogResult.OK)
                {
                    chipIdCorrectionView.TextFolderPath.Text = folderBrowserDialog.DirectoryPath;
                    folderPath = folderBrowserDialog.DirectoryPath;
                    lotFileDisplayService.LoadAndDisplay(folderPath, chipIdCorrectionView.DgvChipList);
                }
            }
        }

        private void TextFolderPath_KeyDownEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                folderPath = chipIdCorrectionView.TextFolderPath.Text;
                lotFileDisplayService.LoadAndDisplay(folderPath, chipIdCorrectionView.DgvChipList);
                e.Handled = true;
                e.SuppressKeyPress = true; // 防止按下 Enter 時出現系統提示聲
            }
        }

        void BtnApplyFix_Click()
        {
            int index = Convert.ToInt32(chipIdCorrectionView.TextBoxIndex.Text);
            string OCR = chipIdCorrectionView.TextBoxOCR.Text;
            chipIdCorrectionService.ApplyCorrection(folderPath, index, OCR);
        }

        /// <summary>
        /// 初始化晶粒清單的 DataGridView 欄位與格式。
        /// </summary>
        /// <param name="dgv">要設定的 DataGridView 控件</param>
        public void InitializeChipListGrid(DataGridView dgv)
        {
            dgv.Columns.Clear();
            dgv.AutoGenerateColumns = false;
            dgv.AllowUserToAddRows = false;
            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.RowHeadersVisible = false;

            // Index 欄位
            var colIndex = new DataGridViewTextBoxColumn();
            colIndex.HeaderText = "Index（索引）";
            colIndex.DataPropertyName = "Index";
            colIndex.Name = "Index";
            colIndex.Width = 200;
            dgv.Columns.Add(colIndex);

            // OCR 欄位
            var colOCR = new DataGridViewTextBoxColumn();
            colOCR.HeaderText = "OCR（晶粒代號）";
            colOCR.DataPropertyName = "OCR";
            colOCR.Name = "OCR";
            colOCR.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns.Add(colOCR);
        }

    }

    public partial class Scope
    {
        public class ChipIdCorrectionViewPack : IChipIdCorrectionViewPack
        {

        }
    }
}