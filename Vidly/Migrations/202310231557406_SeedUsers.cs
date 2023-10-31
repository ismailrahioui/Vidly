namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"

                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'19a9341c-d1b2-4a69-bc8b-e6f443cb77b7', N'guest@vidly.com', 0, N'AEeH7PFxqBGeGVtyt2TV7iZJFVNTn/LcRqpldXlTIXwFNBfeYfwy+6tMTlrJh/34vA==', N'674ac8e1-9bfc-4a24-afa3-6a14bd5512e7', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ea57fd04-9f10-477e-964e-43b77b0d40d2', N'admin@vidly.com', 0, N'AHGMZwdMqXjiVoRohYc1xf+/e1MOftL9EzJB3fPqCdq8IqTrLovZ7dslcin9OhXavg==', N'76158527-57be-4390-9b50-43e6b2d1e36a', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'33c7c6d1-fe10-4611-9fbc-a7a6a6f2fb07', N'CanManageMovies')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ea57fd04-9f10-477e-964e-43b77b0d40d2', N'33c7c6d1-fe10-4611-9fbc-a7a6a6f2fb07')


");
        }
        
        public override void Down()
        {
        }
    }
}
