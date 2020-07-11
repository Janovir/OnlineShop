using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Access
{
    public static class DbInitialiser
    {
        public static void Initialize(ShopContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Items.Any())
            {
                return;   // DB has been seeded
            }

            var orderID = new Guid("f6614f3c-579e-4ada-b85e-ba62475994a0");
            var orderID2 = new Guid("d401e7d3-b599-4263-a82f-d456abdfe76c");

            var orders = new Order[]
            {
                new Order{Id = orderID, Name = "Order1", UpdatedDate = DateTime.Today, CreatedDate = DateTime.Today},
                new Order{Id = Guid.NewGuid(), Name = "Order2", UpdatedDate = DateTime.Today, CreatedDate = DateTime.Today},
                new Order{Id = Guid.NewGuid(), Name = "Order3", UpdatedDate = DateTime.Today, CreatedDate = DateTime.Today},
                new Order{Id = Guid.NewGuid(), Name = "Order4", UpdatedDate = DateTime.Today, CreatedDate = DateTime.Today},
                new Order{Id = Guid.NewGuid(), Name = "Order5", UpdatedDate = DateTime.Today, CreatedDate = DateTime.Today}
            };

            foreach (Order o in orders)
            {
                context.Orders.Add(o);
            }

            context.SaveChanges();



            var items = new Item[]
            {
                new Item { Id = Guid.NewGuid(), OrderId = orderID, Name = "itemName2", Price = 3.99m, UpdatedDate = DateTime.Today, CreatedDate = DateTime.Today },
                new Item { Id = Guid.NewGuid(), OrderId = orderID, Name = "itemName2", Price = 1.99m, UpdatedDate = DateTime.Today, CreatedDate = DateTime.Today },
                new Item { Id = Guid.NewGuid(), OrderId = orderID, Name = "itemName3", Price = 3.49m, UpdatedDate = DateTime.Today, CreatedDate = DateTime.Today },
                new Item { Id = Guid.NewGuid(), OrderId = orderID2, Name = "itemName4", Price = 3.99m, UpdatedDate = DateTime.Today, CreatedDate = DateTime.Today },
                new Item { Id = Guid.NewGuid(), OrderId = orderID2, Name = "itemName5", Price = 9.99m, UpdatedDate = DateTime.Today, CreatedDate = DateTime.Today },
                new Item { Id = Guid.NewGuid(), OrderId = orderID2, Name = "itemName6", Price = 9.99m, UpdatedDate = DateTime.Today, CreatedDate = DateTime.Today },
                new Item { Id = Guid.NewGuid(), Name = "itemName7", Price = 3.99m, UpdatedDate = DateTime.Today, CreatedDate = DateTime.Today },
                new Item { Id = Guid.NewGuid(), Name = "itemName8", Price = 3.99m, UpdatedDate = DateTime.Today, CreatedDate = DateTime.Today },
            };

            foreach (Item i in items)
            {
                context.Items.Add(i);
            }

            context.SaveChanges();            
        }
    }
}
