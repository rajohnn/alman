using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alman.Domain
{
    [Table("Tenant")]
    public class Tenant : Entity
    {
        public Contact Contact { get; set; }

        public TenantCategory TenantCategory { get; set; }
        public TenantStatus TenantStatus { get; set; }

        public TenantType TenantType { get; set; }
        public MaritalStatus MartialStatus { get; set; }
        public Gender Gender { get; set; }

        public string SocialSecurityNumber { get; set; }

        public Location Location { get; set; }
        public Address MarketingAddress { get; set; }

        public DateTime BirthDate { get; set; }
        public DateTime FollowUpDate { get; set; }
        public DateTime NextReviewDate { get; set; }
        public DateTime OccupancyDate { get; set; }
        public DateTime PossessionDate { get; set; }
        public DateTime MoveOutDate { get; set; }
        public DateTime ExitDate { get; set; }

        public User FollowUpRequestedBy { get; set; }
        public ExitReason ExitReason { get; set; }

        public string PreviousPostalCode { get; set; }
        public string PreviousState { get; set; }
    }

    /// <summary>
    /// The status of the tenant
    /// </summary>
    public enum TenantStatus
    {
        Active,
        Inactive,
        TemporaryLeave,
        PermanentLeave
    }

    public enum Gender
    {
        Unknown,
        Male,
        Female
    }

    public enum MaritalStatus
    {
        Single,
        Married,
        Seperated,
        Divorced,
        Widowed,
        CommonLaw,
        NeverMarried
    }
}
