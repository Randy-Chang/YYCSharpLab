using System;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using UIFramework.Host;
using UIFramework.Menu;
using UIFramework.Theming;
using UIFramework.Settings;
using UIFramework.Core;
using Project_UIFrameworkDemo.Views;

namespace Project_UIFrameworkDemo
{


    public partial class MainForm : Form
    {
        private readonly IViewHost _viewHost;
        private readonly IMenuController _menuController;
        private readonly IThemeManager _themeManager;
        private readonly ISettingsProvider<AppSettings> _settingsProvider;
        private AppSettings _settings;

        static HomeView homeView = new HomeView();
        static SettingsView settingsView = new SettingsView();

        public MainForm()
        {
            InitializeComponent();

            // 初始化模組
            _viewHost = new ViewHostManager(panelView);
            _menuController = new MenuController();
            _themeManager = new ThemeManager();
            _settingsProvider = new JsonSettingsProvider<AppSettings>("settings.json");

            // 載入設定
            _settings = _settingsProvider.Load();

            // 初始化 View
            _viewHost.Register("Home", homeView);
            _viewHost.Register("Settings", settingsView);

            // 初始化 Menu
            _menuController.Initialize(panelMenu);
            _menuController.SetMenuMappings(new Dictionary<string, string>
        {
            { "btnHome", "Home" },
            { "btnSettings", "Settings" }
        });

            // 綁定事件
            _menuController.MenuItemSelected += key => _viewHost.Switch(key);
            _viewHost.ViewSwitched += key => _settings.LastOpenedView = key;
            _themeManager.ThemeChanged += theme =>
            {
                ThemeApplicator.Apply(panelMenu, theme);
            };

            // 還原主題
            if (_settings.ThemeName == "Dark")
                _themeManager.SetTheme(DarkTheme());
            else
                _themeManager.SetTheme(DefaultTheme());

            // 還原頁面
            _viewHost.Switch(_settings.LastOpenedView);

            // 主題切換按鈕
            Button btnThemeSwitch = settingsView.BtnThemeSwitch;

            btnThemeSwitch.Click += (s, e) =>
            {
                if (_themeManager.CurrentTheme.Name == "Default")
                {
                    _themeManager.SetTheme(DarkTheme());
                    _settings.ThemeName = "Dark";
                }
                else
                {
                    _themeManager.SetTheme(DefaultTheme());
                    _settings.ThemeName = "Default";
                }
            };

            this.FormClosing += (s, e) => _settingsProvider.Save(_settings);
        }


        private Theme DefaultTheme() => new Theme
        {
            Name = "Default",
            BackgroundColor = Color.FromArgb(0, 37, 85),
            ForegroundColor = Color.White,
            DefaultFont = new Font("Arial", 10, FontStyle.Bold)
        };

        private Theme DarkTheme() => new Theme
        {
            Name = "Dark",
            BackgroundColor = Color.Black,
            ForegroundColor = Color.White,
            DefaultFont = new Font("Arial", 10, FontStyle.Bold)
        };
    }

}
