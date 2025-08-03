using System.Drawing;

namespace UIFramework.Theming
{
    /// <summary>
    /// 定義主題資料結構。
    /// </summary>
    public class Theme
    {
        /// <summary>
        /// 主題名稱（例如：Default、Dark、Light）。
        /// </summary>
        public string Name { get; set; } = "Default";

        /// <summary>
        /// 背景顏色。
        /// </summary>
        public Color BackgroundColor { get; set; } = Color.FromArgb(0, 37, 85);

        /// <summary>
        /// 前景顏色。
        /// </summary>
        public Color ForegroundColor { get; set; } = Color.White;

        /// <summary>
        /// 預設字型。
        /// </summary>
        public Font DefaultFont { get; set; } = SystemFonts.DefaultFont;
    }
}
