using System;
using Autofac;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Serialization;
using System.Reflection;
using PeopLost.WebApi;
using Autofac.Integration.WebApi;
using System.Web.Mvc;
using Autofac.Integration.Owin;
using System.Web.Http.Cors;

namespace PeopLost.WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {


            var cors = new EnableCorsAttribute("http://localhost:54978","*","*");
            config.EnableCors(cors);


            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // Autofac container
            // if not configured here you'll not have dependencies provided to your WebApiControllers when called
            var builder = new ContainerBuilder(); // yes, it is a different container here
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            //builder.RegisterAssemblyTypes( // register Web API Controllers
              //  Assembly.GetExecutingAssembly())
                //    .Where(t =>
                  //      !t.IsAbstract && typeof(ApiController).IsAssignableFrom(t))
                    //.InstancePerMatchingLifetimeScope(
                      //  AutofacWebApiDependencyResolver.ApiRequestTag);

            // register your graph - shared
            builder.RegisterModule(
                new DataModule()); // same as with ASP.NET MVC Controllers

            var container = builder.Build();
            //DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            //config.DependencyResolver = new AutofacDependencyResolver(
              //  container);
            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver((IContainer)container);



        }
    }
}
