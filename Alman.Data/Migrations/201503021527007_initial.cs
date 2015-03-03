namespace Alman.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Address",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AddressType = c.Int(nullable: false),
                        Street1 = c.String(),
                        Street2 = c.String(),
                        City = c.String(),
                        State = c.String(),
                        PostalCode = c.String(),
                        DataPartitionId = c.Int(nullable: false),
                        LastModified = c.DateTime(nullable: false),
                        ModifiedById = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.ModifiedById, cascadeDelete: true)
                .Index(t => t.ModifiedById);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        PasswordHash = c.String(),
                        PasswordSalt = c.String(),
                        PasswordExpirationDate = c.DateTime(nullable: false),
                        DataPartitionId = c.Int(nullable: false),
                        LastModified = c.DateTime(nullable: false),
                        ModifiedById = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.ModifiedById)
                .Index(t => t.ModifiedById);
            
            CreateTable(
                "dbo.Contact",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ContactType = c.Int(nullable: false),
                        Title = c.String(),
                        EmailAddress = c.String(),
                        Prefix = c.String(),
                        Suffix = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        MiddleName = c.String(),
                        Notes = c.String(),
                        PreferredName = c.String(),
                        DataPartitionId = c.Int(nullable: false),
                        LastModified = c.DateTime(nullable: false),
                        ModifiedById = c.Int(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.CareItem",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Value = c.String(),
                        Description = c.String(),
                        UserGuidance = c.String(),
                        ExpirationDate = c.DateTime(),
                        SortOrder = c.Int(nullable: false),
                        DataPartitionId = c.Int(nullable: false),
                        LastModified = c.DateTime(nullable: false),
                        ModifiedById = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.ModifiedById, cascadeDelete: true)
                .Index(t => t.ModifiedById);
            
            CreateTable(
                "dbo.ContactPhoto",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullSize = c.Binary(),
                        Thumbnail = c.Binary(),
                        FileType = c.String(),
                        DataPartitionId = c.Int(nullable: false),
                        LastModified = c.DateTime(nullable: false),
                        ModifiedById = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Contact_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Contact", t => t.Contact_Id)
                .ForeignKey("dbo.User", t => t.ModifiedById, cascadeDelete: true)
                .Index(t => t.ModifiedById)
                .Index(t => t.Contact_Id);
            
            CreateTable(
                "dbo.DataPartition",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Disease",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Value = c.String(),
                        Description = c.String(),
                        UserGuidance = c.String(),
                        ExpirationDate = c.DateTime(),
                        SortOrder = c.Int(nullable: false),
                        DataPartitionId = c.Int(nullable: false),
                        LastModified = c.DateTime(nullable: false),
                        ModifiedById = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.ModifiedById, cascadeDelete: true)
                .Index(t => t.ModifiedById);
            
            CreateTable(
                "dbo.ExitReason",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Value = c.String(),
                        Description = c.String(),
                        UserGuidance = c.String(),
                        ExpirationDate = c.DateTime(),
                        SortOrder = c.Int(nullable: false),
                        DataPartitionId = c.Int(nullable: false),
                        LastModified = c.DateTime(nullable: false),
                        ModifiedById = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.ModifiedById, cascadeDelete: true)
                .Index(t => t.ModifiedById);
            
            CreateTable(
                "dbo.Feature",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Value = c.String(),
                        Description = c.String(),
                        UserGuidance = c.String(),
                        ExpirationDate = c.DateTime(),
                        SortOrder = c.Int(nullable: false),
                        DataPartitionId = c.Int(nullable: false),
                        LastModified = c.DateTime(nullable: false),
                        ModifiedById = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.ModifiedById, cascadeDelete: true)
                .Index(t => t.ModifiedById);
            
            CreateTable(
                "dbo.FloorPlan",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Value = c.String(),
                        Description = c.String(),
                        UserGuidance = c.String(),
                        ExpirationDate = c.DateTime(),
                        SortOrder = c.Int(nullable: false),
                        DataPartitionId = c.Int(nullable: false),
                        LastModified = c.DateTime(nullable: false),
                        ModifiedById = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.ModifiedById, cascadeDelete: true)
                .Index(t => t.ModifiedById);
            
            CreateTable(
                "dbo.IdentificationType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Value = c.String(),
                        Description = c.String(),
                        UserGuidance = c.String(),
                        ExpirationDate = c.DateTime(),
                        SortOrder = c.Int(nullable: false),
                        DataPartitionId = c.Int(nullable: false),
                        LastModified = c.DateTime(nullable: false),
                        ModifiedById = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.ModifiedById, cascadeDelete: true)
                .Index(t => t.ModifiedById);
            
            CreateTable(
                "dbo.IncidentType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Value = c.String(),
                        Description = c.String(),
                        UserGuidance = c.String(),
                        ExpirationDate = c.DateTime(),
                        SortOrder = c.Int(nullable: false),
                        DataPartitionId = c.Int(nullable: false),
                        LastModified = c.DateTime(nullable: false),
                        ModifiedById = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.ModifiedById, cascadeDelete: true)
                .Index(t => t.ModifiedById);
            
            CreateTable(
                "dbo.KitchenType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Value = c.String(),
                        Description = c.String(),
                        UserGuidance = c.String(),
                        ExpirationDate = c.DateTime(),
                        SortOrder = c.Int(nullable: false),
                        DataPartitionId = c.Int(nullable: false),
                        LastModified = c.DateTime(nullable: false),
                        ModifiedById = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.ModifiedById, cascadeDelete: true)
                .Index(t => t.ModifiedById);
            
            CreateTable(
                "dbo.LayoutType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Value = c.String(),
                        Description = c.String(),
                        UserGuidance = c.String(),
                        ExpirationDate = c.DateTime(),
                        SortOrder = c.Int(nullable: false),
                        DataPartitionId = c.Int(nullable: false),
                        LastModified = c.DateTime(nullable: false),
                        ModifiedById = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.ModifiedById, cascadeDelete: true)
                .Index(t => t.ModifiedById);
            
            CreateTable(
                "dbo.Location",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DisplayName = c.String(),
                        EntryCode = c.String(),
                        HasBalcony = c.Boolean(nullable: false),
                        HasFireplace = c.Boolean(nullable: false),
                        HasOxygen = c.Boolean(nullable: false),
                        HasPatio = c.Boolean(nullable: false),
                        HasSmoker = c.Boolean(nullable: false),
                        IsAirConditioned = c.Boolean(nullable: false),
                        IsNoisySuite = c.Boolean(nullable: false),
                        IsRentOnHold = c.Boolean(nullable: false),
                        IsSuite = c.Boolean(nullable: false),
                        IsWheelchairAccessible = c.Boolean(nullable: false),
                        MaximumOccupancy = c.Int(nullable: false),
                        Notes = c.String(),
                        Bathrooms = c.Int(nullable: false),
                        Bedrooms = c.Int(nullable: false),
                        ParkingStall = c.String(),
                        RecurrenceRule = c.String(),
                        Rent = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SquareFootage = c.Int(nullable: false),
                        BillAhead = c.Boolean(nullable: false),
                        DataPartitionId = c.Int(nullable: false),
                        LastModified = c.DateTime(nullable: false),
                        ModifiedById = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Address_Id = c.Int(),
                        FloorPlan_Id = c.Int(),
                        KitchenType_Id = c.Int(),
                        LayoutType_Id = c.Int(),
                        LocationType_Id = c.Int(),
                        ParentLocation_Id = c.Int(),
                        ViewType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Address", t => t.Address_Id)
                .ForeignKey("dbo.FloorPlan", t => t.FloorPlan_Id)
                .ForeignKey("dbo.KitchenType", t => t.KitchenType_Id)
                .ForeignKey("dbo.LayoutType", t => t.LayoutType_Id)
                .ForeignKey("dbo.LocationType", t => t.LocationType_Id)
                .ForeignKey("dbo.User", t => t.ModifiedById, cascadeDelete: true)
                .ForeignKey("dbo.Location", t => t.ParentLocation_Id)
                .ForeignKey("dbo.ViewType", t => t.ViewType_Id)
                .Index(t => t.ModifiedById)
                .Index(t => t.Address_Id)
                .Index(t => t.FloorPlan_Id)
                .Index(t => t.KitchenType_Id)
                .Index(t => t.LayoutType_Id)
                .Index(t => t.LocationType_Id)
                .Index(t => t.ParentLocation_Id)
                .Index(t => t.ViewType_Id);
            
            CreateTable(
                "dbo.LocationFeature",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        SortOrder = c.Int(nullable: false),
                        DataPartitionId = c.Int(nullable: false),
                        LastModified = c.DateTime(nullable: false),
                        ModifiedById = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Feature_Id = c.Int(),
                        Location_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Feature", t => t.Feature_Id)
                .ForeignKey("dbo.Location", t => t.Location_Id)
                .ForeignKey("dbo.User", t => t.ModifiedById, cascadeDelete: true)
                .Index(t => t.ModifiedById)
                .Index(t => t.Feature_Id)
                .Index(t => t.Location_Id);
            
            CreateTable(
                "dbo.LocationType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Value = c.String(),
                        Description = c.String(),
                        UserGuidance = c.String(),
                        ExpirationDate = c.DateTime(),
                        SortOrder = c.Int(nullable: false),
                        DataPartitionId = c.Int(nullable: false),
                        LastModified = c.DateTime(nullable: false),
                        ModifiedById = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.ModifiedById, cascadeDelete: true)
                .Index(t => t.ModifiedById);
            
            CreateTable(
                "dbo.ViewType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Value = c.String(),
                        Description = c.String(),
                        UserGuidance = c.String(),
                        ExpirationDate = c.DateTime(),
                        SortOrder = c.Int(nullable: false),
                        DataPartitionId = c.Int(nullable: false),
                        LastModified = c.DateTime(nullable: false),
                        ModifiedById = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.ModifiedById, cascadeDelete: true)
                .Index(t => t.ModifiedById);
            
            CreateTable(
                "dbo.MemberActivityLog",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EventTimestamp = c.DateTime(nullable: false),
                        EventType = c.Int(nullable: false),
                        Information = c.String(),
                        IpAddress = c.Binary(),
                        Successful = c.Boolean(nullable: false),
                        Browser = c.String(),
                        BrowserMajor = c.String(),
                        BrowserMinor = c.String(),
                        UserAgent = c.String(),
                        DataPartitionId = c.Int(nullable: false),
                        LastModified = c.DateTime(nullable: false),
                        ModifiedById = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.ModifiedById, cascadeDelete: true)
                .ForeignKey("dbo.User", t => t.User_Id)
                .Index(t => t.ModifiedById)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.NotDoneReason",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Value = c.String(),
                        Description = c.String(),
                        UserGuidance = c.String(),
                        ExpirationDate = c.DateTime(),
                        SortOrder = c.Int(nullable: false),
                        DataPartitionId = c.Int(nullable: false),
                        LastModified = c.DateTime(nullable: false),
                        ModifiedById = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.ModifiedById, cascadeDelete: true)
                .Index(t => t.ModifiedById);
            
            CreateTable(
                "dbo.Payer",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsTaxExempt = c.Boolean(nullable: false),
                        DataPartitionId = c.Int(nullable: false),
                        LastModified = c.DateTime(nullable: false),
                        ModifiedById = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Contact_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Contact", t => t.Contact_Id)
                .ForeignKey("dbo.User", t => t.ModifiedById, cascadeDelete: true)
                .Index(t => t.ModifiedById)
                .Index(t => t.Contact_Id);
            
            CreateTable(
                "dbo.Permissions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DataPartitionId = c.Int(nullable: false),
                        LastModified = c.DateTime(nullable: false),
                        ModifiedById = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Role_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.ModifiedById, cascadeDelete: true)
                .ForeignKey("dbo.Roles", t => t.Role_Id)
                .Index(t => t.ModifiedById)
                .Index(t => t.Role_Id);
            
            CreateTable(
                "dbo.Phone",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.String(),
                        PhoneType = c.Int(nullable: false),
                        SortOrder = c.Int(nullable: false),
                        DataPartitionId = c.Int(nullable: false),
                        LastModified = c.DateTime(nullable: false),
                        ModifiedById = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Contact_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Contact", t => t.Contact_Id)
                .ForeignKey("dbo.User", t => t.ModifiedById, cascadeDelete: true)
                .Index(t => t.ModifiedById)
                .Index(t => t.Contact_Id);
            
            CreateTable(
                "dbo.RolePermissions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DataPartitionId = c.Int(nullable: false),
                        LastModified = c.DateTime(nullable: false),
                        ModifiedById = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Permission_Id = c.Int(),
                        Role_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.ModifiedById, cascadeDelete: true)
                .ForeignKey("dbo.Permissions", t => t.Permission_Id)
                .ForeignKey("dbo.Roles", t => t.Role_Id)
                .Index(t => t.ModifiedById)
                .Index(t => t.Permission_Id)
                .Index(t => t.Role_Id);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DataPartitionId = c.Int(nullable: false),
                        LastModified = c.DateTime(nullable: false),
                        ModifiedById = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.ModifiedById, cascadeDelete: true)
                .Index(t => t.ModifiedById);
            
            CreateTable(
                "dbo.Service",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Duration = c.Time(nullable: false, precision: 7),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MinutesUntilOverdue = c.Int(nullable: false),
                        AccountCode = c.String(),
                        SubaccountCode = c.String(),
                        ApplyTax = c.Boolean(nullable: false),
                        AutoComplete = c.Boolean(nullable: false),
                        AutoVerify = c.Boolean(nullable: false),
                        ChargeNotComplete = c.Boolean(nullable: false),
                        IgnoreStatus = c.Boolean(nullable: false),
                        TrackServiceDeliveryMinutes = c.Boolean(nullable: false),
                        NotDoneReasonRequired = c.Boolean(nullable: false),
                        AutoCreateOnNewClients = c.Boolean(nullable: false),
                        DataPartitionId = c.Int(nullable: false),
                        LastModified = c.DateTime(nullable: false),
                        ModifiedById = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        ServiceCategory_Id = c.Int(),
                        StaffGroup_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.ModifiedById, cascadeDelete: true)
                .ForeignKey("dbo.ServiceCategory", t => t.ServiceCategory_Id)
                .ForeignKey("dbo.StaffGroup", t => t.StaffGroup_Id)
                .Index(t => t.ModifiedById)
                .Index(t => t.ServiceCategory_Id)
                .Index(t => t.StaffGroup_Id);
            
            CreateTable(
                "dbo.ServiceCategory",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Value = c.String(),
                        Description = c.String(),
                        UserGuidance = c.String(),
                        ExpirationDate = c.DateTime(),
                        SortOrder = c.Int(nullable: false),
                        DataPartitionId = c.Int(nullable: false),
                        LastModified = c.DateTime(nullable: false),
                        ModifiedById = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.ModifiedById, cascadeDelete: true)
                .Index(t => t.ModifiedById);
            
            CreateTable(
                "dbo.StaffGroup",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Value = c.String(),
                        Description = c.String(),
                        UserGuidance = c.String(),
                        ExpirationDate = c.DateTime(),
                        SortOrder = c.Int(nullable: false),
                        DataPartitionId = c.Int(nullable: false),
                        LastModified = c.DateTime(nullable: false),
                        ModifiedById = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.ModifiedById, cascadeDelete: true)
                .Index(t => t.ModifiedById);
            
            CreateTable(
                "dbo.Shift",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Value = c.String(),
                        Description = c.String(),
                        UserGuidance = c.String(),
                        ExpirationDate = c.DateTime(),
                        SortOrder = c.Int(nullable: false),
                        DataPartitionId = c.Int(nullable: false),
                        LastModified = c.DateTime(nullable: false),
                        ModifiedById = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.ModifiedById, cascadeDelete: true)
                .Index(t => t.ModifiedById);
            
            CreateTable(
                "dbo.Task",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ScheduledDate = c.DateTime(nullable: false),
                        ActualDuration = c.Time(precision: 7),
                        DefaultDuration = c.Time(precision: 7),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Instructions = c.String(),
                        Notes = c.String(),
                        RequiresVerification = c.Boolean(nullable: false),
                        ScheduledStartTime = c.Time(precision: 7),
                        ScheduledEndTime = c.Time(precision: 7),
                        TaskStatus = c.Int(nullable: false),
                        TaskType = c.Int(nullable: false),
                        VerifiedDate = c.DateTime(nullable: false),
                        DataPartitionId = c.Int(nullable: false),
                        LastModified = c.DateTime(nullable: false),
                        ModifiedById = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        ActionedBy_Id = c.Int(),
                        Location_Id = c.Int(),
                        NotDoneReason_Id = c.Int(),
                        Shift_Id = c.Int(),
                        Tenant_Id = c.Int(),
                        TenantService_Id = c.Int(),
                        VerifiedBy_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.ActionedBy_Id)
                .ForeignKey("dbo.Location", t => t.Location_Id)
                .ForeignKey("dbo.User", t => t.ModifiedById, cascadeDelete: true)
                .ForeignKey("dbo.NotDoneReason", t => t.NotDoneReason_Id)
                .ForeignKey("dbo.Shift", t => t.Shift_Id)
                .ForeignKey("dbo.Tenant", t => t.Tenant_Id)
                .ForeignKey("dbo.TenantService", t => t.TenantService_Id)
                .ForeignKey("dbo.Contact", t => t.VerifiedBy_Id)
                .Index(t => t.ModifiedById)
                .Index(t => t.ActionedBy_Id)
                .Index(t => t.Location_Id)
                .Index(t => t.NotDoneReason_Id)
                .Index(t => t.Shift_Id)
                .Index(t => t.Tenant_Id)
                .Index(t => t.TenantService_Id)
                .Index(t => t.VerifiedBy_Id);
            
            CreateTable(
                "dbo.Tenant",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TenantStatus = c.Int(nullable: false),
                        MartialStatus = c.Int(nullable: false),
                        Gender = c.Int(nullable: false),
                        SocialSecurityNumber = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        FollowUpDate = c.DateTime(nullable: false),
                        NextReviewDate = c.DateTime(nullable: false),
                        OccupancyDate = c.DateTime(nullable: false),
                        PossessionDate = c.DateTime(nullable: false),
                        MoveOutDate = c.DateTime(nullable: false),
                        ExitDate = c.DateTime(nullable: false),
                        PreviousPostalCode = c.String(),
                        PreviousState = c.String(),
                        DataPartitionId = c.Int(nullable: false),
                        LastModified = c.DateTime(nullable: false),
                        ModifiedById = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Contact_Id = c.Int(),
                        ExitReason_Id = c.Int(),
                        FollowUpRequestedBy_Id = c.Int(),
                        Location_Id = c.Int(),
                        MarketingAddress_Id = c.Int(),
                        TenantCategory_Id = c.Int(),
                        TenantType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Contact", t => t.Contact_Id)
                .ForeignKey("dbo.ExitReason", t => t.ExitReason_Id)
                .ForeignKey("dbo.User", t => t.FollowUpRequestedBy_Id)
                .ForeignKey("dbo.Location", t => t.Location_Id)
                .ForeignKey("dbo.Address", t => t.MarketingAddress_Id)
                .ForeignKey("dbo.User", t => t.ModifiedById, cascadeDelete: true)
                .ForeignKey("dbo.TenantCategory", t => t.TenantCategory_Id)
                .ForeignKey("dbo.TenantType", t => t.TenantType_Id)
                .Index(t => t.ModifiedById)
                .Index(t => t.Contact_Id)
                .Index(t => t.ExitReason_Id)
                .Index(t => t.FollowUpRequestedBy_Id)
                .Index(t => t.Location_Id)
                .Index(t => t.MarketingAddress_Id)
                .Index(t => t.TenantCategory_Id)
                .Index(t => t.TenantType_Id);
            
            CreateTable(
                "dbo.TenantCategory",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Value = c.String(),
                        Description = c.String(),
                        UserGuidance = c.String(),
                        ExpirationDate = c.DateTime(),
                        SortOrder = c.Int(nullable: false),
                        DataPartitionId = c.Int(nullable: false),
                        LastModified = c.DateTime(nullable: false),
                        ModifiedById = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.ModifiedById, cascadeDelete: true)
                .Index(t => t.ModifiedById);
            
            CreateTable(
                "dbo.TenantType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Value = c.String(),
                        Description = c.String(),
                        UserGuidance = c.String(),
                        ExpirationDate = c.DateTime(),
                        SortOrder = c.Int(nullable: false),
                        DataPartitionId = c.Int(nullable: false),
                        LastModified = c.DateTime(nullable: false),
                        ModifiedById = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.ModifiedById, cascadeDelete: true)
                .Index(t => t.ModifiedById);
            
            CreateTable(
                "dbo.TenantService",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartDate = c.DateTime(nullable: false),
                        Duration = c.Time(nullable: false, precision: 7),
                        Instructions = c.String(),
                        IsOnlyOnTempLeave = c.Boolean(nullable: false),
                        OverrideDefaultMinutes = c.Boolean(nullable: false),
                        RecurrenceRule = c.String(),
                        LastTaskGeneratedOn = c.DateTime(),
                        DataPartitionId = c.Int(nullable: false),
                        LastModified = c.DateTime(nullable: false),
                        ModifiedById = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Service_Id = c.Int(),
                        Tenant_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.ModifiedById, cascadeDelete: true)
                .ForeignKey("dbo.Service", t => t.Service_Id)
                .ForeignKey("dbo.Tenant", t => t.Tenant_Id)
                .Index(t => t.ModifiedById)
                .Index(t => t.Service_Id)
                .Index(t => t.Tenant_Id);
            
            CreateTable(
                "dbo.TenantServicePayer",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        FixedPaymentAmount = c.Decimal(precision: 18, scale: 2),
                        FixedPaymentPercentage = c.Decimal(precision: 18, scale: 2),
                        DefaultPayer = c.Boolean(nullable: false),
                        MaximumPaymentAmount = c.Decimal(precision: 18, scale: 2),
                        Note = c.String(),
                        Notify = c.Boolean(nullable: false),
                        DataPartitionId = c.Int(nullable: false),
                        LastModified = c.DateTime(nullable: false),
                        ModifiedById = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Payer_Id = c.Int(),
                        TenantService_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.ModifiedById, cascadeDelete: true)
                .ForeignKey("dbo.Payer", t => t.Payer_Id)
                .ForeignKey("dbo.TenantService", t => t.TenantService_Id)
                .Index(t => t.ModifiedById)
                .Index(t => t.Payer_Id)
                .Index(t => t.TenantService_Id);
            
            CreateTable(
                "dbo.TenantServiceRange",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartTime = c.Time(nullable: false, precision: 7),
                        EndTime = c.Time(nullable: false, precision: 7),
                        SpecificTime = c.Time(nullable: false, precision: 7),
                        DataPartitionId = c.Int(nullable: false),
                        LastModified = c.DateTime(nullable: false),
                        ModifiedById = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Shift_Id = c.Int(),
                        TenantService_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.ModifiedById, cascadeDelete: true)
                .ForeignKey("dbo.Shift", t => t.Shift_Id)
                .ForeignKey("dbo.TenantService", t => t.TenantService_Id)
                .Index(t => t.ModifiedById)
                .Index(t => t.Shift_Id)
                .Index(t => t.TenantService_Id);
            
            CreateTable(
                "dbo.UserRoles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DataPartitionId = c.Int(nullable: false),
                        LastModified = c.DateTime(nullable: false),
                        ModifiedById = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Role_Id = c.Int(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.ModifiedById, cascadeDelete: true)
                .ForeignKey("dbo.Roles", t => t.Role_Id)
                .ForeignKey("dbo.User", t => t.User_Id)
                .Index(t => t.ModifiedById)
                .Index(t => t.Role_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.VirtualHost",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DomainName = c.String(),
                        Description = c.String(),
                        DataPartitionId = c.Int(nullable: false),
                        LastModified = c.DateTime(nullable: false),
                        ModifiedById = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.ModifiedById, cascadeDelete: true)
                .Index(t => t.ModifiedById);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.VirtualHost", "ModifiedById", "dbo.User");
            DropForeignKey("dbo.UserRoles", "User_Id", "dbo.User");
            DropForeignKey("dbo.UserRoles", "Role_Id", "dbo.Roles");
            DropForeignKey("dbo.UserRoles", "ModifiedById", "dbo.User");
            DropForeignKey("dbo.TenantServiceRange", "TenantService_Id", "dbo.TenantService");
            DropForeignKey("dbo.TenantServiceRange", "Shift_Id", "dbo.Shift");
            DropForeignKey("dbo.TenantServiceRange", "ModifiedById", "dbo.User");
            DropForeignKey("dbo.TenantServicePayer", "TenantService_Id", "dbo.TenantService");
            DropForeignKey("dbo.TenantServicePayer", "Payer_Id", "dbo.Payer");
            DropForeignKey("dbo.TenantServicePayer", "ModifiedById", "dbo.User");
            DropForeignKey("dbo.Task", "VerifiedBy_Id", "dbo.Contact");
            DropForeignKey("dbo.Task", "TenantService_Id", "dbo.TenantService");
            DropForeignKey("dbo.TenantService", "Tenant_Id", "dbo.Tenant");
            DropForeignKey("dbo.TenantService", "Service_Id", "dbo.Service");
            DropForeignKey("dbo.TenantService", "ModifiedById", "dbo.User");
            DropForeignKey("dbo.Task", "Tenant_Id", "dbo.Tenant");
            DropForeignKey("dbo.Tenant", "TenantType_Id", "dbo.TenantType");
            DropForeignKey("dbo.TenantType", "ModifiedById", "dbo.User");
            DropForeignKey("dbo.Tenant", "TenantCategory_Id", "dbo.TenantCategory");
            DropForeignKey("dbo.TenantCategory", "ModifiedById", "dbo.User");
            DropForeignKey("dbo.Tenant", "ModifiedById", "dbo.User");
            DropForeignKey("dbo.Tenant", "MarketingAddress_Id", "dbo.Address");
            DropForeignKey("dbo.Tenant", "Location_Id", "dbo.Location");
            DropForeignKey("dbo.Tenant", "FollowUpRequestedBy_Id", "dbo.User");
            DropForeignKey("dbo.Tenant", "ExitReason_Id", "dbo.ExitReason");
            DropForeignKey("dbo.Tenant", "Contact_Id", "dbo.Contact");
            DropForeignKey("dbo.Task", "Shift_Id", "dbo.Shift");
            DropForeignKey("dbo.Task", "NotDoneReason_Id", "dbo.NotDoneReason");
            DropForeignKey("dbo.Task", "ModifiedById", "dbo.User");
            DropForeignKey("dbo.Task", "Location_Id", "dbo.Location");
            DropForeignKey("dbo.Task", "ActionedBy_Id", "dbo.User");
            DropForeignKey("dbo.Shift", "ModifiedById", "dbo.User");
            DropForeignKey("dbo.Service", "StaffGroup_Id", "dbo.StaffGroup");
            DropForeignKey("dbo.StaffGroup", "ModifiedById", "dbo.User");
            DropForeignKey("dbo.Service", "ServiceCategory_Id", "dbo.ServiceCategory");
            DropForeignKey("dbo.ServiceCategory", "ModifiedById", "dbo.User");
            DropForeignKey("dbo.Service", "ModifiedById", "dbo.User");
            DropForeignKey("dbo.RolePermissions", "Role_Id", "dbo.Roles");
            DropForeignKey("dbo.Permissions", "Role_Id", "dbo.Roles");
            DropForeignKey("dbo.Roles", "ModifiedById", "dbo.User");
            DropForeignKey("dbo.RolePermissions", "Permission_Id", "dbo.Permissions");
            DropForeignKey("dbo.RolePermissions", "ModifiedById", "dbo.User");
            DropForeignKey("dbo.Phone", "ModifiedById", "dbo.User");
            DropForeignKey("dbo.Phone", "Contact_Id", "dbo.Contact");
            DropForeignKey("dbo.Permissions", "ModifiedById", "dbo.User");
            DropForeignKey("dbo.Payer", "ModifiedById", "dbo.User");
            DropForeignKey("dbo.Payer", "Contact_Id", "dbo.Contact");
            DropForeignKey("dbo.NotDoneReason", "ModifiedById", "dbo.User");
            DropForeignKey("dbo.MemberActivityLog", "User_Id", "dbo.User");
            DropForeignKey("dbo.MemberActivityLog", "ModifiedById", "dbo.User");
            DropForeignKey("dbo.Location", "ViewType_Id", "dbo.ViewType");
            DropForeignKey("dbo.ViewType", "ModifiedById", "dbo.User");
            DropForeignKey("dbo.Location", "ParentLocation_Id", "dbo.Location");
            DropForeignKey("dbo.Location", "ModifiedById", "dbo.User");
            DropForeignKey("dbo.Location", "LocationType_Id", "dbo.LocationType");
            DropForeignKey("dbo.LocationType", "ModifiedById", "dbo.User");
            DropForeignKey("dbo.LocationFeature", "ModifiedById", "dbo.User");
            DropForeignKey("dbo.LocationFeature", "Location_Id", "dbo.Location");
            DropForeignKey("dbo.LocationFeature", "Feature_Id", "dbo.Feature");
            DropForeignKey("dbo.Location", "LayoutType_Id", "dbo.LayoutType");
            DropForeignKey("dbo.Location", "KitchenType_Id", "dbo.KitchenType");
            DropForeignKey("dbo.Location", "FloorPlan_Id", "dbo.FloorPlan");
            DropForeignKey("dbo.Location", "Address_Id", "dbo.Address");
            DropForeignKey("dbo.LayoutType", "ModifiedById", "dbo.User");
            DropForeignKey("dbo.KitchenType", "ModifiedById", "dbo.User");
            DropForeignKey("dbo.IncidentType", "ModifiedById", "dbo.User");
            DropForeignKey("dbo.IdentificationType", "ModifiedById", "dbo.User");
            DropForeignKey("dbo.FloorPlan", "ModifiedById", "dbo.User");
            DropForeignKey("dbo.Feature", "ModifiedById", "dbo.User");
            DropForeignKey("dbo.ExitReason", "ModifiedById", "dbo.User");
            DropForeignKey("dbo.Disease", "ModifiedById", "dbo.User");
            DropForeignKey("dbo.ContactPhoto", "ModifiedById", "dbo.User");
            DropForeignKey("dbo.ContactPhoto", "Contact_Id", "dbo.Contact");
            DropForeignKey("dbo.CareItem", "ModifiedById", "dbo.User");
            DropForeignKey("dbo.Address", "ModifiedById", "dbo.User");
            DropForeignKey("dbo.User", "ModifiedById", "dbo.User");
            DropForeignKey("dbo.Contact", "Id", "dbo.User");
            DropIndex("dbo.VirtualHost", new[] { "ModifiedById" });
            DropIndex("dbo.UserRoles", new[] { "User_Id" });
            DropIndex("dbo.UserRoles", new[] { "Role_Id" });
            DropIndex("dbo.UserRoles", new[] { "ModifiedById" });
            DropIndex("dbo.TenantServiceRange", new[] { "TenantService_Id" });
            DropIndex("dbo.TenantServiceRange", new[] { "Shift_Id" });
            DropIndex("dbo.TenantServiceRange", new[] { "ModifiedById" });
            DropIndex("dbo.TenantServicePayer", new[] { "TenantService_Id" });
            DropIndex("dbo.TenantServicePayer", new[] { "Payer_Id" });
            DropIndex("dbo.TenantServicePayer", new[] { "ModifiedById" });
            DropIndex("dbo.TenantService", new[] { "Tenant_Id" });
            DropIndex("dbo.TenantService", new[] { "Service_Id" });
            DropIndex("dbo.TenantService", new[] { "ModifiedById" });
            DropIndex("dbo.TenantType", new[] { "ModifiedById" });
            DropIndex("dbo.TenantCategory", new[] { "ModifiedById" });
            DropIndex("dbo.Tenant", new[] { "TenantType_Id" });
            DropIndex("dbo.Tenant", new[] { "TenantCategory_Id" });
            DropIndex("dbo.Tenant", new[] { "MarketingAddress_Id" });
            DropIndex("dbo.Tenant", new[] { "Location_Id" });
            DropIndex("dbo.Tenant", new[] { "FollowUpRequestedBy_Id" });
            DropIndex("dbo.Tenant", new[] { "ExitReason_Id" });
            DropIndex("dbo.Tenant", new[] { "Contact_Id" });
            DropIndex("dbo.Tenant", new[] { "ModifiedById" });
            DropIndex("dbo.Task", new[] { "VerifiedBy_Id" });
            DropIndex("dbo.Task", new[] { "TenantService_Id" });
            DropIndex("dbo.Task", new[] { "Tenant_Id" });
            DropIndex("dbo.Task", new[] { "Shift_Id" });
            DropIndex("dbo.Task", new[] { "NotDoneReason_Id" });
            DropIndex("dbo.Task", new[] { "Location_Id" });
            DropIndex("dbo.Task", new[] { "ActionedBy_Id" });
            DropIndex("dbo.Task", new[] { "ModifiedById" });
            DropIndex("dbo.Shift", new[] { "ModifiedById" });
            DropIndex("dbo.StaffGroup", new[] { "ModifiedById" });
            DropIndex("dbo.ServiceCategory", new[] { "ModifiedById" });
            DropIndex("dbo.Service", new[] { "StaffGroup_Id" });
            DropIndex("dbo.Service", new[] { "ServiceCategory_Id" });
            DropIndex("dbo.Service", new[] { "ModifiedById" });
            DropIndex("dbo.Roles", new[] { "ModifiedById" });
            DropIndex("dbo.RolePermissions", new[] { "Role_Id" });
            DropIndex("dbo.RolePermissions", new[] { "Permission_Id" });
            DropIndex("dbo.RolePermissions", new[] { "ModifiedById" });
            DropIndex("dbo.Phone", new[] { "Contact_Id" });
            DropIndex("dbo.Phone", new[] { "ModifiedById" });
            DropIndex("dbo.Permissions", new[] { "Role_Id" });
            DropIndex("dbo.Permissions", new[] { "ModifiedById" });
            DropIndex("dbo.Payer", new[] { "Contact_Id" });
            DropIndex("dbo.Payer", new[] { "ModifiedById" });
            DropIndex("dbo.NotDoneReason", new[] { "ModifiedById" });
            DropIndex("dbo.MemberActivityLog", new[] { "User_Id" });
            DropIndex("dbo.MemberActivityLog", new[] { "ModifiedById" });
            DropIndex("dbo.ViewType", new[] { "ModifiedById" });
            DropIndex("dbo.LocationType", new[] { "ModifiedById" });
            DropIndex("dbo.LocationFeature", new[] { "Location_Id" });
            DropIndex("dbo.LocationFeature", new[] { "Feature_Id" });
            DropIndex("dbo.LocationFeature", new[] { "ModifiedById" });
            DropIndex("dbo.Location", new[] { "ViewType_Id" });
            DropIndex("dbo.Location", new[] { "ParentLocation_Id" });
            DropIndex("dbo.Location", new[] { "LocationType_Id" });
            DropIndex("dbo.Location", new[] { "LayoutType_Id" });
            DropIndex("dbo.Location", new[] { "KitchenType_Id" });
            DropIndex("dbo.Location", new[] { "FloorPlan_Id" });
            DropIndex("dbo.Location", new[] { "Address_Id" });
            DropIndex("dbo.Location", new[] { "ModifiedById" });
            DropIndex("dbo.LayoutType", new[] { "ModifiedById" });
            DropIndex("dbo.KitchenType", new[] { "ModifiedById" });
            DropIndex("dbo.IncidentType", new[] { "ModifiedById" });
            DropIndex("dbo.IdentificationType", new[] { "ModifiedById" });
            DropIndex("dbo.FloorPlan", new[] { "ModifiedById" });
            DropIndex("dbo.Feature", new[] { "ModifiedById" });
            DropIndex("dbo.ExitReason", new[] { "ModifiedById" });
            DropIndex("dbo.Disease", new[] { "ModifiedById" });
            DropIndex("dbo.ContactPhoto", new[] { "Contact_Id" });
            DropIndex("dbo.ContactPhoto", new[] { "ModifiedById" });
            DropIndex("dbo.CareItem", new[] { "ModifiedById" });
            DropIndex("dbo.Contact", new[] { "Id" });
            DropIndex("dbo.User", new[] { "ModifiedById" });
            DropIndex("dbo.Address", new[] { "ModifiedById" });
            DropTable("dbo.VirtualHost");
            DropTable("dbo.UserRoles");
            DropTable("dbo.TenantServiceRange");
            DropTable("dbo.TenantServicePayer");
            DropTable("dbo.TenantService");
            DropTable("dbo.TenantType");
            DropTable("dbo.TenantCategory");
            DropTable("dbo.Tenant");
            DropTable("dbo.Task");
            DropTable("dbo.Shift");
            DropTable("dbo.StaffGroup");
            DropTable("dbo.ServiceCategory");
            DropTable("dbo.Service");
            DropTable("dbo.Roles");
            DropTable("dbo.RolePermissions");
            DropTable("dbo.Phone");
            DropTable("dbo.Permissions");
            DropTable("dbo.Payer");
            DropTable("dbo.NotDoneReason");
            DropTable("dbo.MemberActivityLog");
            DropTable("dbo.ViewType");
            DropTable("dbo.LocationType");
            DropTable("dbo.LocationFeature");
            DropTable("dbo.Location");
            DropTable("dbo.LayoutType");
            DropTable("dbo.KitchenType");
            DropTable("dbo.IncidentType");
            DropTable("dbo.IdentificationType");
            DropTable("dbo.FloorPlan");
            DropTable("dbo.Feature");
            DropTable("dbo.ExitReason");
            DropTable("dbo.Disease");
            DropTable("dbo.DataPartition");
            DropTable("dbo.ContactPhoto");
            DropTable("dbo.CareItem");
            DropTable("dbo.Contact");
            DropTable("dbo.User");
            DropTable("dbo.Address");
        }
    }
}
