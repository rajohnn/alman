using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alman.Domain
{
    [Table("MemberActivityLog")]
    public class UserActivityLog : ClientEntity
    {
        public User User { get; set; }
        public DateTime EventTimestamp { get; set; }
        public EventType EventType { get; set; }
        public string Information { get; set; }
        public byte[] IpAddress { get; set; }

        public bool Successful { get; set; }
        public string Browser { get; set; }
        public string BrowserMajor { get; set; }
        public string BrowserMinor { get; set; }
        public string UserAgent { get; set; }
    }

    public enum EventType
    {
        Unknown,
        Login,
        Logout,
        RunReport
    }
}
