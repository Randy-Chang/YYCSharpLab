using System;
using System.Collections.Generic;
using System.Drawing;

namespace YYCSharpLab.UIFramework.Core
{
    public class DefaultThemeManager : IThemeManager
    {
        private readonly Random _rand = new Random();
        private int _lastIndex = -1;

        public IList<string> ColorList { get; private set; }

        public Color CurrentColor { get; private set; }

        public event Action<Color> ThemeChanged;

        public DefaultThemeManager()
        {
            ColorList = new List<string>
            {
                "#3F51B5", "#009688", "#FF5722", "#607D8B", "#FF9800"
            };
            CurrentColor = ColorTranslator.FromHtml(ColorList[0]);
        }

        public Color GetNextThemeColor()
        {
            if (ColorList.Count == 0) return CurrentColor;
            int index;
            do { index = _rand.Next(ColorList.Count); } while (index == _lastIndex);

            _lastIndex = index;
            Color color = ColorTranslator.FromHtml(ColorList[index]);
            SetCurrentColor(color);
            return color;
        }

        public void SetCurrentColor(Color color)
        {
            if (color != CurrentColor)
            {
                CurrentColor = color;
                if (ThemeChanged != null)
                    ThemeChanged(color);
            }
        }
    }
}
