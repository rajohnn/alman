using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alman.Domain
{
    public class SelectionEntities
    {
        #region constants 

        public const string INCIDENT_TYPE = "Incident Type";
        public const string IDENTIFICATION_TYPE = "Identification Type";
        public const string INTEREST_LEVEL = "Interest Level";
        public const string SERVICE_CATEGORY = "Service Category";
        public const string STAFF_GROUP = "Staff Group";
        public const string SHIFT = "Shift";
        public const string NOT_DONE_REASON = "Not Done Reason";
        public const string TENANT_CATEGORY = "Tenant Category";
        public const string TENANT_TYPE = "Tenant Type";
        public const string EXIT_REASON = "Exit Reason";
        public const string FEATURE = "Feature";
        public const string LOCATION_TYPE = "Location Type";
        public const string VIEW_TYPE = "View Type";
        public const string LAYOUT_TYPE = "Layout Type";
        public const string FLOOR_PLAN = "Floor Plan";
        public const string KITCHEN_TYPE = "Kitchen Type";
        public const string TENANT_CONTACT_RELATIONSHIP = "Tenant Contact Relationship";
        public const string TENANT_CONTACT_TYPE = "Tenant Contact Type";
        public const string CARE_ITEM = "Care Item";
        public const string DISEASE = "Disease";
        public const string DISEASE_STATUS = "Disease Status";
        public const string LOG_ENTRY_TYPE = "Log Entry Type";
        public const string RECREATION_INTEREST_TYPE = "Recreation Interest Type";
        public const string RISK_LEVEL = "Risk Level";
        public const string SAFETY_CONCERN = "Safety Concern";
        public const string RISK_AGREEMENT = "Risk Agreement";
        public const string TEMPERATURE_LOCATION = "Temperature Location";
        public const string BLOOD_PRESSURE_POSITION = "Blood Pressure Position";
        public const string OXYGEN_LPM = "Oxygen LPM";
        public const string OXYGEN_INTAKE_METHOD = "Oxygen Intake Method";

        #endregion

        public static IEnumerable<string> GetSelectionEntities()
        {
            var list = new List<string>();
            list.Add(SelectionEntities.BLOOD_PRESSURE_POSITION);
            list.Add(SelectionEntities.CARE_ITEM);
            list.Add(SelectionEntities.DISEASE);
            list.Add(SelectionEntities.DISEASE_STATUS);
            list.Add(SelectionEntities.EXIT_REASON);
            list.Add(SelectionEntities.FEATURE);
            list.Add(SelectionEntities.FLOOR_PLAN);
            list.Add(SelectionEntities.IDENTIFICATION_TYPE);
            list.Add(SelectionEntities.INCIDENT_TYPE);
            list.Add(SelectionEntities.INTEREST_LEVEL);
            list.Add(SelectionEntities.KITCHEN_TYPE);
            list.Add(SelectionEntities.LAYOUT_TYPE);
            list.Add(SelectionEntities.LOCATION_TYPE);
            list.Add(SelectionEntities.LOG_ENTRY_TYPE);
            list.Add(SelectionEntities.NOT_DONE_REASON);
            list.Add(SelectionEntities.OXYGEN_INTAKE_METHOD);
            list.Add(SelectionEntities.OXYGEN_LPM);
            list.Add(SelectionEntities.RECREATION_INTEREST_TYPE);
            list.Add(SelectionEntities.RISK_AGREEMENT);
            list.Add(SelectionEntities.RISK_LEVEL);
            list.Add(SelectionEntities.SAFETY_CONCERN);
            list.Add(SelectionEntities.SERVICE_CATEGORY);
            list.Add(SelectionEntities.SHIFT);
            list.Add(SelectionEntities.STAFF_GROUP);
            list.Add(SelectionEntities.TEMPERATURE_LOCATION);
            list.Add(SelectionEntities.TENANT_CATEGORY);
            list.Add(SelectionEntities.TENANT_CONTACT_RELATIONSHIP);
            list.Add(SelectionEntities.TENANT_CONTACT_TYPE);
            list.Add(SelectionEntities.TENANT_TYPE);
            list.Add(SelectionEntities.VIEW_TYPE);          

            list.Sort();
            return list;
        }
    }

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
