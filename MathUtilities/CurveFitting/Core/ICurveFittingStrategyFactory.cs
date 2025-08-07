
using MathUtilities.CurveFitting.Models;

namespace MathUtilities.CurveFitting.Core
{
    public interface ICurveFittingStrategyFactory
    {
        ICurveFitter CreateFitter(object algorithm = null);
    }
}

