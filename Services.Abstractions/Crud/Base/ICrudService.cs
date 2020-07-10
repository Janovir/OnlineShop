using Entities;
using Entity.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Crud.Base
{
    public interface ICrudService<TEntity> where TEntity : class, IBaseEntity
    {
    }
}
