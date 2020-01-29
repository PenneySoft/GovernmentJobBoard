namespace DFEJobs.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingDepartmentToCurrentJobs : DbMigration
    {
        public override void Up()
        {
            Sql(@"UPDATE Jobs SET Department = 'Education' WHERE Id IS NOT NULL");
        }
        
        public override void Down()
        {
        }
    }
}
