using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_LBTToolBox.Services.ChipIdCorrection.Interface
{
    /// <summary>
    /// 提供檔案與資料夾相關的操作，例如尋找 Bar 子資料夾與列出資料檔案。
    /// </summary>
    public interface IFileSystemProvider
    {
        /// <summary>
        /// 根據 Bar 的起始 OCR 找到對應的資料夾路徑。
        /// </summary>
        /// <param name="projectRootPath">專案根目錄</param>
        /// <param name="firstOcr">Bar 的第一顆晶粒 OCR（例如 0A51）</param>
        string LocateBarFolder(string projectRootPath, string firstOcr);

        /// <summary>
        /// 取得專案中所有 lotFile.csv 的完整路徑。
        /// </summary>
        string[] GetAllLotFilePaths(string rootPath);

        /// <summary>
        /// 取得指定 Bar 資料夾中所有測試用的 CSV 檔案（例如 SweepI/V/OSA）。
        /// </summary>
        string[] GetDataFilesInBarFolder(string barFolderPath);
    }


}
