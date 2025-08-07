using MathUtilities.CurveFitting.Models;

namespace MathUtilities.CurveFitting.Gaussian
{
    public class GaussianParameter : CurveParameter
    {
        public double Amplitude { get; set; }
        public double Mean { get; set; }
        public double StdDev { get; set; }

        public override string Describe()
        {
            return $"Gaussian: A={Amplitude}, μ={Mean}, σ={StdDev}";
        }
    }

}
