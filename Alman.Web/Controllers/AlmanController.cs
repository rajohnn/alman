using Alman.Domain;
using Alman.Servics;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace Alman.Web.Controllers
{
    [AlmanAuth]
    public class AlmanController : Controller
    {
        public AlmanPrincipal CurrentPrincipal { get; protected set; }
        public AlmanIdentity CurrentIdentity { get; protected set; }
        public User CurrentUser { get; set; }

        protected override void OnAuthorization(AuthorizationContext filterContext)
        {
            Contract.Requires(filterContext != null && filterContext.HttpContext != null && filterContext.HttpContext.Request != null);
            Contract.Requires(Request != null && Request.Headers != null && Request.Cookies != null);
            Contract.Requires(Response != null);
            Contract.Requires(ViewData != null);

            CurrentPrincipal = (AlmanPrincipal)filterContext.HttpContext.User;
            CurrentIdentity = (AlmanIdentity)this.CurrentPrincipal.Identity;

            var service = new UserService();
            this.CurrentUser = service.GetUserById(this.CurrentIdentity.UserId);
        }

        protected override void OnException(ExceptionContext filterContext)
        {
            // TODO: Implement exception logging here.
            base.OnException(filterContext);
        }


    }
}