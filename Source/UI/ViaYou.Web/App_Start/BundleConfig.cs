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

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/Shared/css").Include(
                "~/Content/Shared/css/bootstrap.min.css",
                "~/Content/Shared/css/site.css"
                ));

            bundles.Add(new StyleBundle("~/Content/BasicTemplate/css").Include(
                "~/Content/font-awesome.min.css",
                "~/Content/BasicTemplate/css/animate.min.css",
                "~/Content/BasicTemplate/css/creative.css"
                ));

            bundles.Add(new ScriptBundle("~/Scripts/BasicTemplate/js").Include(
                //"~/Scripts/BasicTemplate/js/jquery.scrollUp.min.js",
                //"~/Scripts/BasicTemplate/js/price-range.js",
                //"~/Scripts/BasicTemplate/js/jquery.prettyPhoto.js",
                //"~/Scripts/BasicTemplate/js/main.js"
                ));




            bundles.Add(new StyleBundle("~/Content/AdminTemplate/css").Include(
                "~/Content/font-awesome.min.css",
                "~/Content/AdminTemplate/css/plugins/metisMenu/metisMenu.min.css",
                "~/Content/AdminTemplate/css/plugins/timeline.css",
                "~/Content/AdminTemplate/css/sb-admin-2.css",
                "~/Content/AdminTemplate/css/plugins/morris.css",
                "~/Content/AdminTemplate/css/main.css",
                "~/Content/AdminTemplate/css/responsive.css"
                ));

            bundles.Add(new ScriptBundle("~/Scripts/AdminTemplate/js").Include(
                "~/Scripts/AdminTemplate/js/plugins/metisMenu/metisMenu.min.js",
                //"~/Scripts/AdminTemplate/js/plugins/morris/raphael.min.js",
                //"~/Scripts/AdminTemplate/js/plugins/morris/morris.min.js",
                //"~/Scripts/AdminTemplate/js/plugins/morris/morris-data.js",
                "~/Scripts/AdminTemplate/js/sb-admin-2.js"));
        }
    }
}
