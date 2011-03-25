using System;
using System.Collections.Generic;
using Microsoft.Practices.ServiceLocation;

namespace Cacatua.MVP.Examples.Web
{
    public class Global : System.Web.HttpApplication
    {
        class MyServiceLocator :ServiceLocatorImplBase
        {
            protected override object DoGetInstance(Type serviceType, string key)
            {
                if (typeof(MyPresenter) == serviceType)
                    return new MyPresenter();

                throw new ArgumentException(serviceType + "no encontrado");
            }

            protected override IEnumerable<object> DoGetAllInstances(Type serviceType)
            {
                throw new NotImplementedException();
            }
        }


        protected void Application_Start(object sender, EventArgs e)
        {
            ServiceLocator.SetLocatorProvider(()=> new MyServiceLocator());
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}