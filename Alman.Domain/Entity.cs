using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alman.Domain
{
    public abstract class Entity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        public DateTime LastModified { get; set; }
        public bool IsDeleted { get; set; }
        
        public virtual User ModifiedBy { get; set;}
    }

    abstract public class UserSortableEntity : Entity
    {
        public int SortOrder { get; set; }

        public UserSortableEntity()
        {
            this.SortOrder = 1;
        }
    }

    abstract public class SelectionTypeEntity : UserSortableEntity
    {
        public string Name { get; set; }
        public string Value { get; set; }

        public string Description { get; set; }
        public string UserGuidance { get; set; }

        public DateTime? ExpirationDate { get; set; }

        public SelectionTypeEntity()
        {
            this.ExpirationDate = null;
        }
    }
}
