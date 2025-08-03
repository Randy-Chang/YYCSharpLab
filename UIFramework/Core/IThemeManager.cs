using System;
using System.Collections.Generic;
using System.Linq;
using UIFramework.Theming;


namespace UIFramework.Theming
{
    /// <summary>
    /// 定義主題管理器的功能，負責管理應用程式主題並發送變更通知。
    /// </summary>
    public interface IThemeManager
    {
        /// <summary>
        /// 目前的主題。
        /// </summary>
        Theme CurrentTheme { get; }

        /// <summary>
        /// 設定新的主題。
        /// </summary>
        /// <param name="theme">新的主題設定。</param>
        void SetTheme(Theme theme);

        /// <summary>
        /// 根據主題類型設定預設主題。
        /// </summary>
        /// <param name="type">預設主題類型。</param>
        void SetTheme(ThemeType type);

        /// <summary>
        /// 當主題變更時觸發，傳遞新的主題物件。
        /// </summary>
        event Action<Theme> ThemeChanged;
    }
}
