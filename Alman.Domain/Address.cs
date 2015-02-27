using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alman.Domain
{
    [Table("Address")]
    public class Address : Entity
    {
        public AddressType AddressType { get; set; }
        public string Stree1 { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
    }

    public enum AddressType
    {
        Unknown,
        Primary,
        Home,
        Office,
        Mailing,
        Billing,
        Other
    }
}
