using Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories.Abstraction.Base
{
    public interface IDbCrudRepository<TEntity> where TEntity : BaseEntity
    {
        Task<TEntity> CreateAsync(TEntity entity);
        Task<TEntity> CreateThenSaveAsync(TEntity entity);
        Task<IEnumerable<TEntity>> GetAllWhereAsync(Expression<Func<TEntity, bool>> expression);
        Task<TEntity> GetAsync(Guid key);
        Task<List<TEntity>> GetAllAsync();
        Task<TEntity> DeleteAsync(Guid id);
        Task<TEntity> UpdateAsync(TEntity entity);
    }
}
