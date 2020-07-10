using System;
using Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Data.EntityMapping
{
    public class OrderMapping : BaseEntityMapping<Order>
    {
        public static void Map(EntityTypeBuilder<Order> e)
        {
            BaseMap(e);

            e.Property(t => t.OrderStatus).IsRequired();
        }
    }
}
