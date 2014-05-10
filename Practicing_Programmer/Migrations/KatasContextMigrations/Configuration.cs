using System.Data.Entity.Migrations;

namespace Practicing_Programmer.Migrations.KatasContextMigrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Practicing_Programmer.DAL.KatasContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"KatasContextMigrations";
            ContextKey = "Practicing_Programmer.DAL.KatasContext";
        }

        protected override void Seed(Practicing_Programmer.DAL.KatasContext context)
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
