using Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.EntityMapping
{
    public class BaseEntityMapping<TEntity> where TEntity: BaseEntity
    {
        public static void BaseMap(EntityTypeBuilder<TEntity> e)
        {
            e.HasKey(t => t.Id);
        }
    }
}
