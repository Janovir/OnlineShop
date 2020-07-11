using Data.Access;
using Data.Repositories.Abstraction.Base;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories.Base
{
    public class CrudRepository<TEntity> : ICrudRepository<TEntity> where TEntity : BaseEntity
    {
        protected ShopContext _dbContext;

        public CrudRepository(ShopContext shopContext)
        {
            _dbContext = shopContext;
        }

        public virtual Task<List<TEntity>> GetAllAsync() => _dbContext.Set<TEntity>().ToListAsync();

        public virtual Task<TEntity> GetAsync(Guid id) => _dbContext.FindAsync<TEntity>(id).AsTask();
    }
}
