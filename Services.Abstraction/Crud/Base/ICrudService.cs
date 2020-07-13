using Entities.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstraction.Crud.Base
{
    public interface ICrudService<TEntity>
    {
        /// <summary>
        /// Get all entites from data store
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<TEntity>> GetAllAsync();

        /// <summary>
        /// Get entity by key from data store
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        Task<TEntity> GetAsync(Guid id);

        /// <summary>
        /// Get all entities where condition applies
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        Task<IEnumerable<TEntity>> GetAllWhereAsync(Expression<Func<TEntity, bool>> expression);

        /// <summary>
        /// Create entity in data store
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<TEntity> CreateAsync(TEntity entity);

        /// <summary>
        /// Update entity in daat store
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<TEntity> UpdateAsync(TEntity entity);

        /// <summary>
        /// Remove entity from data store
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        
        Task<TEntity> RemoveAsync(TEntity entity);
        /// <summary>
        /// Remove entity from data store
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<TEntity> RemoveAsync(Guid id);
    }
}
