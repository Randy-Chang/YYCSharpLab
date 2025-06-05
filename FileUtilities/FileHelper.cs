using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileUtilities
{
    public class FileHelper
    {
        #region Path Function - File

        /// <summary>
        /// 輸入資料夾路徑，可得到資料夾內的檔案路徑。
        /// </summary>
        /// <param name="folderPath"></param>
        /// <param name="filePaths"></param>
        /// <param name="searchPattern"></param>
        public static void GetAllFilePath(string folderPath, out string[] filePaths, string searchPattern = "")
        {
            if (searchPattern == "")
            {
                filePaths = Directory.GetFiles(folderPath);
            }
            else
            {
                filePaths = Directory.GetFiles(folderPath, "*.jpg");
            }

        }

        /// <summary>
        /// 輸入一陣列，陣列中帶有多個檔案路徑，可得到檔案名稱。
        /// </summary>
        /// <param name="filePaths"></param>
        /// <param name="filesNames"></param>
        public static void GetAllFileName(string[] filePaths, out List<string> filesNames)
        {
            filesNames = new List<string>();
            filesNames.Clear();

            // 逐一處理每個資料夾路徑
            foreach (string filePath in filePaths)
            {
                // 檢查資料夾是否存在
                if (File.Exists(filePath))
                {
                    // 使用 Path.GetFileName 取得資料夾名稱
                    string Name = Path.GetFileNameWithoutExtension(filePath);
                    filesNames.Add(Name);
                }
            }
        }

        /// <summary>
        /// 輸入檔案路徑，可得到檔案名稱。
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static string GetFileName(string filePath)
        {
            // 使用 Path.GetFileName 取得檔案名稱
            string Name = Path.GetFileNameWithoutExtension(filePath);

            // 回傳檔案名稱
            return Name;
        }

        #endregion
    }
}
