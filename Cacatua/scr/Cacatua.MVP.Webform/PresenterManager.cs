using Microsoft.Practices.ServiceLocation;

namespace Cacatua.MVP.Webform
{
    internal class PresenterManager<TPresenter, TView>
        where TPresenter : IPresenterWebform<TView>
        where TView : class, IWebView<TPresenter, TView>
        
    {
        private readonly IWebView<TPresenter, TView> view;

        public PresenterManager(IWebView<TPresenter, TView> view)
        {
            this.view = view;
        }

        public void Init()
        {
            view.Presenter = ServiceLocator.Current.GetInstance<TPresenter>();
        }

        public void Load()
        {
            view.Presenter.SetView(this as TView);
            if (!view.IsPostBack)
            {
                view.Presenter.LoadViewNotPostBack();
            }
            view.Presenter.LoadView();
        }

    }
}