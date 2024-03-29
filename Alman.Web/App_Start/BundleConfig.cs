﻿using System.Web;
using System.Web.Optimization;

namespace Alman.Web
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

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                "~/Scripts/metisMenu.js",
                "~/Scripts/raphael.js",                
                "~/Scripts/moment.js",                
                "~/Scripts/respond.js",                   
                "~/Scripts/koGrid-{version}.js",
                "~/Scripts/app.js"
            ));

            bundles.Add(new ScriptBundle("~/bundles/knockout").Include(
                "~/Scripts/knockout-{version}.js",
                "~/Scripts/knockout.mapping-latest.js",
                "~/Scripts/knockout.validation.js"
            ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/bootstrap-theme.css",
                      "~/Content/site.css",
                      "~/Content/font-awesome.css"
            ));

            bundles.Add(new StyleBundle("~/Content/app/css").Include(
                "~/Content/bootstrap.css",                
                "~/Content/metisMenu.css",
                "~/Content/timeline.css",
                "~/Content/app.css",
                "~/Content/morris.css",
                "~/Content/font-awesome.css",
                "~/Content/KoGrid.css"
            ));
        }
    }
}
