using Microsoft.Owin;
using Owin;
using System.Configuration;
using Microsoft.AspNet.SignalR.SqlServer;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin.Security.Cookies;
using Microsoft.AspNet.Identity;

[assembly: OwinStartupAttribute(typeof(PeopLost.Startup))]
namespace PeopLost
{
    public partial class Startup
    {
        public void SetupPeopLost()
        {
            GlobalHost.DependencyResolver.UseSqlServer(ConfigurationManager.ConnectionStrings["sqlConnString"].ConnectionString);
        }
        
        public void Configuration(IAppBuilder app)
        {
            //app.UseCookieAuthentication(new CookieAuthenticationOptions
            //{
            //    AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
            //    LoginPath = new PathString("/Account/Login")
            //});
            ConfigureAuth(app);

            SetupPeopLost();
            app.MapSignalR();
        }
    }
}
