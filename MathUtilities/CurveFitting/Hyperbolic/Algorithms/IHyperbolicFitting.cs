using MathUtilities.CurveFitting.Hyperbolic.Models;

namespace MathUtilities.CurveFitting.Hyperbolic.Algorithms
{
    public interface IHyperbolicFitting
    {
        HyperbolicParameter Fit(double[] x, double[] y);
    }
}