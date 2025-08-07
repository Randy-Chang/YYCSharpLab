using System;
using MathUtilities.CurveFitting.Core;
using MathUtilities.CurveFitting.Models;

namespace MathUtilities.CurveFitting.Gaussian
{
    public class GaussianFittingStrategyFactory : ICurveFittingStrategyFactory
    {
        public ICurveFitter CreateFitter(object algorithm = null)
        {
            IGaussianFitting strategy;

            if (algorithm is EGaussianAlgorithm algEnum)
                strategy = GaussianAlgorithmFactory.Create(algEnum);
            else if (algorithm is Tuple<EGaussianAlgorithm, object> tuple)
                strategy = GaussianAlgorithmFactory.Create(tuple.Item1, tuple.Item2);
            else
                strategy = GaussianAlgorithmFactory.Create(EGaussianAlgorithm.Caruana);

            return new GaussianFitter(strategy);
        }
    }
}
