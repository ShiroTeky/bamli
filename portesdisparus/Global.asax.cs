using PeopLost.Web;
using portesdisparus.Notifications;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.ComponentModel;

namespace PeopLost
{
    public class MvcApplication : System.Web.HttpApplication
    {
        string conn = ConfigurationManager.ConnectionStrings["sqlConnString"].ConnectionString;
       
        protected void Application_Start()
        {
            AutofacConfig.ConfigureContainer();
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            
            //Start sqldependency
            SqlDependency.Start(conn);
        }

        protected void Application_End()
        {
            SqlDependency.Stop(conn);
        }

        protected void Application_BeginRequest()
        {
            if (Request.Headers.AllKeys.Contains("Origin") && Request.HttpMethod == "OPTIONS")
            {
                Response.Flush();
            }
        }

    }
}
