using System.Windows.Forms;
using YYCSharpLab.UIFramework.Contracts;

namespace YYCSharpLab.UIFramework.WinFormsAdapter
{
    public class WinFormsPresenter : IViewShellPresenter
    {
        private readonly Panel _viewPanel;

        public WinFormsPresenter(Panel viewPanel)
        {
            _viewPanel = viewPanel;
        }

        public void DisplayView(object viewInstance)
        {
            var control = viewInstance as Control;
            if (control == null)
                return;

            _viewPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            _viewPanel.Controls.Add(control);
            control.BringToFront();
        }

        public void ClearView()
        {
            _viewPanel.Controls.Clear();
        }
    }
}
