using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using UIFramework.Core;

namespace UIFramework.Menu
{
    /// <summary>
    /// 控制選單行為的控制器，負責監聽 Menu 容器點擊並發出導航事件。
    /// </summary>
    public class MenuController : IMenuController
    {
        private Control _menuPanel;
        private Dictionary<string, string> _menuMappings = new Dictionary<string, string>();

        /// <summary>
        /// 當選單項目被點擊時觸發，參數為對應的 View Key。
        /// </summary>
        public event Action<string> MenuItemSelected;

        /// <summary>
        /// 初始化選單控制器並綁定至指定的選單容器。
        /// </summary>
        /// <param name="menuPanel">作為選單容器的控制項（例如 FlowLayoutPanel）。</param>
        public void Initialize(Control menuPanel)
        {
            _menuPanel = menuPanel ?? throw new ArgumentNullException(nameof(menuPanel));

            foreach (var control in _menuPanel.Controls.OfType<Button>())
            {
                control.Click += OnMenuItemClick;
            }
        }

        /// <summary>
        /// 設定選單項目與 View Key 的對應關係。
        /// </summary>
        /// <param name="mappings">選單 Key 與 View Key 的對應表。</param>
        public void SetMenuMappings(Dictionary<string, string> mappings)
        {
            _menuMappings = mappings ?? throw new ArgumentNullException(nameof(mappings));
        }

        private void OnMenuItemClick(object sender, EventArgs e)
        {
            if (sender is Button btn && _menuMappings.ContainsKey(btn.Name))
            {
                string viewKey = _menuMappings[btn.Name];
                MenuItemSelected?.Invoke(viewKey);
            }
        }
    }
}
