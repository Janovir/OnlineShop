using Entities.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstraction.Crud.Base
{
    public interface ICrudService<T>
    {
        /// <summary>
        /// Get all entites from data store
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<T>> GetAllAsync();

        /// <summary>
        /// Get entity by key from data store
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        Task<T> GetAsync(Guid id);

        /// <summary>
        /// Create entity in data store
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<T> CreateAsync(T entity);

        /// <summary>
        /// Update entity in daat store
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<T> UpdateAsync(T entity);

        /// <summary>
        /// Remove entity from data store
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        
        Task<T> RemoveAsync(T entity);
        /// <summary>
        /// Remove entity from data store
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<T> RemoveAsync(Guid id);
    }
}
