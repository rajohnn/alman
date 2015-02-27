using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alman.Domain
{
    [Table("Task")]
    public class Task : Entity
    {
        public Tenant Tenant { get; set; }
        public TenantService TenantService { get; set; }

        public DateTime ScheduledDate { get; set; }

        public User ActionedBy { get; set; }
        public Contact VerifiedBy { get; set; }
        public Location Location { get; set; }

        public Nullable<TimeSpan> ActualDuration { get; set; }
        public Nullable<TimeSpan> DefaultDuration { get; set; }

        public decimal Cost { get; set; }

        public string Instructions { get; set; }
        public NotDoneReason NotDoneReason { get; set; }
        public string Notes { get; set; }

        public bool RequiresVerification { get; set; }

        public Nullable<TimeSpan> ScheduledStartTime { get; set; }
        public Nullable<TimeSpan> ScheduledEndTime { get; set; }

        public Shift Shift { get; set; }
        public TaskStatus TaskStatus { get; set; }
        public TaskType TaskType { get; set; }

        public DateTime VerifiedDate { get; set; }
    }

    public enum TaskType
    {
        Unknown,
        Service,
        Recreation,
        Review,
        Assessment,
        Autocomplete
    }

    public enum TaskStatus
    {
        Unknown,
        NotActioned,
        Actioned,
        ActionedNotCompleted,
        AutoComplete

    }
}
