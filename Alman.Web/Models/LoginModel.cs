using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Alman.Web.Models
{
    public class LoginViewModel
    {
        public string Username { get; set; }
        public string FacilityCode { get; set; }
        public string Password { get; set; }

        public bool ShowMessage { get; set; }
        public string Message { get; set; }
        public int FailureCount { get; set; }

        public LoginViewModel()
        {
            this.Username = string.Empty;
            this.FacilityCode = string.Empty;
            this.Password = string.Empty;
            this.ShowMessage = false;
            this.Message = String.Empty;
            this.FailureCount = 0;
        }
    }
}