using Cacatua.MVP.Core;

namespace Cacatua.MVP.Webform
{
    public interface IWebView<TPresenter, TView> : IView<TPresenter, TView>
        where TPresenter : IPresenterWebform<TView>
        where TView : class, IView<TPresenter, TView>
    {
        bool IsPostBack { get; }

    }
}