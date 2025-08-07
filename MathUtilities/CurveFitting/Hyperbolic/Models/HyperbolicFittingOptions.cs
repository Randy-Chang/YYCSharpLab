using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathUtilities.CurveFitting.Hyperbolic.Models
{
    public class SechSquaredOptions
    {
        /// <summary>
        /// 半高寬轉換係數（預設為 0.8814）
        /// </summary>
        public double FwhmCoefficient { get; set; } = 0.8814;
    }
}
