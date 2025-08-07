using MathUtilities.CurveFitting.Hyperbolic.Algorithms;
using MathUtilities.CurveFitting.Hyperbolic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathUtilities.CurveFitting.Hyperbolic
{
    public static class HyperbolicAlgorithmFactory
    {
        public static IHyperbolicFitting Create(EHyperbolicAlgorithm algorithm, object options = null)
        {
            switch (algorithm)
            {
                case EHyperbolicAlgorithm.SechSquared:
                    return new SechSquaredFitting(options as SechSquaredOptions);

                // 加入其他演算法：
                // case EHyperbolicAlgorithm.Tanh:
                //     return new TanhFitting(...);

                default:
                    throw new NotImplementedException($"Algorithm {algorithm} not implemented");
            }
        }
    }
}
