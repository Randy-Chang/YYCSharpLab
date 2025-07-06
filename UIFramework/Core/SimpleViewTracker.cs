namespace YYCSharpLab.UIFramework.Core
{
    public class SimpleViewTracker : IActiveViewTracker
    {
        public object CurrentView { get; private set; }
        public string CurrentKey { get; private set; }

        public void SetActive(string key, object view)
        {
            CurrentKey = key;
            CurrentView = view;
        }

        public void Clear()
        {
            CurrentKey = null;
            CurrentView = null;
        }
    }
}
