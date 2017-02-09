using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rently.Controllers
{
    // use the AuthorizeAttribute() in the filter but give customer 
    // the option to view at least the home page
    [AllowAnonymous]
    public class HomeController : Controller
    {
        [OutputCache(Duration = 50)]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}