using PointOfSale.Models;

namespace PointOfSale.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PointOfSale.Data.Database.Context.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PointOfSale.Data.Database.Context.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            if (!context.Users.Any())
            {
                context.Users.AddRange(new[]
                {
                    new User(){EmployeeNumber = "100", FirstName = "John", LastName = "Doe", IsClockedIn = true, Password = "1234", PhoneNumber = "(123) 456-7890"}, 
                    new User(){EmployeeNumber = "101", FirstName = "Jane", LastName = "Doe", IsClockedIn = true, Password = "1234", PhoneNumber = "(456) 789-1011"}, 
                    new User(){EmployeeNumber = "102", FirstName = "Paul", LastName = "Smith", IsClockedIn = false, Password = "1234", PhoneNumber = "(789) 101-1121"}, 
                });
            }
        }
    }
}
