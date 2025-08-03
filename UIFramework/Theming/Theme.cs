using System.Drawing;

namespace UIFramework.Theming
{
    /// <summary>
    /// 定義應用程式主題的屬性資料。
    /// 此類僅作為資料模型，不包含邏輯。
    /// </summary>
    public class Theme
    {
        /// <summary>
        /// 主題類型。
        /// </summary>
        public ThemeType Type { get; set; } = ThemeType.Default;

        /// <summary>
        /// 預設背景顏色。
        /// </summary>
        public Color BackgroundColor { get; set; }

        /// <summary>
        /// 預設前景顏色。
        /// </summary>
        public Color ForegroundColor { get; set; }

        /// <summary>
        /// 預設字型。
        /// </summary>
        public Font DefaultFont { get; set; }
    }
}
