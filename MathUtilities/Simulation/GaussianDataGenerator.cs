using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathUtilities.Simulation
{
    public static class GaussianDataGenerator
    {
        /// <summary>
        /// 產生帶雜訊的高斯曲線資料。
        /// </summary>
        /// <param name="amplitude">高斯曲線的振幅（A）</param>
        /// <param name="mean">高斯曲線的中心位置（μ），通常對應於光軸角度</param>
        /// <param name="stdDev">標準差（σ），控制光束發散程度</param>
        /// <param name="pointCount">欲產生的資料點數（會平均分佈在 −45° 到 +45° 之間）</param>
        /// <param name="noiseStd">加在每一筆資料上的隨機雜訊標準差</param>
        /// <param name="x">輸出的 X 軸資料陣列（角度，單位：度）</param>
        /// <param name="y">輸出的 Y 軸資料陣列（光強度）</param>
        /// <remarks>
        /// 此函式使用隨機亂數加入雜訊，因此每次呼叫結果可能不同。如需重現性，可考慮增加 seed 控制。
        /// </remarks>
        public static void Generate(double amplitude, double mean, double stdDev, int pointCount, double noiseStd,
                                    out double[] x, out double[] y)
        {
            x = new double[pointCount];
            y = new double[pointCount];

            double step = 90.0 / (pointCount - 1); // -45° to 45°

            var rand = new Random();

            for (int i = 0; i < pointCount; i++)
            {
                x[i] = -45.0 + i * step;
                double trueY = amplitude * Math.Exp(-Math.Pow(x[i] - mean, 2) / (2 * stdDev * stdDev));
                double noise = noiseStd * (rand.NextDouble() * 2 - 1); // ±noiseStd
                y[i] = trueY + noise;
            }
        }
    }

}
