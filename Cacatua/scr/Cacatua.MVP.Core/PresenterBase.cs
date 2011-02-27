namespace Cacatua.MVP.Core
{
    public abstract class PresenterBase<TPresenter,TViewContract> : IPresenter<TViewContract>
        where TPresenter : IPresenter<TViewContract>
        where TViewContract : class,IView<TPresenter, TViewContract>
    {
        protected TViewContract View { get; private set; }

        public virtual void LoadView()
        {

        }

        public void SetView(TViewContract view)
        {
            View = view;
        }

        public virtual void InitView()
        {
            
        }
    }
}
