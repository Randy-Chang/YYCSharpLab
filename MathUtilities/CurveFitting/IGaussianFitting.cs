using System.Collections.Generic;


namespace MathUtilities.CurveFitting
{
    public interface IGaussianFitting
    {
        void InputAmpRatioConditionByTwoPoint(double ampRatio);

        void Fit(List<double> xData, List<double> yData, out GaussianParameter gaussianParameter);
    }

}
