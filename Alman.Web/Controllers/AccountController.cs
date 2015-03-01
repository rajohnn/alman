using Alman.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
                System.Diagnostics.Debug.WriteLine(model.Username);
            }
            return View();
        }

        public ActionResult ResetPassword()
        {
            var model = new LoginViewModel();
            return View(model);
        }
    }
}