using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alman.Domain
{
    [Table("Phone")]
    public class Phone : UserSortableEntity
    {
        public Contact Contact { get; set; }
        public string Number { get; set; }
        public PhoneType PhoneType { get; set; }
    }

    public enum PhoneType
    {
        Unknown,
        Main,
        Home,
        Office,
        Cell,
        Fax,
        Other
    }
}
