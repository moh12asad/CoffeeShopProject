namespace CoffeeShopProject.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CoffeeShopProject.UserDal.ProductsDal>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "CoffeeShopProject.UserDal.ProductsDal";
        }

        protected override void Seed(CoffeeShopProject.UserDal.ProductsDal context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
