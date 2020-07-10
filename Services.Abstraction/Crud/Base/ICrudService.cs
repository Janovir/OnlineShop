using Entities.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstraction.Crud.Base
{
    public interface ICrudService<TEntity>
    {
        Task CreateAsync(TEntity entity);
    }
}
