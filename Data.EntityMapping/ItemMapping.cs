using System;
using Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Data.EntityMapping
{
    public class ItemMapping : BaseEntityMapping<Item>
    {
        public static void Map(EntityTypeBuilder<Item> e)
        {
            BaseMap(e);

            e.Property(t => t.Price).IsRequired();
        }
    }
}
