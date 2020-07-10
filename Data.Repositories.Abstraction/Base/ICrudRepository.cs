using Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories.Abstraction.Base
{
    public interface ICrudRepository<TEntity> where TEntity : BaseEntity
    {
        Task<TEntity> GetAsync(Guid key);
        Task<List<TEntity>> GetAllAsync();
    }
}
