

using MathUtilities.CurveFitting.Hyperbolic.Models;
using MathUtilities.CurveFitting.Models;

namespace MathUtilities.CurveFitting.Hyperbolic.Algorithms
{
    public class HyperbolicFitter : ICurveFitter
    {
        public string Name => "Hyperbolic";
        private readonly IHyperbolicFitting _algorithm;

        public HyperbolicFitter(object options = null)
        {
            var fittingOptions = options as SechSquaredOptions;
            _algorithm = new SechSquaredFitting(fittingOptions);  // 注入 FWHM 設定
        }

        public CurveParameter Fit(double[] x, double[] y)
        {
            IHyperbolicFitting fitter = new SechSquaredFitting();

            return fitter.Fit(x, y);
        }
    }
}