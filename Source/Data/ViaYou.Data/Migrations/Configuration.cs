namespace ViaYou.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Domain.Travels;

    internal sealed class Configuration : DbMigrationsConfiguration<ViaYouDataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"Migrations\DbContextMigrations";
        }

        protected override void Seed(ViaYou.Data.ViaYouDataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Categories.AddOrUpdate(
              p => p.Name,
              new Category { Name = "Small/Objects" },
              new Category { Name = "Books" },
              new Category { Name = "Footwear/Clothing" },
              new Category { Name = "Liquids/Organics" },
              new Category { Name = "Electrodomestics" },
              new Category { Name = "Documents" }
            );

            context.ContainedIn.AddOrUpdate(
              p => p.Name,
              new ContainedIn { Name = "30cm x 1cm" },
              new ContainedIn { Name = "20cm x 20cm" },
              new ContainedIn { Name = "30cm x 30cm" },
              new ContainedIn { Name = "40cm x 40cm" },
              new ContainedIn { Name = "50cm x" },
              new ContainedIn { Name = "Other" }
            );
        }
    }
}
