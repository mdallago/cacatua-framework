using System.Windows.Forms;
using Cacatua.MVP.Core;
using Microsoft.Practices.ServiceLocation;

namespace Cacatua.MVP.Winform
{
    public class FormBaseMVP<TPresenterContract, TViewContract> : Form, IView
        where TPresenterContract : IPresenter<TViewContract>
        where TViewContract : class, IView
    {
        protected TPresenterContract Presenter { get; set; }                

        protected override void OnLoad(System.EventArgs e)
        {
            Presenter = ServiceLocator.Current.GetInstance<TPresenterContract>();
            Presenter.SetView(this as TViewContract);
            IsReady = true;
            Presenter.LoadView();
            base.OnLoad(e);
        }

        #region IView Members

        public bool IsReady
        {
            get;
            set;
        }
        #endregion
    }
}
