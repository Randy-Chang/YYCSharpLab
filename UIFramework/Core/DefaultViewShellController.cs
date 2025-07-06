using YYCSharpLab.UIFramework.Contracts;

namespace YYCSharpLab.UIFramework.Core
{
    public class DefaultViewShellController : IViewShellController
    {
        private readonly IViewRegistry _viewRegistry;
        private readonly IThemeManager _themeManager;
        private readonly IButtonStyler _buttonStyler;
        private readonly IViewShellPresenter _presenter;
        private readonly IActiveViewTracker _viewTracker;

        public DefaultViewShellController(
            IViewRegistry viewRegistry,
            IThemeManager themeManager,
            IButtonStyler buttonStyler,
            IViewShellPresenter presenter,
            IActiveViewTracker viewTracker)
        {
            _viewRegistry = viewRegistry;
            _themeManager = themeManager;
            _buttonStyler = buttonStyler;
            _presenter = presenter;
            _viewTracker = viewTracker;
        }

        public object CurrentView => _viewTracker.CurrentView;
        public string CurrentViewKey => _viewTracker.CurrentKey;

        public void Register(string viewKey, object buttonKey, System.Func<object> viewFactory) { }

        public void Show(string viewKey) { }

        public void GoBack() { }
    }
}
