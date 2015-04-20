namespace Alman.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class april20_2015 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BloodPressurePosition",
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
                "dbo.DiseaseStatus",
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
                "dbo.InterestLevel",
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
                "dbo.LogEntryType",
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
                "dbo.OxygenIntakeMethod",
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
                "dbo.OxygenLPM",
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
                "dbo.RecreationInterestType",
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
                "dbo.RiskAgreement",
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
                "dbo.RiskLevel",
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
                "dbo.SafetyConcern",
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
                "dbo.TemperatureLocation",
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
                "dbo.TenantContactRelationship",
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
                "dbo.TenantContactType",
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TenantContactType", "ModifiedById", "dbo.User");
            DropForeignKey("dbo.TenantContactRelationship", "ModifiedById", "dbo.User");
            DropForeignKey("dbo.TemperatureLocation", "ModifiedById", "dbo.User");
            DropForeignKey("dbo.SafetyConcern", "ModifiedById", "dbo.User");
            DropForeignKey("dbo.RiskLevel", "ModifiedById", "dbo.User");
            DropForeignKey("dbo.RiskAgreement", "ModifiedById", "dbo.User");
            DropForeignKey("dbo.RecreationInterestType", "ModifiedById", "dbo.User");
            DropForeignKey("dbo.OxygenLPM", "ModifiedById", "dbo.User");
            DropForeignKey("dbo.OxygenIntakeMethod", "ModifiedById", "dbo.User");
            DropForeignKey("dbo.LogEntryType", "ModifiedById", "dbo.User");
            DropForeignKey("dbo.InterestLevel", "ModifiedById", "dbo.User");
            DropForeignKey("dbo.DiseaseStatus", "ModifiedById", "dbo.User");
            DropForeignKey("dbo.BloodPressurePosition", "ModifiedById", "dbo.User");
            DropIndex("dbo.TenantContactType", new[] { "ModifiedById" });
            DropIndex("dbo.TenantContactRelationship", new[] { "ModifiedById" });
            DropIndex("dbo.TemperatureLocation", new[] { "ModifiedById" });
            DropIndex("dbo.SafetyConcern", new[] { "ModifiedById" });
            DropIndex("dbo.RiskLevel", new[] { "ModifiedById" });
            DropIndex("dbo.RiskAgreement", new[] { "ModifiedById" });
            DropIndex("dbo.RecreationInterestType", new[] { "ModifiedById" });
            DropIndex("dbo.OxygenLPM", new[] { "ModifiedById" });
            DropIndex("dbo.OxygenIntakeMethod", new[] { "ModifiedById" });
            DropIndex("dbo.LogEntryType", new[] { "ModifiedById" });
            DropIndex("dbo.InterestLevel", new[] { "ModifiedById" });
            DropIndex("dbo.DiseaseStatus", new[] { "ModifiedById" });
            DropIndex("dbo.BloodPressurePosition", new[] { "ModifiedById" });
            DropTable("dbo.TenantContactType");
            DropTable("dbo.TenantContactRelationship");
            DropTable("dbo.TemperatureLocation");
            DropTable("dbo.SafetyConcern");
            DropTable("dbo.RiskLevel");
            DropTable("dbo.RiskAgreement");
            DropTable("dbo.RecreationInterestType");
            DropTable("dbo.OxygenLPM");
            DropTable("dbo.OxygenIntakeMethod");
            DropTable("dbo.LogEntryType");
            DropTable("dbo.InterestLevel");
            DropTable("dbo.DiseaseStatus");
            DropTable("dbo.BloodPressurePosition");
        }
    }
}
