using Alman.Servics;
using Alman.Web.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Alman.Web.Areas.Admin.Controllers
{
    public class MainController : Controller
    {
        // GET: Admin/Main
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Sites()
        {
            var service = new SiteService();
            var sites = service.GetSites();
            var vm = new SitesViewModel(sites);

            
            return View(vm);
        }

        public ActionResult Services()
        {
            return View();
        }

        public ActionResult ListEditor()
        {
            return View();
        }

        public ActionResult LocationEditor()
        {
            return View();
        }

        public ActionResult UserRoles()
        {
            return View();
        }

        public ActionResult Preferences()
        {
            return View();
        }
    }
}