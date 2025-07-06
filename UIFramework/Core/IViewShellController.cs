using System;

namespace YYCSharpLab.UIFramework.Core
{
    public interface IViewShellController
    {
        void Register(string viewKey, object buttonKey, System.Func<object> viewFactory);
        void Show(string viewKey);
        void GoBack();
        object CurrentView { get; }
        string CurrentViewKey { get; }
    }
}