using Autofac;
using Autofac.Integration.WebApi;
using PeopLost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace PeopLost.WebApi
{
    public class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            // Register dependencies in controllers
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
           // builder.RegisterApiControllers(
             //          typeof(WebApiApplication).Assembly);

            // Register our Data dependencies
            builder.RegisterModule(new DataModule());

            var container = builder.Build();

            // Set MVC DI resolver to use our Autofac container
            //DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            //GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver((IContainer)container);
        }
    }
}