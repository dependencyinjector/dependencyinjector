using System.Web;
using System.Web.Optimization;
using DependencyInjector.Constants;

namespace DependencyInjector
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            Contract.IsNotNull(bundles, "bundles");

            bundles.Add(new ScriptBundle(Bundles.Scripts.JQuery).Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle(Bundles.Scripts.Validation).Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle(Bundles.Scripts.Modernizr).Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle(Bundles.Scripts.Bootstrap).Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle(Bundles.Styles.Theme).Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            BundleTable.EnableOptimizations = !BuildInfo.IsDebug;
        }
    }
}
