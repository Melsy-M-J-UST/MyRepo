using Microsoft.EntityFrameworkCore;
using Products.API.Models;

namespace Products.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
                            new Product
                            {
                                Id = 1,
                                Name = "Laptop",
                                Description = "Dell Inspiron",
                                Price = 55000,
                                Stock = 10,
                                SupplierId = 1
                            },
                            new Product
                            {
                                Id = 2,
                                Name = "Mobile",
                                Description = "iPhone 13",
                                Price = 70000,
                                Stock = 5,
                                SupplierId = 2
                            },

                            new Product
                            {
                                Id = 3,
                                Name = "Headphones",
                                Description = "Noise Cancelling",
                                Price = 3000,
                                Stock = 25,
                                SupplierId = 1
                            }
                                        );
        }

    }
}
