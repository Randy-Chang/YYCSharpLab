using System;
using System.IO;
using System.Threading.Tasks;

namespace YYCSharpLab.CompressionUtilities
{
    /// <summary>
    /// 提供 zip 檔案下載/複製的非同步服務（支援 .NET Framework 4.8）。
    /// 支援進度回報（IProgress&lt;int&gt;），檔案讀寫皆採用同步開啟與非同步讀寫方式。
    /// </summary>
    public class ZipFileDownloadService
    {
        /// <summary>
        /// 非同步複製 zip 檔案，支援進度回報。
        /// </summary>
        /// <param name="source">來源 zip 檔案路徑。</param>
        /// <param name="destination">目標檔案路徑。</param>
        /// <param name="progress">（可選）進度回報（0~100）。</param>
        public async Task CopyZipAsync(string source, string destination, IProgress<int> progress = null)
        {
            const int bufferSize = 16384;
            byte[] buffer = new byte[bufferSize];
            long totalBytes = new FileInfo(source).Length;
            long copied = 0;

            using (var input = new FileStream(source, FileMode.Open, FileAccess.Read, FileShare.Read))
            using (var output = new FileStream(destination, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                int bytesRead;
                while ((bytesRead = await input.ReadAsync(buffer, 0, buffer.Length)) > 0)
                {
                    await output.WriteAsync(buffer, 0, bytesRead);
                    copied += bytesRead;

                    if (progress != null && totalBytes > 0)
                    {
                        int percent = (int)((copied * 100L) / totalBytes);
                        progress.Report(percent);
                    }
                }
            }
        }
    }
}
