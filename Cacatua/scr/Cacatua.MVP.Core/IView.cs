namespace Cacatua.MVP.Core
{
    public interface IView<TPresenterContract, TViewContract> : IView
        where TPresenterContract : IPresenter<TViewContract>
        where TViewContract : class, IView
    {
        TPresenterContract Presenter { get; set; }
    }

    public interface IView
    {
        
    }
}
