using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_LBTToolBox.Services.ChipIdCorrection.Interface
{
    /// <summary>
    /// 提供 lotFile.csv 的讀取與儲存操作。
    /// </summary>
    public interface ILotFileParser
    {
        /// <summary>
        /// 從檔案載入 lotFile，並解析為 LotFile 資料模型。
        /// </summary>
        LotFile LoadLotFile(string filePath, int skipHeaderCount);

        /// <summary>
        /// 儲存 LotFile 資料為 CSV 格式回檔案中。
        /// </summary>
        void SaveLotFile(string filePath, LotFile lotFile);
    }
}
