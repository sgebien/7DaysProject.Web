namespace _7DaysProject.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<_7DaysProject.DataAccessLayer.SalesERPDAL>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "_7DaysProject.DataAccessLayer.SalesERPDAL";
        }

        protected override void Seed(_7DaysProject.DataAccessLayer.SalesERPDAL context)
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
        }
    }
}
