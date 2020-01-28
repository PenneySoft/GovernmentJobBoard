namespace DFEJobs.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenamingJobModel : DbMigration
    {
        public override void Up()
        {
            RenameColumn("dbo.Jobs", "School", "Location");
        }
        
        public override void Down()
        {
            RenameColumn("dbo.Jobs", "Location", "School");
        }
    }
}
