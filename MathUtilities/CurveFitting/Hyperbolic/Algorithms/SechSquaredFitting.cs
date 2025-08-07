using System;
using System.Linq;
using MathUtilities.CurveFitting.Hyperbolic.Models;
using MathUtilities.CurveFitting.Models;

namespace MathUtilities.CurveFitting.Hyperbolic.Algorithms
{
    public class SechSquaredFitting : IHyperbolicFitting
    {
        private readonly double _fwhmCoefficient; // 理論值 0.8814

        public SechSquaredFitting(SechSquaredOptions options = null)
        {
            _fwhmCoefficient = options?.FwhmCoefficient ?? 0.8814; // fallback to default
        }

        public HyperbolicParameter Fit(double[] x, double[] y)
        {
            if (x == null || y == null || x.Length != y.Length || x.Length < 3)
                throw new ArgumentException("Invalid input data.");

            // 1. 找到最大點 (Peak)
            int peakIndex = Array.IndexOf(y, y.Max());
            double yPeak = y[peakIndex];
            double thetaPeak = x[peakIndex];

            // 2. 計算 Half-Max 水準
            double halfMax = yPeak * 0.5;

            // 3. 向左找到第一個小於等於 halfMax 的點
            int leftIndex = -1;
            for (int i = peakIndex; i >= 0; i--)
            {
                if (y[i] <= halfMax)
                {
                    leftIndex = i;
                    break;
                }
            }

            // 4. 向右找到第一個小於等於 halfMax 的點
            int rightIndex = -1;
            for (int i = peakIndex; i < y.Length; i++)
            {
                if (y[i] <= halfMax)
                {
                    rightIndex = i;
                    break;
                }
            }

            // 5. 找不到半高點就拋錯（可能資料太雜訊）
            if (leftIndex == -1 || rightIndex == -1)
                throw new InvalidOperationException("Cannot find FWHM boundary points.");

            double thetaLeft = x[leftIndex];
            double thetaRight = x[rightIndex];

            // 6. 計算 SH 與 ΔSH
            double SH = yPeak;  // SH 為 peak 高度
            double deltaSH = Math.Abs(thetaRight - thetaLeft) / 2.0 / _fwhmCoefficient;

            return new HyperbolicParameter
            {
                SH = SH,
                DeltaSH = deltaSH
            };
        }

    }
}