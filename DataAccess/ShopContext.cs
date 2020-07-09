using Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccess
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}
