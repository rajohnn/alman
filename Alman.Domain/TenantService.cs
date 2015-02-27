using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alman.Domain
{
    [Table("TenantService")]
    public class TenantService : ClientEntity
    {
        public Service Service { get; set; }
        public Tenant Tenant { get; set; }

        public DateTime StartDate { get; set; }
        public TimeSpan Duration { get; set; }
        public string Instructions { get; set; }

        public bool IsOnlyOnTempLeave { get; set; }
        public bool OverrideDefaultMinutes { get; set; }
        public string RecurrenceRule { get; set; }

        public Nullable<DateTime> LastTaskGeneratedOn { get; set; }
    }

    [Table("TenantServicePayer")]
    public class TenantServicePayer : ClientEntity
    {
        public Payer Payer { get; set; }
        public TenantService TenantService { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public decimal? FixedPaymentAmount { get; set; }
        public decimal? FixedPaymentPercentage { get; set; }
        public bool DefaultPayer { get; set; }
        public decimal? MaximumPaymentAmount { get; set; }
        public string Note { get; set; }
        public bool Notify { get; set; }
    }

    [Table("TenantServiceRange")]
    public class TenantServiceRange : ClientEntity
    {
        public TenantService TenantService { get; set; }
        public Shift Shift { get; set; }

        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        public TimeSpan SpecificTime { get; set; }
    }
}
