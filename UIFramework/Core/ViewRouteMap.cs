using System;
using System.Collections.Generic;

namespace YYCSharpLab.UIFramework.Core
{
    public class ViewRouteMap : IViewRegistry
    {
        private readonly Dictionary<string, Func<object>> _viewFactories = new Dictionary<string, Func<object>>();
        private readonly Dictionary<string, object> _buttonMap = new Dictionary<string, object>();

        public void Register(string viewKey, object buttonKey, Func<object> viewFactory)
        {
            _viewFactories[viewKey] = viewFactory;
            _buttonMap[viewKey] = buttonKey;
        }

        public bool TryGetViewFactory(string viewKey, out Func<object> viewFactory)
        {
            return _viewFactories.TryGetValue(viewKey, out viewFactory);
        }

        public object GetButtonKey(string viewKey)
        {
            object btn;
            _buttonMap.TryGetValue(viewKey, out btn);
            return btn;
        }
    }
}
