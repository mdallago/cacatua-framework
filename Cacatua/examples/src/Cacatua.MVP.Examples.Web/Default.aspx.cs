using System;
using Cacatua.MVP.Webform;

namespace Cacatua.MVP.Examples.Web
{
    public partial class _Default : PageBaseMVP<MyPresenter, IMyView>, IMyView
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}
