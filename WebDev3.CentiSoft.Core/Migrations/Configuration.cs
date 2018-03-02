namespace WebDev3.CentiSoft.Core.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebDev3.CentiSoft.Core.DAL.CentiSoftDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "WebDev3.CentiSoft.Core.DAL.CentiSoftDbContext";
        }

        protected override void Seed(WebDev3.CentiSoft.Core.DAL.CentiSoftDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
