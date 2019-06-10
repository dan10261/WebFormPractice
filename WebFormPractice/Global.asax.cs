using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace WebFormPractice
{
    public class Global : HttpApplication
    {

        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Application["ApplicationCount"] = 0;
            Application["OnLineUsersCount"] = 0;
            Application["ApplicationCount"] = (int)Application["ApplicationCount"] + 1;
        }
        void Application_End(object sender, EventArgs e)
        {

            Application["ApplicationCount"] = (int)Application["ApplicationCount"] - 1;
        }
        void Application_Error(object sender, EventArgs e)
        {

        }
        void Session_Start(object sender, EventArgs e)
        {
            Application["OnLineUsersCount"] = (int)Application["OnLineUsersCount"] + 1;
        }
        void Session_End(object sender, EventArgs e)
        {

            Application["OnLineUsersCount"] = (int)Application["OnLineUsersCount"] - 1;
        }
    }
}