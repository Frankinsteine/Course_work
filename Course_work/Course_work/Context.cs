using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Course_work
{
    class Context : DbContext
    {
        public DbSet<Products> Products { get; set; }
        public DbSet<ProductName> ProductName { get; set; }
        public DbSet<Manufacturer> Manufacturer { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<OrderProducts> OrderProducts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ProductShopDB;Trusted_Connection=True;");
        }
    }
}
