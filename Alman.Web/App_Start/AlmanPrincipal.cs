using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace Alman.Web
{
    public class AlmanPrincipal : IPrincipal
    {
        private AlmanIdentity _identity;

        public AlmanPrincipal(AlmanIdentity identity)
        {
            _identity = identity;
        }

        public IIdentity Identity
        {
            get { return _identity; }
        }

        public bool IsInRole(string role)
        {
            return false;
        }

    }
}