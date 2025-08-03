using System;
using UIFramework.Core;

namespace UIFramework.Theming
{
    /// <summary>
    /// 主題管理器，負責管理應用程式主題並通知訂閱者。
    /// </summary>
    public class ThemeManager : IThemeManager
    {
        /// <summary>
        /// 目前的主題。
        /// </summary>
        public Theme CurrentTheme { get; private set; } = ThemePresets.Default;

        /// <summary>
        /// 當主題變更時觸發。
        /// </summary>
        public event Action<Theme> ThemeChanged;

        /// <summary>
        /// 設定新的主題。
        /// </summary>
        public void SetTheme(Theme theme)
        {
            if (theme == null) throw new ArgumentNullException(nameof(theme));

            CurrentTheme = theme;
            ThemeChanged?.Invoke(theme);
        }

        /// <summary>
        /// 根據主題類型設定預設主題。
        /// </summary>
        public void SetTheme(ThemeType type)
        {
            switch (type)
            {
                case ThemeType.Dark:
                    SetTheme(ThemePresets.Dark);
                    break;
                case ThemeType.Light:
                    SetTheme(ThemePresets.Light);
                    break;
                default:
                    SetTheme(ThemePresets.Default);
                    break;
            }
        }
    }
}
