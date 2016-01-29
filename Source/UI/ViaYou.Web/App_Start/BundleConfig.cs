using System.Web;
using System.Web.Optimization;

namespace ViaYou.Web
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

            bundles.Add(new StyleBundle("~/Content/BasicTemplate/css").Include(
                "~/Content/BasicTemplate/css/bootstrap.min.css",
                "~/Content/font-awesome.min.css",
                "~/Content/BasicTemplate/css/prettyPhoto.css",
                "~/Content/BasicTemplate/css/price-range.css",
                "~/Content/BasicTemplate/css/animate.css",
                "~/Content/BasicTemplate/css/animate.css",
                "~/Content/BasicTemplate/css/main.css",
                "~/Content/BasicTemplate/css/responsive.css"
                ));

            bundles.Add(new ScriptBundle("~/Scripts/BasicTemplate/js").Include(
                "~/Scripts/BasicTemplate/js/jquery.scrollUp.min.js",
                "~/Scripts/BasicTemplate/js/price-range.js",
                "~/Scripts/BasicTemplate/js/jquery.prettyPhoto.js",
                "~/Scripts/BasicTemplate/js/main.js"));
        }
    }
}
