using System.Drawing;

namespace ImageProcessingUtilities
{
    public class ImageResizer
    {
        #region Image Peocessing 圖像處理
        /// <summary>
        /// 依照輸入寬度與目標圖片路徑，調整圖片大小並依照輸入儲存路徑儲存
        /// </summary>
        /// <param name="inputImagePath"></param>
        /// <param name="outputImagePath"></param>
        /// <param name="targetWidth"></param>
        public static void ResizeByWidthAndSaveImage(string inputImagePath, string outputImagePath, int targetWidth)
        {
            // 從指定路徑載入圖片
            using (Image originalImage = Image.FromFile(inputImagePath))
            {
                // 取得圖片的原始寬度和高度
                int originalWidth = originalImage.Width;
                int originalHeight = originalImage.Height;

                // 計算等比例縮放後的高度
                float ratio = (float)targetWidth / originalWidth;
                int targetHeight = (int)(originalHeight * ratio);

                // 調整圖片大小
                using (Bitmap resizedImage = new Bitmap(originalImage, new Size(targetWidth, targetHeight)))
                {
                    // 保存調整後的圖片到指定路徑
                    resizedImage.Save(outputImagePath);
                }
            }
        }
        #endregion
    }
}
