using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Rently.Models;

namespace Rently.Controllers
{
    [Authorize(Roles = RoleName.CanManageMovies)]
    public class RentalsController : Controller
    {
        public ActionResult New()
        {
            return View();
        }
    }
}