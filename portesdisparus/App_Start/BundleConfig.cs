using System.Web;
using System.Web.Optimization;

namespace PeopLost
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
          

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-1.10.2.js"));

            //bundles.Add(new ScriptBundle("~/bundles/position").Include(
            //            "~/Scripts/position.js"));


            bundles.Add(new ScriptBundle("~/plugins/jquery").Include(
                "~/plugins/jQuery/jQuery-2.1.4.min.js"));

            bundles.Add(new ScriptBundle("~/dist/js").Include(
             "~/dist/js/app.min.js",
             "~/dist/js/demo.js"
             ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));


            //bundles.Add(new ScriptBundle("~/bundles/app").Include(
            //            "~/Scripts/app.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));


            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/gmaps").Include(
                "~/Scripts/gmaps.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/Site.css",
                      "~/Content/Notification.css"));
            bundles.Add(new StyleBundle("~/fonts/css").Include(
                "~/fonts/font-awesome.min.css"
                ));

            bundles.Add(new StyleBundle("~/dist/css").Include(
                      "~/dist/css/AdminLTE.min.css"));

            bundles.Add(new ScriptBundle("~/datepicker/js").Include(
                 "~/plugins/datepicker/bootstrap-datepicker.js"));

            bundles.Add(new StyleBundle("~/datepicker/css").Include(
                "~/plugins/timepicker/bootstrap-timepicker.min.css",
                      "~/plugins/datepicker/datepicker3.css"));

        }
    }
}
