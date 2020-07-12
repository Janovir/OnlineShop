using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Data.EntityMapping
{
    public class ItemMapping : BaseEntityMapping<Item>
    {
        public static void Map(EntityTypeBuilder<Item> e)
        {
            BaseMap(e);

            e.HasIndex(t => t.Name).IsUnique();

            e.Property(t => t.Name).HasMaxLength(50);
            e.Property(t => t.Price).IsRequired();
            e.HasOne(t => t.Order).WithMany(o => o.Items).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
