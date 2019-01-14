namespace CocktailMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'2d63ccdc-c41e-40ec-afb2-28651156956e', N'admin@admin.com', 0, N'AFGhnpRU4Jfg7GAVFhJ+D6LbZmkM1Rjf08VfdXqbeL97jpUeARiGS2ntaTkvEhOAIA==', N'bf7c9a3f-e9cc-4e72-b7ba-c35065034045', NULL, 0, 0, NULL, 1, 0, N'admin@admin.com')");
            Sql("INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'76fa080f-d8fd-416c-af05-bf886205a3f6', N'BarManager')");
            Sql("INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'2d63ccdc-c41e-40ec-afb2-28651156956e', N'76fa080f-d8fd-416c-af05-bf886205a3f6')");
        }
        
        public override void Down()
        {
        }
    }
}
