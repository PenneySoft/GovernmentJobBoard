namespace DFEJobs.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NoDbRleationship : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Applications", "Job_Id", "dbo.Jobs");
            DropIndex("dbo.Applications", new[] { "Job_Id" });
            AddColumn("dbo.Applications", "JobId", c => c.Int(nullable: false));
            DropColumn("dbo.Applications", "Job_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Applications", "Job_Id", c => c.Int());
            DropColumn("dbo.Applications", "JobId");
            CreateIndex("dbo.Applications", "Job_Id");
            AddForeignKey("dbo.Applications", "Job_Id", "dbo.Jobs", "Id");
        }
    }
}
