using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIThemes
{
    /// <summary>
    /// Manages the active UI theme and notifies controls when the theme changes.
    /// 管理目前使用中的主題，當主題切換時通知所有訂閱者（如自訂控件）。
    /// </summary>
    public static class ThemeManager
    {
        /// <summary>
        /// The currently active theme palette.
        /// 目前啟用的主題調色盤。
        /// </summary>
        public static IThemePalette Current { get; private set; }

        /// <summary>
        /// Occurs when the UI theme has changed.
        /// 主題切換時觸發的事件，供 UI 控件自動刷新樣式。
        /// </summary>
        public static event Action<IThemePalette> ThemeChanged;

        /// <summary>
        /// Set a new UI theme. All controls listening to ThemeChanged will update automatically.
        /// 設定新主題，所有註冊 ThemeChanged 的控件都會自動刷新樣式。
        /// </summary>
        public static void SetTheme(IThemePalette theme)
        {
            Current = theme;
            if (ThemeChanged != null)
                ThemeChanged(theme);  // 通知所有已訂閱的控件（或管理者）
        }
    }


}
