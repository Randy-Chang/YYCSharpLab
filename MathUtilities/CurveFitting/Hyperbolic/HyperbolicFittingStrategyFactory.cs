using MathUtilities.CurveFitting.Hyperbolic.Algorithms;
using MathUtilities.CurveFitting.Core;
using MathUtilities.CurveFitting.Models;
using MathUtilities.Algorithms;
using System;

namespace MathUtilities.CurveFitting.Hyperbolic
{
    public class HyperbolicFittingStrategyFactory : ICurveFittingStrategyFactory
    {
        public ICurveFitter CreateFitter(object algorithm = null)
        {
            IHyperbolicFitting strategy;

            if (algorithm is EHyperbolicAlgorithm algEnum)
            {
                strategy = HyperbolicAlgorithmFactory.Create(algEnum);
            }
            else if (algorithm is Tuple<EHyperbolicAlgorithm, object> tuple)
            {
                strategy = HyperbolicAlgorithmFactory.Create(tuple.Item1, tuple.Item2);
            }
            else
            {
                strategy = HyperbolicAlgorithmFactory.Create(EHyperbolicAlgorithm.SechSquared);
            }

            return new HyperbolicFitter(strategy);
        }
    }

}