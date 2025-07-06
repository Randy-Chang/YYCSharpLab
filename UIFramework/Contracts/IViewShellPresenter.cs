namespace YYCSharpLab.UIFramework.Contracts
{
    public interface IViewShellPresenter
    {
        void DisplayView(object viewInstance);
        void ClearView();
    }
}
