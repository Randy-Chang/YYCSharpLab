using MathUtilities.CurveFitting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
