using System;
using System.IO;
using System.Linq;

namespace YYCSharpLab.CompressionUtilities
{
    /// <summary>
    /// 提供 zip 檔案版本（檔名）查詢服務（支援 .NET Framework 4.8）。
    /// </summary>
    public class ZipFileVersionService
    {
        /// <summary>
        /// 查詢指定資料夾下所有 zip 檔案（檔名排序），並回傳 zip 檔名陣列。
        /// </summary>
        /// <param name="folderPath">目標資料夾路徑。</param>
        /// <returns>所有 zip 檔名（不含路徑），無則回傳空陣列。</returns>
        public string[] GetZipVersions(string folderPath)
        {
            if (!Directory.Exists(folderPath)) return new string[0];

            return Directory.GetFiles(folderPath, "*.zip")
                            .Select(Path.GetFileName)
                            .OrderBy(v => v)
                            .ToArray();
        }
    }
}
