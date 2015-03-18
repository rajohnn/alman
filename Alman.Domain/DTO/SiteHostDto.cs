using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alman.Domain.DTO
{
    public class SiteHostDto
    {
        public int HostId { get; set; }
        public string PartitionName { get; set; }
        public string HostName { get; set; }
        public string HostDescription { get; set; }
        public bool IsDeleted { get; set; }
        public string LastModifiedBy { get; set; }
    }
}
