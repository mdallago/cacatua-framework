using System;

namespace Cacatua.MVP.Webform
{
    public class MasterPageBaseMVP<TPresenterContract, TViewContract> : System.Web.UI.MasterPage, IWebView<TPresenterContract, TViewContract>
        where TPresenterContract : IPresenterWebform<TViewContract>
        where TViewContract :class, IWebView<TPresenterContract,TViewContract>
    {
        private readonly PresenterManager<TPresenterContract, TViewContract> manager;

        public MasterPageBaseMVP()
        {
            manager = new PresenterManager<TPresenterContract, TViewContract>(this);
        }

        protected override void OnInit(EventArgs e)
        {
            manager.Init();
            base.OnInit(e);
        }

        protected override void OnLoad(EventArgs e)
        {
            manager.Load();
            base.OnLoad(e);
        }

        public TPresenterContract Presenter
        {
            get; set;
        }
    }
}
