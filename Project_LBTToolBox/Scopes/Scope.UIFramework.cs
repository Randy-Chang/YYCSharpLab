using LoggingUtilities;
using System;
using System.Collections.Generic;
using System.Configuration;

using UIFramework.Core;
using UIFramework.Host;
using UIFramework.Menu;
using UIFramework.Settings;
using UIFramework.Theming;

namespace Project_LBTToolBox.Scopes
{
    public partial class Scope
    {
        private IViewHost _viewHost;
        private IMenuController _menuController;
        private IThemeManager _themeManager;

        private void InitializeUIFramework()
        {
            // 初始化模組
            _viewHost = new ViewHostManager(mainForm.PanelView);
            _menuController = new MenuController();
            _themeManager = new ThemeManager();

            // 初始化 View
            _viewHost.Register("ChipIdCorrection", Scope.chipIdCorrectionView);
            _viewHost.Register("DataGain", Scope.dataGainView);
            _viewHost.Register("Setting", Scope.settingView);
            _viewHost.Register("AlarmSettings", Scope.alarmSettingsView);
            _viewHost.Register("AlarmDashboard", Scope.alarmDashboardView);

            // 初始化 Menu
            _menuController.Initialize(mainForm.PanelMenu);
            _menuController.SetMenuMappings(new Dictionary<string, string>
            {
                { "btnChipIdCorrection", "ChipIdCorrection" },
                { "btnSetting", "Setting" },
                { "btnDataGain", "DataGain"},
                { "btnAlarmSettings", "AlarmSettings"},
                { "btnAlarmDashboard", "AlarmDashboard"},
            });

            _viewHost.Switch("ChipIdCorrection");

            // 綁定事件
            _menuController.MenuItemSelected += key => _viewHost.Switch(key);
            _themeManager.ThemeChanged += theme =>
            {
                ThemeApplicator.Apply(mainForm.PanelMenu, theme);
            };

            // 還原主題
            _themeManager.SetTheme(ThemeType.Default);

            LoggerService.Instance.Info("viewHostManager 初始化完成");
        }
    }
}
