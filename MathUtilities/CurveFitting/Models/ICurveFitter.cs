using MathUtilities.CurveFitting.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathUtilities.CurveFitting.Models
{
    public interface ICurveFitter
    {
        string Name { get; }
        CurveParameter Fit(double[] x, double[] y);
    }
}
