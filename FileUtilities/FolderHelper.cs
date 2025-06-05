using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileUtilities
{
    internal class FolderHelper
    {
        #region Path Function - Folder

        /// <summary>
        /// 輸入資料夾路徑，可得到資料夾內的子資料夾路徑。
        /// </summary>
        /// <param name="mainFolderPath"></param>
        /// <param name="folderPaths"></param>
        public static void GetAllFolderPath(string mainFolderPath, out string[] folderPaths)
        {
            folderPaths = Directory.GetDirectories(mainFolderPath);
        }

        /// <summary>
        /// 輸入一陣列，陣列中帶有多個資料夾路徑，可得到資料夾名稱。
        /// </summary>
        /// <param name="folderPaths"></param>
        /// <param name="folderNames"></param>
        public static void GetAllFolderName(string[] folderPaths, out List<string> folderNames)
        {
            folderNames = new List<string>();
            folderNames.Clear();

            // 逐一處理每個資料夾路徑
            foreach (string folderPath in folderPaths)
            {
                // 檢查資料夾是否存在
                if (Directory.Exists(folderPath))
                {
                    // 使用 Path.GetFileName 取得資料夾名稱
                    string folderName = Path.GetFileName(folderPath.TrimEnd(Path.DirectorySeparatorChar));
                    folderNames.Add(folderName);
                }
            }
        }

        /// <summary>
        /// 輸入資料夾路徑，可得到資料夾名稱。
        /// </summary>
        /// <param name="folderPath"></param>
        /// <returns></returns>
        public static string GetFolderName(string folderPath)
        {
            // 使用 DirectoryInfo 取得資料夾資訊
            DirectoryInfo directoryInfo = new DirectoryInfo(folderPath);

            // 回傳資料夾名稱
            return directoryInfo.Name;
        }

        #endregion
    }
}
