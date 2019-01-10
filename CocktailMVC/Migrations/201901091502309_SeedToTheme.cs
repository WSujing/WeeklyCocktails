namespace CocktailMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedToTheme : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO THEMES (Name) VALUES ('Classic Cocktail')");
            Sql("INSERT INTO THEMES (Name) VALUES ('Spring Cocktail')");
            Sql("INSERT INTO THEMES (Name) VALUES ('Hot Alcoholic Drinks')");
        }
        
        public override void Down()
        {
        }
    }
}
