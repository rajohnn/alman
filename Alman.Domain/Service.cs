using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alman.Domain
{
    [Table("Service")]
    public class Service : ClientEntity
    {
        public string Name { get; set; }
        public virtual ServiceCategory ServiceCategory { get; set; }
        public virtual StaffGroup StaffGroup { get; set; }
        public TimeSpan Duration { get; set; }

        public decimal Cost { get; set; }
        public int MinutesUntilOverdue { get; set; }

        public string AccountCode { get; set; }
        public string SubaccountCode { get; set; }
        public bool ApplyTax { get; set; }
        public bool AutoComplete { get; set; }
        public bool AutoVerify { get; set; }

        public bool ChargeNotComplete { get; set; }
        public bool IgnoreStatus { get; set; }

        public bool TrackServiceDeliveryMinutes { get; set; }
        public bool NotDoneReasonRequired { get; set; }
        public bool AutoCreateOnNewClients { get; set; }
    }
}
