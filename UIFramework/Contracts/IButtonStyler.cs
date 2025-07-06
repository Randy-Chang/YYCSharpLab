using System.Drawing;

namespace YYCSharpLab.UIFramework.Contracts
{
    public interface IButtonStyler
    {
        void ApplyActiveStyle(object buttonKey, Color themeColor);
        void ResetStyle(object buttonKey);
    }
}
