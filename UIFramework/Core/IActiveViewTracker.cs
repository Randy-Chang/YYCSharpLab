namespace YYCSharpLab.UIFramework.Core
{
    public interface IActiveViewTracker
    {
        object CurrentView { get; }
        string CurrentKey { get; }

        void SetActive(string key, object view);
        void Clear();
    }
}
