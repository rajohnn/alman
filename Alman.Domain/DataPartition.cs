using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alman.Domain
{
    [Table("DataPartition")]
    public class DataPartition : Entity
    {        
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
