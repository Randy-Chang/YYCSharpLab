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
        public Theme CurrentTheme { get; private set; } = new Theme();

        /// <summary>
        /// 當主題變更時觸發。
        /// </summary>
        public event Action<Theme> ThemeChanged;

        /// <summary>
        /// 設定新的主題並通知訂閱者。
        /// </summary>
        /// <param name="theme">新的主題設定。</param>
        public void SetTheme(Theme theme)
        {
            if (theme == null) throw new ArgumentNullException(nameof(theme));

            CurrentTheme = theme;
            ThemeChanged?.Invoke(theme);
        }
    }
}
