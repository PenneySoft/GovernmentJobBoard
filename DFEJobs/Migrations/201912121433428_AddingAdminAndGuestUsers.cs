namespace DFEJobs.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingAdminAndGuestUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'670a8df9-da77-484d-b34c-a2d830fcd019', N'SuperAdmin@Government.co.uk', 0, N'ALZuOIBd0npitogb3EdLSfN2oiNfd/IfNxtPRWCo/evlvP5UOxmKZwDV1EnuDsQnaA==', N'a10c4564-4b6e-4955-a7cc-5c11e40951ce', NULL, 0, 0, NULL, 1, 0, N'SuperAdmin@Government.co.uk')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'7568d1be-d44c-4e52-922b-018070e6ae21', N'Admin@government.co.uk', 0, N'AA54mhg8DuBo0Y7o1+csuJ3sxtJXSaer7jc2zM/8XVJbU81kNFASIOMark/PtV+iZw==', N'3626b0ec-fabe-4a82-ae75-50f0a7201314', NULL, 0, 0, NULL, 1, 0, N'Admin@government.co.uk')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8ad4a932-13d3-4bc0-bc9d-beb5830ac4ce', N'penney@hotmail.co.uk', 0, N'ANWX6JNAR2aMT5/k3lCtE6VXXqadzTleVQ9rNaHgvUvh5AdeVmQoiLlv026IVnCIXA==', N'73f5a3b0-ebb2-4b82-b42d-7462f3b7db67', NULL, 0, 0, NULL, 1, 0, N'penney@hotmail.co.uk')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8b2d4d79-18a4-4863-b524-cbb749a0accd', N'njp13b@gmail.com', 0, N'AJ/3ByhY/2T+RYwU+8u45Uj35onw4LfhKiCsEDhriRKmU8NOmOMG3RWBp1UOZkSL8w==', N'bfdf58e5-181f-4cfd-8b95-80ce3ffa4d52', NULL, 0, 0, NULL, 1, 0, N'njp13b@gmail.com')

            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'535e3c1a-52bb-4870-b4f4-6c6a22632594', N'CanCreateJobs')
            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'8f83d163-6591-4f12-baf3-e2afec64e9d5', N'CanDeleteJobs')

            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'7568d1be-d44c-4e52-922b-018070e6ae21', N'535e3c1a-52bb-4870-b4f4-6c6a22632594')
            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'8ad4a932-13d3-4bc0-bc9d-beb5830ac4ce', N'535e3c1a-52bb-4870-b4f4-6c6a22632594')
            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'670a8df9-da77-484d-b34c-a2d830fcd019', N'8f83d163-6591-4f12-baf3-e2afec64e9d5')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
