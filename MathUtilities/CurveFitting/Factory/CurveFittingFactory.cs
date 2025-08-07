using System;
using System.Collections.Generic;
using MathUtilities.CurveFitting.Core;
using MathUtilities.CurveFitting.Gaussian;
using MathUtilities.CurveFitting.Hyperbolic;
using MathUtilities.CurveFitting.Models;

namespace MathUtilities.CurveFitting.Factory
{
    public static class CurveFittingFactory
    {
        private static readonly Dictionary<ECurveType, ICurveFittingStrategyFactory> _factoryMap
            = new Dictionary<ECurveType, ICurveFittingStrategyFactory>
            {
                { ECurveType.Gaussian, new GaussianFittingStrategyFactory() },
                { ECurveType.Hyperbolic, new HyperbolicFittingStrategyFactory() }
            };

        public static ICurveFitter CreateFitter(ECurveType type, object algorithm = null)
        {
            if (_factoryMap.TryGetValue(type, out var factory))
            {
                return factory.CreateFitter(algorithm);
            }

            throw new NotSupportedException($"Curve type '{type}' is not supported.");
        }
    }
}
