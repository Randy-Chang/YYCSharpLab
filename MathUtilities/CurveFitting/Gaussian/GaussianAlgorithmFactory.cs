using MathUtilities.Algorithms;
using System;

namespace MathUtilities.CurveFitting.Gaussian
{
    /// <summary>
    /// 根據 enum 建立對應的 IGaussianFitting 策略
    /// </summary>
    public static class GaussianAlgorithmFactory
    {
        public static IGaussianFitting Create(EGaussianAlgorithm algorithm, object options = null)
        {
            switch (algorithm)
            {
                case EGaussianAlgorithm.Caruana:
                    return new CaruanasAlgorithmFitting();

                case EGaussianAlgorithm.Guo:
                    return new GuosAlgorithmFitting();

                case EGaussianAlgorithm.TwoPoint:
                    double ampRatio = options is double r ? r : 0.5;
                    return new TwoPointFitting(ampRatio);

                default:
                    throw new NotSupportedException($"Algorithm '{algorithm}' is not supported.");
            }
        }
    }
}
