using Alman.Data;
using Alman.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alman.Servics
{
    public class UserService : ServiceBase
    {
        public User GetUserById(int id)
        {            
            return _ctx.Users.SingleOrDefault(u => u.Id == id);
        }

        public User Login(string facility, string username, string password, out string message)
        {
            User authenticatedUser = null;
            message = string.Empty;

            var host = _ctx.VirtualHost.SingleOrDefault(f=>f.DomainName == facility);
            
            if ( host != null) {
                var users = _ctx.Users.Where(u => u.UserName == username && 
                    (u.DataPartitionId == Constants.ROOT || u.DataPartitionId == host.DataPartitionId));

                foreach (var user in users)
                {
                    if (user.CheckPassword(password))
                    {
                        authenticatedUser = user;
                        break;
                    }
                }
                if (authenticatedUser == null)
                {
                    message = "There was an error with your e-mail/password combination.";
                }
            }
            else
            {
                message = "No facility matching your identifer was found.";
            }
            
            return authenticatedUser;
        }
    }
}
