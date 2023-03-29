namespace TaoEFCoBan_2050531200351.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TaoEFCoBan_2050531200351.ProductDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "TaoEFCoBan_2050531200351.ProductDBContext";
        }

        protected override void Seed(TaoEFCoBan_2050531200351.ProductDBContext context)
        {
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.CategoryOfProducts.AddOrUpdate(c => c.CategoryOfProductID,
                new Models.CategoryOfProduct { CategoryOfProductID = 1, Description = @"Đồ điện tử" },
                new Models.CategoryOfProduct { CategoryOfProductID = 2, Description = @"Đồ nhà bếp" }
                );
            context.Products.AddOrUpdate(p => p.ProductID,
                new Models.Product { ProductID = 1, NameOfProduct = @"Quạt điện", CategoryOfProductID = 1 },
                new Models.Product { ProductID = 2, NameOfProduct = @"Chảo", CategoryOfProductID = 2 }
                );

        }
    }
}
