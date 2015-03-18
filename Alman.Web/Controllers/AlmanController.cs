using Alman.Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Alman.Web.Controllers
{
    [AlmanAuth]
    public class AlmanController : Controller
    {
        /// <summary>
        /// Returns the currently logged in user or null.
        /// </summary>
        public User CurrentUser { get; protected set; }

        /// <summary>
        /// Returns the current data partition or null.
        /// </summary>
        public DataPartition CurrentPartition { get; protected set; }    

    }
}