namespace DFEJobs.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DepartmentAddedToJob : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Jobs", "Department", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Jobs", "Department");
        }
    }
}
