using System.Drawing;

namespace UIFramework.Theming
{
    /// <summary>
    /// 提供框架內建的預設主題。
    /// </summary>
    public static class ThemePresets
    {
        /// <summary>
        /// 默認主題。
        /// </summary>
        public static Theme Default => new Theme
        {
            Type = ThemeType.Default,
            BackgroundColor = Color.FromArgb(0, 37, 85),
            ForegroundColor = Color.White,
            DefaultFont = new Font("Arial", 10, FontStyle.Bold)
        };

        /// <summary>
        /// 深色主題。
        /// </summary>
        public static Theme Dark => new Theme
        {
            Type = ThemeType.Dark,
            BackgroundColor = Color.Black,
            ForegroundColor = Color.White,
            DefaultFont = new Font("Arial", 10, FontStyle.Bold)
        };

        /// <summary>
        /// 亮色主題。
        /// </summary>
        public static Theme Light => new Theme
        {
            Type = ThemeType.Light,
            BackgroundColor = Color.White,
            ForegroundColor = Color.Black,
            DefaultFont = new Font("Segoe UI", 10, FontStyle.Regular)
        };
    }
}
