namespace Rently.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'1ceb5f3b-4303-4493-9648-cc93994ccee5', N'admin@rently.com', 0, N'AEc9YrpZxYfgZrp2KBT1Lo+s4c/IvZ3WtNvJZKwwD3WtD2bOgvcvlh6qwNDRQRgdbw==', N'6abffbce-ce00-4b5f-bc88-a825bf5d65f0', NULL, 0, 0, NULL, 1, 0, N'admin@rently.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'1d383db6-ed30-41fe-add3-5f33dd24efae', N'guest@rently.com', 0, N'AMMfWYW5T2sGvCkO5/wKeJeJL1qO/paWXiCAGgBVd2birduM8AIcEoeoQvGKeEW/pA==', N'd6594e5a-9247-471f-8af0-d856a80cceda', NULL, 0, 0, NULL, 1, 0, N'guest@rently.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'd86825bd-af46-4572-8db5-290b087a6ff8', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'1ceb5f3b-4303-4493-9648-cc93994ccee5', N'd86825bd-af46-4572-8db5-290b087a6ff8')

");
        }
        
        public override void Down()
        {
        }
    }
}
