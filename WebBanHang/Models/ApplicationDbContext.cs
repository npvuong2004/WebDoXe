using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebBanHang.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Category> Categories { set; get; }
        public DbSet<Product> Products { set; get; }

        public DbSet<Order> Orders { set; get; }
        public DbSet<OrderDetail> orderDetails { set; get; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //seed data to table Categories
            modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Yamaha", DisplayOrder = 1 },
            new Category { Id = 2, Name = "Honda", DisplayOrder = 2 },
            new Category { Id = 3, Name = "Suzuki", DisplayOrder = 3 });
            //seed data to table Product
            modelBuilder.Entity<Product>().HasData(
            new Product { Id = 1, Name = "Exciter 135 62zz", Price = 300, CategoryId = 1 },
            new Product { Id = 2, Name = "Exciter 135 65zz", Price = 350, CategoryId = 1 },
            new Product { Id = 3, Name = "Exciter 135 68zz", Price = 400, CategoryId = 1 },
            new Product { Id = 4, Name = "Exciter 135 72+4", Price = 420, CategoryId = 1 },
            new Product { Id = 5, Name = "Exciter 150 62zz", Price = 630, CategoryId = 1 },
            new Product { Id = 6, Name = "Exciter 150 65zz", Price = 750, CategoryId = 1 },
            new Product { Id = 7, Name = "Exciter 150 72z6", Price = 820, CategoryId = 1 },
            new Product { Id = 8, Name = "Exciter 150 68z8", Price = 950, CategoryId = 1 },
            new Product { Id = 9, Name = "Winner V1 62zz", Price = 1200, CategoryId = 2 },
            new Product { Id = 10, Name = "Winner V1 65zz ", Price = 1450, CategoryId = 2 },
            new Product { Id = 11, Name = "Winner X v1 68z6", Price = 750, CategoryId = 2 },
            new Product { Id = 12, Name = "Winner X v2 65zz", Price = 1250, CategoryId = 2 },
            new Product { Id = 13, Name = "Winner X v2 68zz", Price = 1250, CategoryId = 2 },
            new Product { Id = 14, Name = "Winner X v1 65zz", Price = 1250, CategoryId = 2 },
            new Product { Id = 15, Name = "Winner V1 65zz", Price = 1250, CategoryId = 2 },
            new Product { Id = 16, Name = "Winner V1 74z8", Price = 1250, CategoryId = 2 },
            new Product { Id = 17, Name = "Raider xc 62zz", Price = 1250, CategoryId = 3 },
            new Product { Id = 18, Name = "Raider 150 68zz", Price = 1250, CategoryId = 3 },
            new Product { Id = 19, Name = "Satria 68zz", Price = 1250, CategoryId = 3 },
            new Product { Id = 20, Name = "Satria 71z4", Price = 1250, CategoryId = 3 });
        }
    }
}
