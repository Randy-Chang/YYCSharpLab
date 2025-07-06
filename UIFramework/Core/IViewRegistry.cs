namespace YYCSharpLab.UIFramework.Core
{
    public interface IViewRegistry
    {
        void Register(string viewKey, object buttonKey, System.Func<object> viewFactory);
        bool TryGetViewFactory(string viewKey, out System.Func<object> viewFactory);
        object GetButtonKey(string viewKey);
    }
}