namespace sd207417MIS4200.Migrations.MISContext
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<sd207417MIS4200.DAL.MIS4200>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"Migrations\MISContext";
            ContextKey = "sd207417MIS4200.DAL.MIS4200";
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(sd207417MIS4200.DAL.MIS4200 context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
