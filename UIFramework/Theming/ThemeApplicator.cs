using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIFramework.Theming
{
    /// <summary>
    /// 負責將 Theme 套用到指定的 Control。
    /// </summary>
    public static class ThemeApplicator
    {
        /// <summary>
        /// 將主題套用到指定容器及其子控件。
        /// </summary>
        /// <param name="container">容器控制項。</param>
        /// <param name="theme">主題。</param>
        public static void Apply(Control container, Theme theme)
        {
            if (container == null || theme == null) return;

            container.BackColor = theme.BackgroundColor;
            container.ForeColor = theme.ForegroundColor;
            container.Font = theme.DefaultFont;

            foreach (Control child in container.Controls)
            {
                Apply(child, theme); // 遞迴套用到所有子控件
            }
        }
    }
}

