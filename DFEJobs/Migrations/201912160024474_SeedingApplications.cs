namespace DFEJobs.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedingApplications : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                SET IDENTITY_INSERT [dbo].[Applications] ON
                INSERT INTO [dbo].[Applications] ([Id], [Name], [Email], [CoverLetter], [JobId]) VALUES (1, N'Andy', N'Andy@gmail.com', N'This is my cover letter for Forest Academy', 1)
                INSERT INTO [dbo].[Applications] ([Id], [Name], [Email], [CoverLetter], [JobId]) VALUES (2, N'Alice', N'Alice@email.com', N'My name is Alice and I am applying for the class Teacher Role.', 1)
                INSERT INTO [dbo].[Applications] ([Id], [Name], [Email], [CoverLetter], [JobId]) VALUES (3, N'Bob', N'Bob@email.com', N'My name is Bob and I am applying for the Department Teacher role.', 3)
                INSERT INTO [dbo].[Applications] ([Id], [Name], [Email], [CoverLetter], [JobId]) VALUES (4, N'Charlie', N'Charlie@email.com', N'My name is Charlie and I am applying for the Headteacher role.', 4)
                INSERT INTO [dbo].[Applications] ([Id], [Name], [Email], [CoverLetter], [JobId]) VALUES (5, N'David', N'David@email.com', N'My name is David and I am applying for the Class Teacher role.', 1)
                INSERT INTO [dbo].[Applications] ([Id], [Name], [Email], [CoverLetter], [JobId]) VALUES (6, N'Eric Banner', N'EricB@email.com', N'My name is Eric and I am applying for the Class Teacher role in Wales.', 6)
                INSERT INTO [dbo].[Applications] ([Id], [Name], [Email], [CoverLetter], [JobId]) VALUES (7, N'Frank', N'Frank@email.com', N'My name is Frank and I am applying for the Department Teacher role.', 3)
                INSERT INTO [dbo].[Applications] ([Id], [Name], [Email], [CoverLetter], [JobId]) VALUES (8, N'Gerald Smith', N'GSmith@email.com', N'Hello, my name is Gerald and I am applying for the Class Teacher role at Forest Academy.', 1)
                INSERT INTO [dbo].[Applications] ([Id], [Name], [Email], [CoverLetter], [JobId]) VALUES (9, N'Imogen', N'Imogen@gmail.com', N'This is my cover letter.', 2)
                INSERT INTO [dbo].[Applications] ([Id], [Name], [Email], [CoverLetter], [JobId]) VALUES (10, N'Harold', N'Harold@email.com', N'My name is Harold and this is my cover letter.', 2)
                SET IDENTITY_INSERT [dbo].[Applications] OFF
            ");
        }
        
        public override void Down()
        {
        }
    }
}
