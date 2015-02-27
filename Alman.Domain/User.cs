using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Alman.Fx.Security;

namespace Alman.Domain
{
    [Table("User")]
    public class User : ClientEntity
    {
        public virtual Contact Contact { get; set; }

        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public DateTime PasswordExpirationDate { get; set; }

        [NotMapped]
        public string TemporaryPassword { get; set; }

        public bool CheckPassword(string candidate)
        {
            if (String.IsNullOrEmpty(candidate))
                return false;

            string hash = Hash.HmacSha1(PasswordSalt, candidate);
            return hash == PasswordHash;
        }

        public void SetPassword(string password)
        {
            var newSalt = new string(Convert.ToBase64String(Guid.NewGuid().ToByteArray()).Take(8).ToArray());
            var newHash = Hash.HmacSha1(newSalt, password);

            PasswordSalt = newSalt;
            PasswordHash = newHash;
            TemporaryPassword = password;
        }


    }   
}
