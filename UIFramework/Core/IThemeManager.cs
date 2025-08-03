using System;
using System.Collections.Generic;
using System.Linq;
using UIFramework.Theming;


namespace UIFramework.Core
{
    /// <summary>
    /// 提供主題管理與事件通知的介面。
    /// </summary>
    public interface IThemeManager
    {
        /// <summary>
        /// 目前使用的主題。
        /// </summary>
        Theme CurrentTheme { get; }

        /// <summary>
        /// 設定新的主題並觸發通知。
        /// </summary>
        /// <param name="theme">要套用的新主題。</param>
        void SetTheme(Theme theme);

        /// <summary>
        /// 當主題變更時觸發，通知訂閱者更新 UI。
        /// </summary>
        event Action<Theme> ThemeChanged;
    }
}
