using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alman.Domain
{
    [Table("Location")]
    public class Location : ClientEntity
    {
        public string Name { get; set; }
        public Address Address { get; set; }
        public Location ParentLocation { get; set; }

        public ICollection<LocationFeature> LocationFeatures { get; set; }

        public LocationType LocationType { get; set; }
        public ViewType ViewType { get; set; }
        public LayoutType LayoutType { get; set; }
        public KitchenType KitchenType { get; set; }
        public FloorPlan FloorPlan { get; set; }

        public string DisplayName { get; set; }
        public string EntryCode { get; set; }

        public bool HasBalcony { get; set; }
        public bool HasFireplace { get; set; }
        public bool HasOxygen { get; set; }
        public bool HasPatio { get; set; }
        public bool HasSmoker { get; set; }
        public bool IsAirConditioned { get; set; }
        public bool IsNoisySuite { get; set; }
        public bool IsRentOnHold { get; set; }
        public bool IsSuite { get; set; }
        public bool IsWheelchairAccessible { get; set; }

        public int MaximumOccupancy { get; set; }

        public string Notes { get; set; }
        public int Bathrooms { get; set; }
        public int Bedrooms { get; set; }

        public string ParkingStall { get; set; }
        public string RecurrenceRule { get; set; }
        public decimal Rent { get; set; }

        public int SquareFootage { get; set; }
        public bool BillAhead { get; set; }

        public Location()
        {
            this.LocationFeatures = new List<LocationFeature>();
        }
    }
    /// <summary>
    /// This list of features mapped to a particular location.
    /// </summary>
    [Table("LocationFeature")]
    public class LocationFeature : UserSortableEntity
    {
        public Feature Feature { get; set; }
        public Location Location { get; set; }
        public string Description { get; set; }
    }

    [Table("LocationKey")]
    public class LocationKey : UserSortableEntity
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public Contact Contact { get; set; }
        public Location Location { get; set; }
    }
}
