namespace DFEJobs.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedApplicationRelationship : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Applications", "JobId");
            AddForeignKey("dbo.Applications", "JobId", "dbo.Jobs", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Applications", "JobId", "dbo.Jobs");
            DropIndex("dbo.Applications", new[] { "JobId" });
        }
    }
}
