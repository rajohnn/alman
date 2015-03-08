using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Alman.Web.Areas.App.Controllers
{
    public class MainController : Controller
    {
        // GET: App/Main
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Chat()
        {
            return View();
        }
        
    }
}