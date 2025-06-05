using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathUtilities.CurveFitting
{
    /// <summary>
    /// 使用兩點法擬合高斯分佈
    /// </summary>
    public class TwoPointFitting : IGaussianFitting
    {
        double ampRatio = 0.5; // 這裡可以讓使用者輸入，單位[%]

        #region 實作IGaussianFitting
        /// <summary>
        /// 設定振幅比例條件
        /// </summary>
        /// <param name="ampRatio">振幅比例</param>
        public void InputAmpRatioConditionByTwoPoint(double ampRatio)
        {
            this.ampRatio = ampRatio;
        }

        /// <summary>
        /// 執行高斯擬合
        /// </summary>
        /// <param name="xData">X 軸數據</param>
        /// <param name="yData">Y 軸數據</param>
        /// <param name="gaussianParameter">輸出的高斯參數</param>
        public void Fit(List<double> xData, List<double> yData, out GaussianParameter gaussianParameter)
        {
            TwoPointMethod(xData, yData, ampRatio, out gaussianParameter);
        }
        #endregion

        #region Calculate Function
        /// <summary>
        /// 使用兩點法計算高斯參數
        /// </summary>
        /// <param name="xData">X 軸數據</param>
        /// <param name="yData">Y 軸數據</param>
        /// <param name="ampRatio">振幅比例</param>
        /// <param name="gaussianParameter">輸出的高斯參數</param>
        private void TwoPointMethod(List<double> xData, List<double> yData, double ampRatio,
                                                    out GaussianParameter gaussianParameter)
        {
            double Max = yData.Max();
            double Target = Max * ampRatio;
            int indexMax = yData.IndexOf(Max);

            double xLeft = FindLeftPoint(Target, indexMax, xData, yData);
            double xRight = FindRightPoint(Target, indexMax, xData, yData);

            double amp = Max;
            double mu = xData[indexMax];
            double sigma = Math.Sqrt((Math.Pow(xRight - mu, 2) + Math.Pow(xLeft - mu, 2)) / (2 * Math.Log(2)));

            gaussianParameter = new GaussianParameter { amp = amp, mu = mu, sigma = sigma };
        }

        /// <summary>
        /// 找到左側點
        /// </summary>
        /// <param name="Target">目標振幅值</param>
        /// <param name="indexMax">最大值索引</param>
        /// <param name="xData">X 軸數據</param>
        /// <param name="yData">Y 軸數據</param>
        /// <returns>左側對應的 X 軸數值</returns>
        private double FindLeftPoint(double Target, int indexMax, List<double> xData, List<double> yData)
        {
            for (int i = indexMax; i >= 0; i--)
            {
                if (yData[i] <= Target) return xData[i];
            }
            return xData[0];
        }

        /// <summary>
        /// 找到右側點
        /// </summary>
        /// <param name="Target">目標振幅值</param>
        /// <param name="indexMax">最大值索引</param>
        /// <param name="xData">X 軸數據</param>
        /// <param name="yData">Y 軸數據</param>
        /// <returns>右側對應的 X 軸數值</returns>
        private double FindRightPoint(double Target, int indexMax, List<double> xData, List<double> yData)
        {
            for (int i = indexMax; i < yData.Count; i++)
            {
                if (yData[i] <= Target) return xData[i];
            }
            return xData[xData.Count - 1];
        }
        #endregion

    }
}
