using Microsoft.EntityFrameworkCore;
using Shop.Models;

namespace Shop.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "果汁", DisplayOrder = 1 },
                new Category { Id = 2, Name = "茶", DisplayOrder = 2 },
                new Category { Id = 3, Name = "咖啡", DisplayOrder = 3 }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "台灣水果茶",
                    Size = "大杯",
                    Description = "天然果飲",
                    Price = 60,
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 2,
                    Name = "觀音",
                    Size = "中杯",
                    Description = "品鐵觀音",
                    Price = 35,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 3,
                    Name = "美式咖啡",
                    Size = "中杯",
                    Description = "美式",
                    Price = 50,
                    CategoryId = 3,
                    ImageUrl = ""
                }
                );
        }
    }
}
