using System;
using System.IO;
using System.IO.Compression;
using System.Linq;

namespace YYCSharpLab.CompressionUtilities
{
    /// <summary>
    /// 提供 zip 壓縮檔的解壓縮與目標資料夾清理功能（支援 .NET Framework 4.8）。
    /// 解壓時若有唯一最上層資料夾，會先自動刪除後再解壓。解壓完成自動刪除 zip 檔。
    /// </summary>
    public class ZipFileExtractService
    {
        /// <summary>
        /// 解壓縮指定的 zip 檔案至目標資料夾，解壓前若有唯一最上層資料夾則先刪除之，解壓後刪除原 zip 檔。
        /// </summary>
        /// <param name="zipPath">zip 檔案路徑。</param>
        /// <param name="extractTo">要解壓縮到的目標資料夾。</param>
        public void ExtractAndClean(string zipPath, string extractTo)
        {
            string topLevelFolderName = GetTopLevelFolderName(zipPath);

            if (!string.IsNullOrEmpty(topLevelFolderName))
            {
                string folderToDelete = Path.Combine(extractTo, topLevelFolderName);

                if (Directory.Exists(folderToDelete))
                    Directory.Delete(folderToDelete, true);
            }

            ZipFile.ExtractToDirectory(zipPath, extractTo);
            File.Delete(zipPath);
        }

        /// <summary>
        /// 嘗試從 zip 檔案中取得唯一最上層資料夾名稱，若不唯一則回傳 null。
        /// </summary>
        /// <param name="zipPath">zip 檔案路徑。</param>
        /// <returns>唯一的最上層資料夾名稱；若無或不唯一則回傳 null。</returns>
        private string GetTopLevelFolderName(string zipPath)
        {
            using (var archive = ZipFile.OpenRead(zipPath))
            {
                var topLevelNames = archive.Entries
                    .Select(e =>
                    {
                        var split = e.FullName.Split(new[] { '/', '\\' }, StringSplitOptions.RemoveEmptyEntries);
                        return split.Length > 0 ? split[0] : null;
                    })
                    .Where(name => !string.IsNullOrWhiteSpace(name))
                    .Distinct()
                    .ToList();

                return topLevelNames.Count == 1 ? topLevelNames.First() : null; // 修正：使用 First() 取代 topLevelNames[0]
            }
        }
    }
}
