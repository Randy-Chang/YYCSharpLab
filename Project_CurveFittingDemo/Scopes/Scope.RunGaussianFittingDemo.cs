using System;
using System.Collections.Generic;
using System.Linq;
using MathUtilities.CurveFitting.Core;
using MathUtilities.CurveFitting.Factory;
using MathUtilities.CurveFitting.Gaussian;
using MathUtilities.CurveFitting.Hyperbolic;
using MathUtilities.CurveFitting.Hyperbolic.Models;
using MathUtilities.Simulation;
using Project_CurveFittingDemo.Interfaces;

namespace Project_CurveFittingDemo.Scopes
{
    public partial class Scope
    {
        public void RunGaussianFittingDemo(IPanelChartPresenter chart)
        {
            chart.Clear();

            // 1. 產生模擬資料
            GaussianDataGenerator.Generate(
                amplitude: 1.0,
                mean: 0.0,
                stdDev: 10.0,
                pointCount: 201,
                noiseStd: 0.05,
                out var x, out var y
            );

            chart.AddCurve("Raw Data", x, y, isScatter: true);

            PlotFittingCurve(chart, x, y);
        }

        private void PlotFittingCurve(IPanelChartPresenter chart, double[] x, double[] y)
        {
            // 2. Gaussian 擬合策略清單
            var strategiesGaussian = new List<(string name, object alg)>
            {
                ("Caruana", EGaussianAlgorithm.Caruana),
                ("Guo", EGaussianAlgorithm.Guo),
                ("TwoPoint", EGaussianAlgorithm.TwoPoint)
            };

            // 3. 加入 Gaussian 曲線
            foreach (var (name, alg) in strategiesGaussian)
            {
                var fitter = CurveFittingFactory.CreateFitter(ECurveType.Gaussian, alg);
                var result = fitter.Fit(x, y);

                // 計算擬合曲線
                double[] yFit = EvaluateGaussian(result as GaussianParameter, x);
                chart.AddCurve(name, x, yFit);
            }

            // 4. Hyperbolic 擬合策略清單
            var strategiesHyperbolic = new List<(string name, object alg)>
            {
                ("SechSquared", EHyperbolicAlgorithm.SechSquared),
            };

            // 5. 加入 Hyperbolic 曲線
            {
                foreach (var (name, alg) in strategiesHyperbolic)
                {
                    var fitter = CurveFittingFactory.CreateFitter(ECurveType.Hyperbolic, alg);
                    var resultH = fitter.Fit(x, y);
                    double[] yFit = EvaluateHyperbolic(resultH as HyperbolicParameter, x);
                    chart.AddCurve("SechSquared", x, yFit);
                }

                //var param = new HyperbolicParameter { SH = 1.0, DeltaSH = 15.0 };
                //double[] yFit_test = EvaluateHyperbolic(param, x);
                //chart.AddCurve("Test Hyperbolic", x, yFit_test);
            }
        }

        private double[] EvaluateGaussian(GaussianParameter param, double[] x)
        {
            double[] y = new double[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                y[i] = param.Amplitude * Math.Exp(-Math.Pow(x[i] - param.Mean, 2) / (2 * param.StdDev * param.StdDev));
            }
            return y;
        }

        private double[] EvaluateHyperbolic(HyperbolicParameter param, double[] x)
        {
            double[] y = new double[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                double inner = x[i] / param.DeltaSH;
                double sech = 1.0 / Math.Cosh(inner);
                y[i] = param.SH * sech * sech; // sech^2(x)
            }
            return y;
        }


    }
}
