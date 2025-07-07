using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareUpdater.Utilities.ViewHost
{
    /// <summary>
    /// 管理 UserControl 在指定面板中的顯示切換，並控制對應的選單按鈕樣式與主題色選擇。
    /// </summary>
    public class ViewHostManager
    {
        private readonly Panel _viewPanel;
        private readonly Panel _menuPanel;
        private readonly IThemeColorProvider _themeColorProvider;
        private readonly Color _defaultBackColor;
        private readonly Color _defaultForeColor;

        private UserControl _currentView;
        private Button _currentButton;
        private readonly Random _random = new Random();
        private int _lastColorIndex = -1;

        private readonly string _fontFamily = "Microsoft JhengHei";
        private readonly float _buttonFontSize = 14f;
        private readonly float _activatedButtonFontSize = 14f;

        /// <summary>
        /// 建構 ViewHostManager 實例，並注入容器 Panel 與主題色邏輯與預設樣式顏色。
        /// </summary>
        public ViewHostManager(
            Panel viewPanel,
            Panel menuPanel,
            IThemeColorProvider themeColorProvider,
            Color defaultButtonBackColor,
            Color defaultButtonForeColor)
        {
            _viewPanel = viewPanel;
            _menuPanel = menuPanel;
            _themeColorProvider = themeColorProvider;
            _defaultBackColor = defaultButtonBackColor;
            _defaultForeColor = defaultButtonForeColor;
        }

        /// <summary>
        /// 在容器中顯示指定的 UserControl，並更新選擇按鈕的樣式。
        /// </summary>
        public void ShowUserControl(UserControl control, object sender)
        {
            if (_currentView != null)
            {
                _viewPanel.Controls.Remove(_currentView);
            }

            ActivateButton(sender);

            _currentView = control;
            control.Dock = DockStyle.Fill;
            _viewPanel.Controls.Add(control);
            control.BringToFront();
        }

        /// <summary>
        /// 套用指定按鈕的選取樣式與主題色。
        /// </summary>
        private void ActivateButton(object sender)
        {
            var button = sender as Button;
            if (button == null || button == _currentButton)
                return;

            ResetAllButtons();

            var color = SelectThemeColor();
            _currentButton = button;
            _currentButton.BackColor = color;
            _currentButton.ForeColor = Color.White;
            _currentButton.Font = new Font(_fontFamily, _activatedButtonFontSize, FontStyle.Bold);

            // 若要對外通知主題色變更，可新增事件或介面通知  
        }

        /// <summary>
        /// 重設所有按鈕為預設樣式。
        /// </summary>
        private void ResetAllButtons()
        {
            foreach (Control ctrl in _menuPanel.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.BackColor = _defaultBackColor;
                    btn.ForeColor = _defaultForeColor;
                    btn.Font = new Font(_fontFamily, _buttonFontSize, FontStyle.Regular);
                }
            }
        }

        /// <summary>
        /// 從顏色清單中隨機挑選與前次不同的主題色。
        /// </summary>
        private Color SelectThemeColor()
        {
            var colors = _themeColorProvider.ColorList;
            if (colors.Count == 0)
                throw new InvalidOperationException("Color list cannot be empty.");

            if (colors.Count == 1)
            {
                _lastColorIndex = 0;
                return ColorTranslator.FromHtml(colors[0]);
            }

            int index;
            do
            {
                index = _random.Next(colors.Count);
            } while (index == _lastColorIndex);

            _lastColorIndex = index;
            return ColorTranslator.FromHtml(colors[index]);
        }
    }

}
