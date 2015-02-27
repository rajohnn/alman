using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alman.Domain
{
    [Table("ContactPhoto")]
    public class ContactPhoto : ClientEntity
    {
        public Contact Contact { get; set; }
        public byte[] FullSize { get; set; }
        public byte[] Thumbnail { get; set; }

        public string FileType { get; set; }
    }
}
