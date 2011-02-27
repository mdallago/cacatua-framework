using System.Web;
using Cacatua.MVP.Core;
using Microsoft.Practices.ServiceLocation;

namespace Cacatua.MVP.Webform
{
    public abstract class HttpHandlerBaseMVP<TPresenterContract, TViewContract> : IHttpHandler, IView<TPresenterContract, TViewContract>
        where TPresenterContract : IPresenterWebform<TViewContract>
                 where TViewContract : class,IView
    {        
        protected HttpContext Context  { get; private set; }
        
        #region IHttpHandler Members

        public bool IsReusable
        {
            get { return false; }
        }

        public abstract void ProcessRequestMVP(HttpContext context);

        public void ProcessRequest(HttpContext context)
        {
            Context = context;
            Presenter = ServiceLocator.Current.GetInstance<TPresenterContract>();
            Presenter.SetView(this as TViewContract);
            Presenter.LoadViewNotPostBack();
            ProcessRequestMVP(context);
        }
        public TPresenterContract Presenter
        {
            get;  set; 
        }
        #endregion

    }
}
