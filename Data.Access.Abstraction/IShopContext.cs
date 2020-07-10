using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Data.Access.Abstraction
{
    public interface IShopContext
    {
        /// <summary>
        /// Retrieve entity from context by its ID
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        Task<TEntity> FindAsync<TEntity>(Guid id);

        /// <summary>
        /// Retrieve entity from context by its ID
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        Task<Collection<TEntity>> GetAllAsync<TEntity>();
    }
}
