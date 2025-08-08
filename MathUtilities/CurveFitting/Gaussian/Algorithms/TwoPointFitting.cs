using MathUtilities.Common;
using MathUtilities.CurveFitting.Gaussian;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MathUtilities.Algorithms
{
    /// <summary>
    /// 使用兩點法擬合高斯分佈
    /// </summary>
    public class TwoPointFitting : IGaussianFitting
    {
        /// <summary>
        /// 振幅比例（預設為 0.5）
        /// </summary>
        public double AmpRatio { get; set; } = 0.7;

        public GaussianParameter Fit(double[] x, double[] y)
        {
            if (x == null || y == null)
                throw new ArgumentNullException("Input arrays cannot be null.");
            if (x.Length != y.Length || x.Length < 3)
                throw new ArgumentException("Input arrays must be the same length and have at least 3 points.");

            var xList = new List<double>(x);
            var yList = new List<double>(y);

            GaussianParameter result;
            TwoPointMethod(xList, yList, AmpRatio, out result);
            return result;
        }

        private void TwoPointMethod(List<double> xData, List<double> yData, double ampRatio,
                                     out GaussianParameter gaussianParameter)
        {
            double max = yData.Max();
            double target = max * ampRatio;
            int indexMax = yData.IndexOf(max);

            double xLeft = MathUtils.FindLeftPoint(target, indexMax, xData, yData);
            double xRight = MathUtils.FindRightPoint(target, indexMax, xData, yData);

            double amp = max;
            double mu = xData[indexMax];
            double sigma = Math.Sqrt((Math.Pow(xRight - mu, 2) + Math.Pow(xLeft - mu, 2)) / (2 * Math.Log(2)));

            gaussianParameter = new GaussianParameter
            {
                Amplitude = amp,
                Mean = mu,
                StdDev = sigma
            };
        }
    }

}
