namespace Weather_API.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Weather_API.ForecastSet>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Weather_API.ForecastSet";
        }

        protected override void Seed(Weather_API.ForecastSet context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
