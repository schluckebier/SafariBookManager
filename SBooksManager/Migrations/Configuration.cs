namespace SBooksManager.Migrations
{
    using System.Collections.Generic;
    using SBooksManager.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SBooksManager.DAL.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SBooksManager.DAL.AppDbContext context)
        {
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

            var customers = new List<Customer>
            {
                new Customer { FName="Christopher", MI = "L", StreetAddress = "1245 Lake Austin Blvd.", Zip="78733", Phone ="5125571146"  },
                
                
            };
            //customers.ForEach(s => context.Customers.AddOrUpdate(p => p.Customer, s));
            context.SaveChanges();


        }

    }
}
