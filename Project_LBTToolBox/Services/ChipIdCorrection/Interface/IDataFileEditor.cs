using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_LBTToolBox.Services.ChipIdCorrection.Interface
{
    /// <summary>
    /// 負責將 OCR 在資料檔案中替換，例如 SweepV/I/OSA。
    /// </summary>
    public interface IDataFileEditor
    {
        /// <summary>
        /// 在指定 Bar 資料夾中的所有 CSV 檔案中，
        /// 根據提供的條件紀錄，尋找符合的舊 OCR 並替換為新 OCR。
        /// </summary>
        void ReplaceOcrInBarFolder_BySubIndex(
            string barFolderPath, 
            string oldOcr, 
            string newOcr, 
            int subIndex, 
            int chipCountInSubLot);

    }


}
