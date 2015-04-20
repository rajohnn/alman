using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alman.Domain
{
    [Table("IncidentType")]
    public class IncidentType : SelectionTypeEntity { }

    [Table("IdentificationType")]
    public class IdentificationType : SelectionTypeEntity { }

    [Table("InterestLevel")]
    public class InterestLevel : SelectionTypeEntity { }

    [Table("ServiceCategory")]
    public class ServiceCategory : SelectionTypeEntity { }

    [Table("StaffGroup")]
    public class StaffGroup : SelectionTypeEntity { }

    [Table("Shift")]
    public class Shift : SelectionTypeEntity { }

    [Table("NotDoneReason")]
    public class NotDoneReason : SelectionTypeEntity { }

    [Table("TenantCategory")]
    public class TenantCategory : SelectionTypeEntity { }

    [Table("TenantType")]
    public class TenantType : SelectionTypeEntity { }

    [Table("ExitReason")]
    public class ExitReason : SelectionTypeEntity { }

    [Table("Feature")]
    public class Feature : SelectionTypeEntity { }

    [Table("LocationType")]
    public class LocationType : SelectionTypeEntity { }

    [Table("ViewType")]
    public class ViewType : SelectionTypeEntity { }

    [Table("LayoutType")]
    public class LayoutType : SelectionTypeEntity { }

    [Table("FloorPlan")]
    public class FloorPlan : SelectionTypeEntity { }

    [Table("KitchenType")]
    public class KitchenType : SelectionTypeEntity { }

    [Table("TenantContactRelationship")]
    public class TenantContactRelationship : SelectionTypeEntity { }

    [Table("TenantContactType")]
    public class TenantContactType : SelectionTypeEntity { }

    [Table("CareItem")]
    public class CareItem : SelectionTypeEntity { }

    [Table("Disease")]
    public class Disease : SelectionTypeEntity { }

    [Table("DiseaseStatus")]
    public class DiseaseStatus : SelectionTypeEntity { }

    [Table("LogEntryType")]
    public class LogEntryType : SelectionTypeEntity { }

    [Table("RecreationInterestType")]
    public class RecreationInterestType : SelectionTypeEntity { }

    [Table("RiskLevel")]
    public class RiskLevel : SelectionTypeEntity { }

    [Table("SafetyConcern")]
    public class SafetyConcern : SelectionTypeEntity { }

    [Table("RiskAgreement")]
    public class RiskAgreement : SelectionTypeEntity { }

    [Table("TemperatureLocation")]
    public class TemperatureLocation : SelectionTypeEntity { }

    [Table("BloodPressurePosition")]
    public class BloodPressurePosition : SelectionTypeEntity { }

    [Table("OxygenLPM")]
    public class OxygenLPM : SelectionTypeEntity { }

    [Table("OxygenIntakeMethod")]
    public class OxygenIntakeMethod : SelectionTypeEntity { }
}
