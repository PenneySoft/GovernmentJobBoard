namespace DFEJobs.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TableLinkAddedBetweenJobAndApplication : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Applications", "Job_Id", c => c.Int());
            CreateIndex("dbo.Applications", "Job_Id");
            AddForeignKey("dbo.Applications", "Job_Id", "dbo.Jobs", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Applications", "Job_Id", "dbo.Jobs");
            DropIndex("dbo.Applications", new[] { "Job_Id" });
            DropColumn("dbo.Applications", "Job_Id");
        }
    }
}
