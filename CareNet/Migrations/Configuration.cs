namespace CareNet.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using CareNet.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<CareNet.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(CareNet.Models.ApplicationDbContext context)
        {
            //  seed with admin account
            var passwordHash = new Microsoft.AspNet.Identity.PasswordHasher();
            string password = passwordHash.HashPassword("Password.0301");
            context.Users.AddOrUpdate(u => u.UserName,
                new ApplicationUser
                {
                    UserName = "admin@rhaccess.com",
                    Email = "admin@rhaccess.com",
                    PasswordHash = password,
                    SecurityStamp = Guid.NewGuid().ToString()
                });

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
