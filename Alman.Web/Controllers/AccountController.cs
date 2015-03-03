using Alman.Servics;
using Alman.Domain;

using Alman.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading;

namespace Alman.Web.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            var model = new LoginViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            if (model != null)
            {
                string message = string.Empty;
                var service = new UserService();

                User user = service.Login(model.FacilityCode, model.Username, model.Password, out message);
                if (user == null)
                {
                    model.FailureCount = model.FailureCount + 1;
                    model.Message = message;
                    model.IsAuthenticated = false;
                }
                else
                {
                    model.Message = "Authenticated";
                    model.FailureCount = 0;
                    model.IsAuthenticated = true;
                }   
            }            
            return Json(model);
        }

        public ActionResult ResetPassword()
        {
            var model = new LoginViewModel();
            return View(model);
        }
    }
}