using System;
using MathUtilities.CurveFitting.Gaussian;

namespace MathUtilities.CurveFitting
{
    public static class CurveFittingFactory
    {
        /// <summary>
        /// 建立曲線擬合器（Gaussian）
        /// </summary>
        /// <param name="type">曲線類型（目前僅支援 Gaussian）</param>
        /// <param name="algorithm">演算法選擇（EGaussianAlgorithm 或 Tuple）</param>
        public static ICurveFitter CreateFitter(ECurveType type, object algorithm = null)
        {
            switch (type)
            {
                case ECurveType.Gaussian:
                    // 把演算法選擇丟給 GaussianAlgorithmFactory
                    IGaussianFitting strategy;

                    if (algorithm is EGaussianAlgorithm algEnum)
                    {
                        strategy = GaussianAlgorithmFactory.Create(algEnum);
                    }
                    else if (algorithm is Tuple<EGaussianAlgorithm, object> tuple)
                    {
                        strategy = GaussianAlgorithmFactory.Create(tuple.Item1, tuple.Item2);
                    }
                    else
                    {
                        strategy = GaussianAlgorithmFactory.Create(EGaussianAlgorithm.Caruana);
                    }

                    return new GaussianFitter(strategy);

                default:
                    throw new NotSupportedException($"Curve type '{type}' is not supported.");
            }
        }
    }
}
