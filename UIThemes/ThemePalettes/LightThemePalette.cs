using System.Drawing;

namespace UIThemes.Themes
{
    
    /// <summary>
    /// 預設亮色主題調色盤。
    /// </summary>
    public class LightThemePalette : IThemePalette
    {
        public Color Background => Color.White;
        public Color Foreground => Color.Black;
        public Color MenuBackground => Color.FromArgb(245, 245, 245);
        public Color MenuForeground => Color.Black;
        public Color Accent => Color.FromArgb(33, 150, 243); // 藍色 Accent
        public Color BorderColor => Color.FromArgb(220, 220, 220);
        public Color ShadowColor => Color.FromArgb(50, 0, 0, 0); // 淺灰陰影

        public Font MenuFont => new Font("Microsoft JhengHei", 14, FontStyle.Bold);
        public Font DisplayFont => new Font("Microsoft JhengHei", 12, FontStyle.Regular);
        public Font ButtonFont => new Font("Microsoft JhengHei", 12, FontStyle.Regular);

        public int BorderThickness => 1;
        public int CornerRadius => 8;
        public int ShadowSize => 6;
    }

}
