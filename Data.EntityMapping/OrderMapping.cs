﻿using System;
using Entities;
using Entities.Abstraction.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Data.EntityMapping
{
    public class OrderMapping : BaseEntityMapping<Order>
    {
        public static void Map(EntityTypeBuilder<Order> e)
        {
            BaseMap(e);

            e.HasIndex(t => t.Name).IsUnique();

            e.Property(t => t.Name).HasMaxLength(50); 
            e.Property(t => t.OrderStatus).IsRequired().HasDefaultValue(OrderStatus.Placed);
        }
    }
}
