namespace TaoEFCoBan_2050531200351
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using TaoEFCoBan_2050531200351.Models;

    public partial class ProductDBContext : DbContext
    {
        public ProductDBContext()
            : base("name=ProductDBContext")
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<CategoryOfProduct> CategoryOfProducts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
