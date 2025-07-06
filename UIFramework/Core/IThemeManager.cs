using System;
using System.Collections.Generic;
using System.Drawing;

namespace YYCSharpLab.UIFramework.Core
{
    public interface IThemeManager
    {
        Color CurrentColor { get; }
        IList<string> ColorList { get; }

        Color GetNextThemeColor();
        void SetCurrentColor(Color color);

        event Action<Color> ThemeChanged;
    }
}
