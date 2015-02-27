using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alman.Domain
{
    public class DataPartition : Entity
    {        
        public string Name { get; set; }
        public Address Address { get; set; }
    }
}
