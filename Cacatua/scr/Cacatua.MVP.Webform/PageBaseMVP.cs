using System;

namespace Cacatua.MVP.Webform
{
    public class PageBaseMVP<TPresenterContract, TViewContract> : System.Web.UI.Page, IWebView<TPresenterContract, TViewContract>
        where TPresenterContract : IPresenterWebform<TViewContract>
        where TViewContract : class, IWebView<TPresenterContract, TViewContract>
    {

        private readonly PresenterManager<TPresenterContract, TViewContract> manager;

        public PageBaseMVP()
        {
            manager = new PresenterManager<TPresenterContract, TViewContract>(this);
        }

        protected override void OnPreInit(EventArgs e)
        {
            manager.Init();
            base.OnPreInit(e);
        }

        protected override void OnInit(EventArgs e)
        {
            manager.Load();
            base.OnInit(e);
        }

        public TPresenterContract Presenter
        {
            get;  set;
        }
    }
}
