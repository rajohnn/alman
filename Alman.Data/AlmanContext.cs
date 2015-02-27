namespace Alman.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AlmanContext : DbContext
    {
        public AlmanContext()
            : base("name=AlmanContext")
        {
        }       

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           
        }
    }
}
