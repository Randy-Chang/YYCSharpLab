using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareUpdater.Utilities.ViewHost
{
    /// <summary>
    /// 提供預設主題色清單與亮度調整邏輯的實作。
    /// </summary>
    public class DefaultThemeColorProvider : IThemeColorProvider
    {
        public List<string> ColorList { get; }

        public DefaultThemeColorProvider(List<string> colorList)
        {
            ColorList = colorList ?? throw new ArgumentNullException(nameof(colorList));
        }

        /// <inheritdoc/>
        public Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;

            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }

            return Color.FromArgb(color.A, (int)red, (int)green, (int)blue);
        }

        /// <inheritdoc/>
        public List<Color> ColorObjects => ColorList
            .Select(ColorTranslator.FromHtml)
            .ToList();
    }

}
