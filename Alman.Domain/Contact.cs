﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alman.Domain
{
    [Table("Contact")]
    public class Contact : ClientEntity
    {
        public ContactType ContactType { get; set; }
        public string Title { get; set; }

        public string EmailAddress { get; set; }
        public string Prefix { get; set; }
        public string Suffix { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }

        public string Notes { get; set; }
        public string PreferredName { get; set; }

        public Contact()
        { }
    }

    [Table("Payer")]
    public class Payer : ClientEntity
    {
        public Contact Contact { get; set; }
        public bool IsTaxExempt { get; set; }
    }   

    public enum ContactType
    {
        Tenant,
        Staff,
        Contact
    }
}
