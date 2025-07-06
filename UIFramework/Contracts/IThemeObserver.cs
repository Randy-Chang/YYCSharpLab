using System.Drawing;

namespace YYCSharpLab.UIFramework.Contracts
{
    public interface IThemeObserver
    {
        void OnThemeChanged(Color newColor);
    }
}
