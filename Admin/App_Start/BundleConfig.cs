using System.Web;
using System.Web.Optimization;

namespace Admin
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/preloadscripts").Include(
                      "~/Content/js/please-wait.min.js",
                      "~/Content/js/modernizr.js",
                      "~/Content/js/jquery.js"));

            bundles.Add(new ScriptBundle("~/bundles/afterloadscripts").Include(
                      "~/Content/js/bootstrap.min.js",
                      "~/Content/js/jquery.validate.min.js",
                      "~/Content/plugins/slimScroll/jquery.slimscroll.min.js",
                      "~/Content/plugins/fastclick/fastclick.min.js",
                      "~/Content/js/app.min.js",
                      "~/Content/js/demo.js",
                      "~/Content/js/AdminLTE.js",
                      "~/Content/plugins/iCheck/icheck.min.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/assets/css/bootstrap.css",
                      "~/Content/css/bootstrap.min.css",
                      "~/Content/css/font-awesome.min.css",
                      "~/Content/css/AdminLTE.min.css",
                      "~/admin-lte/css/skins/skin-black.min.css",
                      "~/Content/plugins/iCheck/flat/blue.css",
                      "~/Content/css/please-wait.css",
                      "~/Content/site.css"));
        }
    }
}
