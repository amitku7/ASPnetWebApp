namespace ASPnetWebApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;
    internal sealed class Configuration : DbMigrationsConfiguration<ASPnetWebApp.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ASPnetWebApp.Models.ApplicationDbContext";
        }

        protected override void Seed(ASPnetWebApp.Models.ApplicationDbContext context)
        {
            context.menuItems.AddOrUpdate(p => p.menuItemId,
                new menuItem
                {
                    menuItemId = 1,
                    Name = "Whole Chicken",
                    description = "Nandoso's whole Chicken",
                    price = System.Convert.ToDouble("20"),
                },new menuItem
                {
                    menuItemId = 2,
                    Name = "Quarter Chicken",
                    description = "Small fraction, big reaction",
                    price = System.Convert.ToDouble("8.9"),
                }
                , new menuItem
                {
                    menuItemId = 3,
                    Name = "Half Chicken",
                    description = "Nothing half hearted here",
                    price = System.Convert.ToDouble("12.90"),
                }, new menuItem
                {
                    menuItemId = 4,
                    Name = "5 Grilled Tenderloins",
                    description = "So tender you'll feel it in your loins",
                    price = System.Convert.ToDouble("11.90"),
                }
                , new menuItem
                {
                    menuItemId = 5,
                    Name = "Espetada (Portuguese Chicken Skewer)",
                    description = "Marinated thigh fillets skewered with fresh red capsicum and onion, flame-grilled to perfection, basted to your heart's desire, served over a regular side.",
                    price = System.Convert.ToDouble("15.90"),
                }
                , new menuItem
                {
                    menuItemId = 6,
                    Name = "Grilled Livers",
                    description = "Grilled in a garlic sauce and basted to your hearts desire.",
                    price = System.Convert.ToDouble("6.90"),
                }


                );




            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
