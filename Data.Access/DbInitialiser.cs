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

            var orders = new Order[]
            {                
                new Order{Id = orderID, Name = "Order1", UpdatedDate = DateTime.Today, CreatedDate = DateTime.Today}
            };

            foreach (Order o in orders)
            {
                context.Orders.Add(o);
            }

            context.SaveChanges();



            var items = new Item[]
            {
                new Item { Id = new Guid("45bc5498-8738-435e-a99b-66f2120b9cef"), OrderId = orderID, Name = "itemName1", Price = 3.99m, UpdatedDate = DateTime.Today, CreatedDate = DateTime.Today }
            };

            foreach (Item i in items)
            {
                context.Items.Add(i);
            }

            context.SaveChanges();            
        }
    }
}
