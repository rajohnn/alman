using Alman.Data;
using Alman.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alman.Servics
{
    public class SelectionEntityService : ServiceBase
    {
        public SelectionEntityService() : base() { }
        public SelectionEntityService(AlmanContext context) : base(context) { }

        public IEnumerable<ServiceCategory> GetServiceCategories(int partitionId)
        {
            return _ctx.ServiceCategories.Where(c => c.DataPartitionId == partitionId).ToList();          
        }

        public IEnumerable<IncidentType> GetIncidentTypes(int partitionId)
        {
            return _ctx.IncidentTypes.Where(i => i.DataPartitionId == partitionId);
        }

        public IEnumerable<IdentificationType> GetIdentificationTypes(int partitionId)
        {
            return _ctx.IdentificationTypes.Where(i => i.DataPartitionId == partitionId);
        }

        public IEnumerable<InterestLevel> GetInterestLevels(int partitionId)
        {
            return _ctx.InterestLevels.Where(i => i.DataPartitionId == partitionId);
        }

        public IEnumerable<StaffGroup> GetStaffGroup(int partitionId)
        {
            return _ctx.StaffGroups.Where(i => i.DataPartitionId == partitionId);
        }

        public IEnumerable<Shift> GetShifts(int partitionId)
        {
            return _ctx.Shifts.Where(i => i.DataPartitionId == partitionId);
        }

        public IEnumerable<NotDoneReason> GetNotDoneReasons(int partitionId)
        {
            return _ctx.NotDoneReasons.Where(i => i.DataPartitionId == partitionId);
        }

        public IEnumerable<TenantCategory> GetTenantCategories(int partitionId)
        {
            return _ctx.TenantCategories.Where(i => i.DataPartitionId == partitionId);
        }

        public IEnumerable<TenantType> GetTenantTypes(int partitionId)
        {
            return _ctx.TenantTypes.Where(i => i.DataPartitionId == partitionId);
        }

        public IEnumerable<ExitReason> GetExitReasons(int partitionId)
        {
            return _ctx.ExitReasons.Where(i => i.DataPartitionId == partitionId);
        }

        public IEnumerable<Feature> GetFeatures(int partitionId)
        {
            return _ctx.Features.Where(i => i.DataPartitionId == partitionId);
        }

        public IEnumerable<LocationType> GetLocationTypes(int partitionId)
        {
            return _ctx.LocationTypes.Where(i => i.DataPartitionId == partitionId);
        }

        public IEnumerable<ViewType> GetViewTypes(int partitionId)
        {
            return _ctx.ViewTypes.Where(i => i.DataPartitionId == partitionId);
        }

        public IEnumerable<LayoutType> GetLayoutTypes(int partitionId)
        {
            return _ctx.LayoutTypes.Where(i => i.DataPartitionId == partitionId);
        }

        public IEnumerable<FloorPlan> GetFloorPlans(int partitionId)
        {
            return _ctx.FloorPlans.Where(i => i.DataPartitionId == partitionId);
        }
        public IEnumerable<KitchenType> GetKitchenTypes(int partitionId)
        {
            return _ctx.KitchenTypes.Where(i => i.DataPartitionId == partitionId);
        }

        public IEnumerable<TenantContactRelationship> GetTenantContactRelationships(int partitionId)
        {
            return _ctx.TenantContactRelationships.Where(i => i.DataPartitionId == partitionId);
        }

        public IEnumerable<TenantContactType> GetTenantContactTypes(int partitionId)
        {
            return _ctx.TenantContactTypes.Where(i => i.DataPartitionId == partitionId);
        }

        public IEnumerable<CareItem> GetCareItems(int partitionId)
        {
            return _ctx.CareItems.Where(i => i.DataPartitionId == partitionId);
        }

        public IEnumerable<Disease> GetDiseases(int partitionId)
        {
            return _ctx.Diseases.Where(i => i.DataPartitionId == partitionId);
        }

        public IEnumerable<DiseaseStatus> GetDiseaseStatuses(int partitionId)
        {
            return _ctx.DiseaseStatuses.Where(i => i.DataPartitionId == partitionId);
        }

        public IEnumerable<LogEntryType> GetLogEntryTypes(int partitionId)
        {
            return _ctx.LogEntryTypes.Where(i => i.DataPartitionId == partitionId);
        }

        public IEnumerable<RecreationInterestType> GetRecreationInterestTypes(int partitionId)
        {
            return _ctx.RecreationInterestTypes.Where(i => i.DataPartitionId == partitionId);
        }

        public IEnumerable<RiskLevel> GetRiskLevels(int partitionId)
        {
            return _ctx.RiskLevels.Where(i => i.DataPartitionId == partitionId);
        }

        public IEnumerable<SafetyConcern> GetSafetyConcerns(int partitionId)
        {
            return _ctx.SafetyConcerns.Where(i => i.DataPartitionId == partitionId);
        }

        public IEnumerable<RiskAgreement> GetRiskAgreements(int partitionId)
        {
            return _ctx.RiskAgreements.Where(i => i.DataPartitionId == partitionId);
        }

        public IEnumerable<TemperatureLocation> GetTemperatureLocations(int partitionId)
        {
            return _ctx.TemperatureLocations.Where(i => i.DataPartitionId == partitionId);
        }

        public IEnumerable<BloodPressurePosition> GetBloodPressurePositions(int partitionId)
        {
            return _ctx.BloodPressurePositions.Where(i => i.DataPartitionId == partitionId);
        }

        public IEnumerable<OxygenLPM> GetOxygenLPMs(int partitionId)
        {
            return _ctx.OxygenLPMs.Where(i=>i.DataPartitionId == partitionId);
        }

        public IEnumerable<OxygenIntakeMethod> GetOxygenIntakeMethods(int partitionId)
        {
            return _ctx.OxygenIntakeMethods.Where(i=>i.DataPartitionId == partitionId);
        }
    }
}
