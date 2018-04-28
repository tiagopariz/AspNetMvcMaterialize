using System.Web.Optimization;

namespace AspNetMvcMaterialize.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/js/jquery").Include(
                        "~/js/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/js/materialize").Include(
                      "~/js/materialize.js"));

            bundles.Add(new StyleBundle("~/css").Include(
                      "~/css/materialize.css"));
        }
    }
}