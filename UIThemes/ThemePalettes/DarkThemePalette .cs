using System.Drawing;

namespace UIThemes.Themes
{

    /// <summary>
    /// 預設暗色主題調色盤。
    /// </summary>
    public class DarkThemePalette : IThemePalette
    {
        public Color Background => Color.FromArgb(30, 32, 34);
        public Color Foreground => Color.White;
        public Color MenuBackground => Color.FromArgb(40, 44, 52);
        public Color MenuForeground => Color.WhiteSmoke;
        public Color Accent => Color.FromArgb(0, 188, 212); // 青色 Accent
        public Color BorderColor => Color.FromArgb(60, 65, 70);
        public Color ShadowColor => Color.FromArgb(120, 0, 0, 0); // 濃黑陰影

        public Font MenuFont => new Font("Microsoft JhengHei", 14, FontStyle.Bold);
        public Font DisplayFont => new Font("Microsoft JhengHei", 12, FontStyle.Regular);
        public Font ButtonFont => new Font("Microsoft JhengHei", 12, FontStyle.Regular);

        public int BorderThickness => 1;
        public int CornerRadius => 8;
        public int ShadowSize => 8;
    }

}
