using Cacatua.MVP.Core;

namespace Cacatua.MVP.Webform
{
    public class PresenterBaseWebform<TPresenter, TViewContract> : PresenterBase<TPresenter,TViewContract>, IPresenterWebform<TViewContract>
        where TPresenter : IPresenterWebform<TViewContract>
        where TViewContract : class, IWebView<TPresenter, TViewContract>
    {
        #region IPresenterWebform<TViewContract> Members

        public virtual void LoadViewNotPostBack()
        {
            
        }

        #endregion
    }
}
