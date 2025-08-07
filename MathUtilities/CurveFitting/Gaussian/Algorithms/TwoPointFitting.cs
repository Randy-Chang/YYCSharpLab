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
        private readonly double _ampRatio;

        /// <summary>
        /// 使用兩點法擬合高斯分佈
        /// </summary>
        /// <param name="ampRatio">振幅比例（建議 0.5）</param>
        public TwoPointFitting(double ampRatio = 0.5)
        {
            if (ampRatio <= 0 || ampRatio >= 1)
                throw new ArgumentOutOfRangeException(nameof(ampRatio), "Amp ratio must be between 0 and 1.");

            _ampRatio = ampRatio;
        }

        public GaussianParameter Fit(double[] x, double[] y)
        {
            if (x == null || y == null)
                throw new ArgumentNullException("Input arrays cannot be null.");
            if (x.Length != y.Length || x.Length < 3)
                throw new ArgumentException("Input arrays must be the same length and have at least 3 points.");

            var xList = new List<double>(x);
            var yList = new List<double>(y);

            GaussianParameter result;
            TwoPointMethod(xList, yList, _ampRatio, out result);
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
