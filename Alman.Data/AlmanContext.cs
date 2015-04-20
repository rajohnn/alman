namespace Alman.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Alman.Domain;

    public partial class AlmanContext : DbContext
    {
        public AlmanContext()
            : base("name=AlmanContext")
        {
        }

        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<IdentificationType> IdentificationTypes { get; set; }
        public virtual DbSet<Payer> Payers { get; set; }
        public virtual DbSet<ContactPhoto> ContactPhotos { get; set; }        
        public virtual DbSet<IncidentType> IncidentTypes { get; set; }

        public virtual DbSet<UserActivityLog> MemberActivityLogs { get; set; }
        public virtual DbSet<Phone> Phones { get; set; }
        
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<Shift> Shifts { get; set; }
        public virtual DbSet<NotDoneReason> NotDoneReasons { get; set; }
        public virtual DbSet<TenantCategory> TenantCategories { get; set; }
        public virtual DbSet<TenantType> TenantTypes { get; set; }
        public virtual DbSet<ExitReason> ExitReasons { get; set; }
        public virtual DbSet<Tenant> Tenants { get; set; }

        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<RolePermission> RolePermissions { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }

        public virtual DbSet<TenantService> TenantServices { get; set; }
        public virtual DbSet<TenantServicePayer> TenantServicePayers { get; set; }
        public virtual DbSet<TenantServiceRange> TenantServiceRanges { get; set; }

        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Feature> Features { get; set; }
        public virtual DbSet<LocationType> LocationTypes { get; set; }
        public virtual DbSet<ViewType> ViewTypes { get; set; }
        public virtual DbSet<LayoutType> LayoutTypes { get; set; }
        public virtual DbSet<FloorPlan> FloorPlans { get; set; }
        public virtual DbSet<KitchenType> KitchenTypes { get; set; }

        public virtual DbSet<CareItem> CareItems { get; set; }
        
        public virtual DbSet<Disease> Diseases { get; set; }
        public virtual DbSet<DataPartition> DataPartitions { get; set; }
        public virtual DbSet<VirtualHost> VirtualHost { get; set; }

        public virtual DbSet<ServiceCategory> ServiceCategories { get; set; }
        public virtual DbSet<InterestLevel> InterestLevels { get; set; }
        public virtual DbSet<StaffGroup> StaffGroups { get; set; }
        public virtual DbSet<TenantContactRelationship> TenantContactRelationships { get; set; }
        public virtual DbSet<TenantContactType> TenantContactTypes { get; set; }
        public virtual DbSet<DiseaseStatus> DiseaseStatuses { get; set; }
        public virtual DbSet<LogEntryType> LogEntryTypes { get; set; }
        public virtual DbSet<RecreationInterestType> RecreationInterestTypes { get; set; }
        public virtual DbSet<RiskLevel> RiskLevels { get; set; }
        public virtual DbSet<SafetyConcern> SafetyConcerns { get; set; }
        public virtual DbSet<RiskAgreement> RiskAgreements { get; set; }
        public virtual DbSet<TemperatureLocation> TemperatureLocations { get; set; }
        public virtual DbSet<BloodPressurePosition> BloodPressurePositions { get; set; }
        public virtual DbSet<OxygenLPM> OxygenLPMs { get; set; }
        public virtual DbSet<OxygenIntakeMethod> OxygenIntakeMethods { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("User");
            });

            modelBuilder.Entity<Contact>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Contact");
            });

            modelBuilder.Entity<Service>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("Service");
            });

            modelBuilder.Entity<ServiceCategory>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("ServiceCategory");
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
