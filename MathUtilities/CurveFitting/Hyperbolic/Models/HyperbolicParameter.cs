using System;
using MathUtilities.CurveFitting.Models;

namespace MathUtilities.CurveFitting.Hyperbolic.Models
{
    public class HyperbolicParameter : CurveParameter
    {
        public double SH { get; set; }
        public double DeltaSH { get; set; }

        public override string Describe()
        {
            return $"Hyperbolic: SH={SH:F4}, ΔSH={DeltaSH:F4}";
        }
    }
}