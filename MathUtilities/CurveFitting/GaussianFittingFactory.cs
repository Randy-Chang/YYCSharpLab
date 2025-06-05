using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathUtilities.CurveFitting
{
    /*
     * 參考文獻
     * COMPARISON OF ALGORITHMS FOR FITTING A GAUSSIAN FUNCTION USED IN TESTING SMART SENSORS
     * 網址 https://intapi.sciendo.com/pdf/10.2478/jee-2015-0029
     */

    public enum EMethod { TwoPoint, CaruanasAlgorithm, GuosAlgorithm }

    public static class GaussianFittingFactory
    {
        /// <summary>
        /// 根據指定的方法獲取對應的高斯擬合算法實現。
        /// </summary>
        /// <param name="method">高斯擬合方法的枚舉類型</param>
        /// <returns>對應的高斯擬合算法實例</returns>
        /// <exception cref="ArgumentException">當提供未知的方法時拋出異常</exception>
        public static IGaussianFitting GetFittingAlgorithm(EMethod method)
        {
            switch (method)
            {
                case EMethod.TwoPoint:
                    return new TwoPointFitting();
                case EMethod.CaruanasAlgorithm:
                    return new CaruanasAlgorithmFitting();
                case EMethod.GuosAlgorithm:
                    return new GuosAlgorithmFitting();
                default:
                    throw new ArgumentException("未知的高斯擬合方法");
            }
        }

        /// <summary>
        /// 產生帶有雜訊的高斯波形數據。
        /// </summary>
        /// <param name="xData">輸出的 X 軸數據</param>
        /// <param name="yData">輸出的 Y 軸數據</param>
        /// <param name="numPoints">資料點數，預設 1000</param>
        /// <param name="amplitude">高斯波振幅，預設 1.0</param>
        /// <param name="mean">高斯波均值，預設 0.0</param>
        /// <param name="stdDev">高斯波標準差，預設 1.0</param>
        /// <param name="noiseLevel">雜訊強度，預設 0.1</param>
        public static void GenerateNoisyGaussian(out List<double> xData, out List<double> yData,
                                                    int numPoints = 1000,
                                                    double amplitude = 1.0, double mean = 0.0,
                                                    double stdDev = 1.0, double noiseLevel = 0.1)
        {
            Random rand = new Random();
            xData = new List<double>(numPoints);
            yData = new List<double>(numPoints);

            for (int i = 0; i < numPoints; i++)
            {
                double x = (i - numPoints / 2.0) / (numPoints / 10.0); // x 軸範圍調整
                double gaussian = amplitude * Math.Exp(-Math.Pow(x - mean, 2) / (2 * Math.Pow(stdDev, 2)));
                double noise = noiseLevel * (rand.NextDouble() * 2 - 1); // 產生範圍為 [-noiseLevel, noiseLevel] 的雜訊
                xData.Add(x);
                yData.Add(gaussian + noise);
            }
        }

        /// <summary>
        /// 依據給定的 X 軸數據與高斯參數產生高斯波形數據（無雜訊）。
        /// </summary>
        /// <param name="xData">輸入的 X 軸數據</param>
        /// <param name="parameters">高斯曲線參數 (振幅、均值、標準差)</param>
        /// <param name="yData">輸出的 Y 軸數據</param>
        public static void GenerateGaussianCurve(List<double> xData, GaussianParameter parameters, out List<double> yData)
        {
            yData = new List<double>(xData.Count);

            foreach (var x in xData)
            {
                double gaussian = parameters.amp * Math.Exp(-Math.Pow(x - parameters.mu, 2) / (2 * Math.Pow(parameters.sigma, 2)));
                yData.Add(gaussian);
            }
        }

    }
}
