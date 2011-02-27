namespace Cacatua.MVP.Core
{
    public interface IPresenter<TViewContract> where TViewContract : IView
    {
        void SetView(TViewContract view);
        void LoadView();
    }
}
