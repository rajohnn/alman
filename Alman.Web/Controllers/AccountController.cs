using Alman.Servics;
using Alman.Domain;
using Alman.Web;
using Alman.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading;
using System.Web.Security;

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
                    string data = string.Format(Constants.TEMPLATE_COOKIE, user.Id, user.DataPartitionId);
                    var cookie = CreateAuthorizationTicket(user, data);
                    
                    Response.Cookies.Add(cookie);
                }   
            }            
            return Json(model);
        }

        private HttpCookie CreateAuthorizationTicket(User user, string data)
        {
            var authCookie = FormsAuthentication.GetAuthCookie(user.UserName, true);
            var ticket = FormsAuthentication.Decrypt(authCookie.Value);
            var newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, ticket.IssueDate, ticket.Expiration, ticket.IsPersistent, data);
            authCookie.Value = FormsAuthentication.Encrypt(newTicket);
            return authCookie;
        }

        public ActionResult ResetPassword()
        {
            var model = new LoginViewModel();
            return View(model);
        }
    }
}