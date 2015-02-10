using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Optimization;

namespace Jobaline
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-{version}.js",
                "~/Scripts/jquery-1.10.2.min.js",
                "~/Scripts/jquery-ui.js"));

            bundles.Add(new ScriptBundle("~/bundles/angularjs").Include(
                "~/Scripts/angular.js"));

            bundles.Add(new ScriptBundle("~/bundles/home").Include(
                "~/Scripts/home/home.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                 "~/Content/bootstrap.css",
                 "~/Content/Site.css",
                 "~/Content/jquery-ui.css"));

            BundleTable.EnableOptimizations = true;
        }
    }
}
