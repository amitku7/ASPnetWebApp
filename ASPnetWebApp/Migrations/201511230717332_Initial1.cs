namespace ASPnetWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.menuItems", "price", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.menuItems", "price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
