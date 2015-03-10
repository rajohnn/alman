using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alman.Domain
{
    [Table("VirtualHost")]
    public class VirtualHost : ClientEntity
    {
        public string DomainName { get; set; }
        public string Description { get; set; }
        public DataPartition DataPartition { get; set; }
    }
}
