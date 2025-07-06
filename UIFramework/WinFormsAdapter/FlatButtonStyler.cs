using System.Drawing;
using System.Windows.Forms;
using YYCSharpLab.UIFramework.Contracts;

namespace YYCSharpLab.UIFramework.WinFormsAdapter
{
    public class FlatButtonStyler : IButtonStyler
    {
        private readonly Font _defaultFont = new Font("Microsoft JhengHei", 14f, FontStyle.Regular);
        private readonly Font _activeFont = new Font("Microsoft JhengHei", 14f, FontStyle.Bold);
        private readonly Color _defaultBackColor;
        private readonly Color _defaultForeColor;

        public FlatButtonStyler(Color defaultBackColor, Color defaultForeColor)
        {
            _defaultBackColor = defaultBackColor;
            _defaultForeColor = defaultForeColor;
        }

        public void ApplyActiveStyle(object buttonKey, Color themeColor)
        {
            var button = buttonKey as Button;
            if (button == null)
                return;

            button.BackColor = themeColor;
            button.ForeColor = Color.White;
            button.Font = _activeFont;
        }

        public void ResetStyle(object buttonKey)
        {
            var button = buttonKey as Button;
            if (button == null)
                return;

            button.BackColor = _defaultBackColor;
            button.ForeColor = _defaultForeColor;
            button.Font = _defaultFont;
        }
    }
}
