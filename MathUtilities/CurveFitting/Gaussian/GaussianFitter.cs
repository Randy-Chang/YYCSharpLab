using MathUtilities.Algorithms;
using MathUtilities.CurveFitting.Models;
using System;

namespace MathUtilities.CurveFitting.Gaussian
{
    /// <summary>
    /// 高斯擬合器，使用依賴注入注入演算法策略
    /// </summary>
    public class GaussianFitter : ICurveFitter
    {
        public string Name => "Gaussian";

        private readonly IGaussianFitting _algorithm;

        public GaussianFitter(IGaussianFitting algorithm)
        {
            _algorithm = algorithm ?? throw new ArgumentNullException(nameof(algorithm));
        }

        public CurveParameter Fit(double[] x, double[] y)
        {
            return _algorithm.Fit(x, y);
        }
    }
}
