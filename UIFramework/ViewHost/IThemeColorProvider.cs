using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareUpdater.Utilities.ViewHost
{
    /// <summary>
    /// 提供主題顏色與亮度調整邏輯的介面。
    /// </summary>
    public interface IThemeColorProvider
    {
        /// <summary>
        /// 以十六進位格式（如 #RRGGBB）表示的主題色清單。
        /// </summary>
        List<string> ColorList { get; }

        /// <summary>
        /// 對指定顏色進行亮度修正。
        /// </summary>
        /// <param name="color">原始顏色</param>
        /// <param name="correctionFactor">亮度修正值（-1.0 ~ 1.0）</param>
        /// <returns>調整後的顏色</returns>
        Color ChangeColorBrightness(Color color, double correctionFactor);

        /// <summary>
        /// 將 ColorList 轉換為 Color 類型的清單。
        /// </summary>
        List<Color> ColorObjects { get; }
    }

}
