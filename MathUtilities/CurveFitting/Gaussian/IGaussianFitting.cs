using MathUtilities.CurveFitting.Models;

namespace MathUtilities.CurveFitting.Gaussian
{
    /// <summary>
    /// 所有高斯擬合策略的共用介面
    /// </summary>
    public interface IGaussianFitting
    {
        GaussianParameter Fit(double[] x, double[] y);
    }
}
