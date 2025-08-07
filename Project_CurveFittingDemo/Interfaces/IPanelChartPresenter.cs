
namespace Project_CurveFittingDemo.Interfaces
{
    public interface IPanelChartPresenter
    {
        void AddCurve(string name, double[] x, double[] y, bool isScatter = false);
        void Clear();
    }
}

