using LoggingUtilities;
using SoftwareUpdater.Utilities.ViewHost;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_LBTToolBox.Scopes
{
    public partial class Scope
    {
        static ViewHostManager viewHostManager;
        Color defaultButtonBackColor = Color.FromArgb(0, 37, 85);
        Color defaultButtonForeColor = Color.White;
        List<string> colors = new List<string>
        {
            "#3F51B5"
        };

        private void InitializeViewHost()
        {
            viewHostManager = new ViewHostManager(mainForm.PanelView, mainForm.PanelMenu,
                                                    new DefaultThemeColorProvider(colors),
                                                    defaultButtonBackColor,
                                                    defaultButtonForeColor);

            LoggerService.Instance.Info("viewHostManager 初始化完成");
        }
    }
}
