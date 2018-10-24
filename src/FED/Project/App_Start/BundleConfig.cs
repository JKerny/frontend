using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace FED.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/foo").Include(
                             "~/Assets/JS/foo.js"));
            bundles.Add(new ScriptBundle("~/bundles/bar").Include(
                         "~/Assets/JS/bar.js"));
            bundles.Add(new StyleBundle("~/bundles/css").IncludeDirectory(
                         "~/Assets/CSS", "*.css"));


            #if DEBUG
            BundleTable.EnableOptimizations = false;
            #else
            BundleTable.EnableOptimizations = true;
            #endif
        }
    }
}