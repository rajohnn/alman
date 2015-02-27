using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alman.Domain
{
    public class Permission : ClientEntity
    {
        public string Name { get; set; }
    }

    public class Role : ClientEntity
    {
        public string Name { get; set; }
        public List<Permission> Permissions { get; set; }
    }

    public class RolePermission : ClientEntity
    {
        public Permission Permission { get; set; }
        public Role Role { get; set; }
    }

    public class UserRole : ClientEntity
    {
        public Role Role { get; set; }
        public User User { get; set; }
    }
}
