using Cacatua.MVP.Core;

namespace Cacatua.MVP.Webform
{
    public interface IPresenterWebform<TViewContract> : IPresenter<TViewContract> where TViewContract : IView
    {
        void LoadViewNotPostBack();
    }
}
