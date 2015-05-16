using System.Web;
using System.Web.Optimization;

namespace LWNBSite
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));


           

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css"));




            bundles.Add(new ScriptBundle("~/bundles/jsBootSwatch").Include(
               "~/Scripts/jsBootswatch/jquery.min.js",
               "~/Scripts/jsBootswatch/jquery.cookie.js",
               "~/Scripts/jsBootswatch/js/bootstrap.min.js",
               "~/Scripts/jsBootswatch/bootstrap-switch.min.js",
               "~/Scripts/jsBootswatch/wow.min.js",
               "~/Scripts/jsBootswatch/slidebars.js",
               "~/Scripts/jsBootswatch/jquery.bxslider.min.js",
               "~/Scripts/jsBootswatch/holder.js",
               "~/Scripts/jsBootswatch/buttons.js",
               "~/Scripts/jsBootswatch/styleswitcher.js",
               "~/Scripts/jsBootswatch/jquery.mixitup.min.js",
               "~/Scripts/jsBootswatch/circles.min.js",

               "~/Scripts/jsBootswatch/syntaxhighlighter/shCore.js",
               "~/Scripts/jsBootswatch/syntaxhighlighter/shBrushXml.js",
               "~/Scripts/jsBootswatch/syntaxhighlighter/shBrushJScript.js",

               "~/Scripts/jsBootswatch/app.js",
               "~/Scripts/jsBootswatch/index.js"






               ));  




            bundles.Add(new StyleBundle("~/Content/bootswatchCSS").Include(
                        "~/Content/bootswatchCSS/preload.css",
                        "~/Content/bootswatchCSS/bootstrap.min.css",
                        "~/Content/bootswatchCSS/yamm.css",
                        "~/Content/bootswatchCSS/bootstrap-switch.min.css",
                        "~/Content/bootswatchCSS/font-awesome.min.css",
                        "~/Content/bootswatchCSS/bootstrap-switch.min.css",
                        "~/Content/bootswatchCSS/animate.min.css",
                        "~/Content/bootswatchCSS/slidebars.css",
                        "~/Content/bootswatchCSS/lightbox.css",
                        "~/Content/bootswatchCSS/jquery.bxslider.css",
                        "~/Content/bootswatchCSS/syntaxhighlighter/shCore.css",
                        "~/Content/bootswatchCSS/style-blue.css",
                        "~/Content/bootswatchCSS/width-full.css",
                        "~/Content/bootswatchCSS/buttons.css"


                ));
        }
    }
}