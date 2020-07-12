using Data.EntityMapping;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Data.Access
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<Order> Orders { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ItemMapping.Map(modelBuilder.Entity<Item>());
            OrderMapping.Map(modelBuilder.Entity<Order>());

            base.OnModelCreating(modelBuilder);
        }
    }
}
