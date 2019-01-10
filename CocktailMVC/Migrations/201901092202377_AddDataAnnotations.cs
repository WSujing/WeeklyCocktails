namespace CocktailMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cocktails", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Cocktails", "Description", c => c.String(nullable: false, maxLength: 500));
            AlterColumn("dbo.Themes", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Themes", "Name", c => c.String());
            AlterColumn("dbo.Cocktails", "Description", c => c.String());
            AlterColumn("dbo.Cocktails", "Name", c => c.String());
        }
    }
}
