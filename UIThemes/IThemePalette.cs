using System;
using System.Collections.Generic;
using System.Drawing;

namespace UIThemes
{
    /// <summary>
    /// Defines the UI palette for themes, including colors, fonts, borders, and shadows.
    /// 定義 UI 主題的調色盤，包含顏色、字型、邊框、陰影等屬性。
    /// </summary>
    public interface IThemePalette
    {
        // 顏色
        Color Background { get; }
        Color Foreground { get; }
        Color MenuBackground { get; }
        Color MenuForeground { get; }
        Color Accent { get; }
        Color BorderColor { get; }
        Color ShadowColor { get; }

        // 字型
        Font MenuFont { get; }
        Font DisplayFont { get; }
        Font ButtonFont { get; }

        // 邊框與陰影
        int BorderThickness { get; }
        int CornerRadius { get; }
        int ShadowSize { get; }

        // 可再擴充更多屬性（如透明度、Hover顏色、選取顏色等）
    }

}
