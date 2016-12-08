using portesdisparus.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace portesdisparus
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MessageHandlers.Add(new MethodOverrideHandler());
       
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
