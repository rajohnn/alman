using Alman.Domain;
using Alman.Domain.DTO;
using Alman.Servics;
using Alman.Web.Areas.Admin.Models;
using Alman.Web.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Alman.Web.Areas.Admin.Controllers
{    
    public class MainController : AlmanController
    {
        // GET: Admin/Main
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Sites()
        {
            var service = new SiteService();
            var sites = service.GetSites();
            var vm = new SitesViewModel(sites);

            
            return View(vm);
        }

        [HttpPost]
        public ActionResult UpdateSite(SiteHostDto model)
        {
            bool updated = false;

            if (model != null)
            {
                var service = new SiteService();                 
                updated = service.UpdateHost(model, this.CurrentUser);                
            }
            return Json(updated);
        }

        public ActionResult AddSite()
        {
            var site = new SiteViewModel();
            return View(site);
        }

        [HttpPost]
        public ActionResult AddSite(SiteViewModel vm)
        {
            return View(vm);
        }

        public ActionResult Services()
        {
            return View();
        }

        public ActionResult ListEditor()
        {
            var vm = new ListEditorModel();
            var service = new DataPartitionService();
            vm.DataPartitions = service.GetValidPartitions(this.CurrentUser).ToList();            
            return View(vm);
        }

        [HttpPost]
        public ActionResult GetEntities(string listType)
        {
            var service = new SelectionEntityService();
            var result= service.GetEntitiesByType(listType);
            return Json(new { Success=true, Data=result }, JsonRequestBehavior.AllowGet);
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