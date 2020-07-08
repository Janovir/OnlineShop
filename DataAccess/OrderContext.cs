using Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccess
{
    public class OrderContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=OnlineShop;Trusted_Connection=True;");
        }
    }
}
