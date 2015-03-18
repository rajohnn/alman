using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Security;

namespace Alman.Web
{
    public class AlmanIdentity : IIdentity
    {
        private FormsAuthenticationTicket _ticket;
        private int _dataPartitionId = 0;
        private bool _isRoot = false;
        private int _userId = 0;

        public AlmanIdentity(FormsAuthenticationTicket ticket)
        {
            _ticket = ticket;
            string[] data = _ticket.UserData.Split('|');

            int userId = 0;
            int dataPartition = 0;

            if (Int32.TryParse(data[0], out userId))
                _userId = userId;

            if (Int32.TryParse(data[1], out dataPartition))
                _dataPartitionId = dataPartition;

            if (_userId == 1)
                _isRoot = true;
        }

        public string AuthenticationType
        {
            get {  return "Alman"; }
        }

        public bool IsAuthenticated
        {
            get { return true; }
        }

        public string Name
        {
            get { return _ticket.Name;  }
        }

        public FormsAuthenticationTicket Ticket
        {
            get { return _ticket;  }
        }

        public int DataPartitionId
        {
            get
            {
                return _dataPartitionId;
            }
        }

        public bool IsRoot
        {
            get
            {
                return _isRoot;
            }
        }

        public int UserId
        {
            get
            {
                return _userId; 
            }
        }
    }
}