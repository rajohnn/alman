namespace Alman.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VirtualHost_Change : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.VirtualHost", "DataPartitionId");
            AddForeignKey("dbo.VirtualHost", "DataPartitionId", "dbo.DataPartition", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.VirtualHost", "DataPartitionId", "dbo.DataPartition");
            DropIndex("dbo.VirtualHost", new[] { "DataPartitionId" });
        }
    }
}
