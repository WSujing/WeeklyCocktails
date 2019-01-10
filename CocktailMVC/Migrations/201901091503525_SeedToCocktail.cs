namespace CocktailMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedToCocktail : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO COCKTAILS (Name, Price, Description, ThemeId) VALUES ('Tom-jerry', 129, 'With Cognac, dark Rum and hot milk', 1)");
            Sql("INSERT INTO COCKTAILS (Name, Price, Description, ThemeId) VALUES ('The hornitos hot shotty', 109, 'With Bourbon, spiced Rum, milk and egges.', 2)");
            Sql("INSERT INTO COCKTAILS (Name, Price, Description, ThemeId) VALUES ('Rooster tail', 129, 'With Peychauds Bitters, Peach brandy and Rsapberry syrup.', 3)");
            Sql("INSERT INTO COCKTAILS (Name, Price, Description, ThemeId) VALUES ('Paloma', 129, 'With Tequila, Fresh lime juice and Grapefruit soda.', 1)");
            Sql("INSERT INTO COCKTAILS (Name, Price, Description, ThemeId) VALUES ('Manhattan', 129, 'With Bourbon, Angostura bitters, Sweet vermouth.', 2)");
            Sql("INSERT INTO COCKTAILS (Name, Price, Description, ThemeId) VALUES ('Gin-fizz', 129, 'With Gin, lemon juice, and Egg white.', 3)");
            Sql("INSERT INTO COCKTAILS (Name, Price, Description, ThemeId) VALUES ('Eggnog', 109, 'With Bourbon, Spiced rum, eggs and milk.', 1)");
            Sql("INSERT INTO COCKTAILS (Name, Price, Description, ThemeId) VALUES ('Beggars banquet', 129,'With Makers Mark Bourbon, Angostura bitters and Maple syrup.', 2)");
        }
        
        public override void Down()
        {
        }
    }
}
