using System.Web;
using System.Web.Optimization;

namespace Rently
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/lib").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/bootstrap.js",
                        //provide dialog boxes for bootstrap
                        "~/scripts/bootbox.js",
                        "~/Scripts/respond.js",
                        //add sorting pagination and search on tables
                        "~/scripts/datatables/jquery.datatables.js",
                        "~/scripts/datatables/datatables.bootstrap.js",
                        //function used for autofilling
                        "~/scripts/typeahead.bundle.js",
                        //toastr notification 
                        "~/scripts/toastr.js"
                      ));

            //validation script
            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                //main page css
                      "~/Content/bootstrap-lumen.css",
                // main theme 
                      "~/Content/bootstrap-theme.css",
                // about page css
                     "~/Content/agency.min.css",
                // index style
                       "~/Content/landing-page.css",

                      // style for sorting tables    
                      "~/content/datatables/css/datatables.bootstrap.css",
               // style for autofilling
                      "~/content/typeahead.css",
               //style for toastr notification
                      "~/content/toastr.css",
                      "~/Content/site.css"));
        }
    }
}

