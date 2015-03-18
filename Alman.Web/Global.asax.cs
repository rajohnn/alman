using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;

namespace Alman.Web
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_OnPostAuthenticateRequest(object sender, EventArgs e)
        {
            
            IPrincipal currentUser = HttpContext.Current.User;            

            if (currentUser.Identity.IsAuthenticated && currentUser.Identity.AuthenticationType == "Forms")
            {
                FormsIdentity identity = currentUser.Identity as FormsIdentity;                
                AlmanIdentity almanIdentity = new AlmanIdentity(identity.Ticket);                
                AlmanPrincipal almanPrincipal = new AlmanPrincipal(almanIdentity);
                
                HttpContext.Current.User = almanPrincipal;
                Thread.CurrentPrincipal = almanPrincipal;
            }
        }
    }
}
