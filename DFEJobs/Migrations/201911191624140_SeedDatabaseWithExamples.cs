namespace DFEJobs.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedDatabaseWithExamples : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO Jobs (Title, School, Salary, Description) VALUES ('Class Teacher', 'Mildenhall College Academy, Bury Saint Edmunds, Suffolk', 30000, 'The governors at Mildenhall College Academy are seeking to appoint an inspirational teacher to join our hardworking and committed team. Our pupils need a teacher who will ensure that they make excellent progress by making learning exciting, challenging, memorable and fun.')
                INSERT INTO Jobs (Title, School, Salary, Description) VALUES ('Physics Teacher', 'Hitchin Boys School, Hitchin, Hertfordshire', 28000, 'The governors at Hitchin Boys School are seeking to appoint an inspirational teacher to join our hardworking and committed team. Our pupils need a teacher who will ensure that they make excellent progress by making learning exciting, challenging, memorable and fun.')
                INSERT INTO Jobs (Title, School, Salary, Description) VALUES ('Department Teacher', 'Everest Community Academy, Baskingstoke, Hampshire', 25000, 'The governors at Everest Community Academy are seeking to appoint an inspirational teacher to join our hardworking and committed team. Our pupils need a teacher who will ensure that they make excellent progress by making learning exciting, challenging, memorable and fun.')
                INSERT INTO Jobs (Title, School, Salary, Description) VALUES ('Headteacher', 'Petham Primary School, Canterbury, Kent', 35000, 'The governors at Petham Primary School are seeking to appoint an inspirational headteacher to join our hardworking and committed team. Our pupils need a teacher who will ensure that they make excellent progress by making learning exciting, challenging, memorable and fun.')
                INSERT INTO Jobs (Title, School, Salary, Description) VALUES ('Science Teacher', 'Gomeldon County Primary School, Salisbury, Wiltshire', 24000, 'The governors at Gomeldon County Primary School are seeking to appoint an inspirational teacher to join our hardworking and committed team. Our pupils need a teacher who will ensure that they make excellent progress by making learning exciting, challenging, memorable and fun.')
                INSERT INTO Jobs (Title, School, Salary, Description) VALUES ('Maths Teacher', 'Forden Church in Wales School, Welshpool, Wales', 26000, 'The governors at Forden Church in Wales School are seeking to appoint an inspirational teacher to join our hardworking and committed team. Our pupils need a teacher who will ensure that they make excellent progress by making learning exciting, challenging, memorable and fun.')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
