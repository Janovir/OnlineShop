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
    public class DbCrudRepository<TEntity> : IDbCrudRepository<TEntity> where TEntity : BaseEntity
    {
        protected DbContext _dbContext;

        public DbCrudRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual async Task<TEntity> CreateAsync(TEntity entity)
        {
            entity.CreatedDate = DateTime.Now;
            entity.UpdatedDate = entity.CreatedDate;
            await _dbContext.Set<TEntity>().AddAsync(entity);
            return entity;
        }

        public virtual async Task<TEntity> CreateThenSaveAsync(TEntity entity)
        {
            var result = await CreateAsync(entity);
            await _dbContext.SaveChangesAsync();
            return result;
        }

        public async Task<TEntity> DeleteAsync(Guid id)
        {
            var entity = await _dbContext.FindAsync<TEntity>(id);
            if (entity != null)
            {
                _dbContext.Remove(entity);
                await _dbContext.SaveChangesAsync();
            }

            return entity;
        }

        public virtual async Task<List<TEntity>> GetAllAsync() => await _dbContext.Set<TEntity>().ToListAsync();

        public virtual async Task<TEntity> GetAsync(Guid id) => await _dbContext.FindAsync<TEntity>(id).AsTask();

        public virtual async Task<TEntity> UpdateAsync(TEntity changedEntity)
        {
            var entity = _dbContext.Set<TEntity>().Attach(changedEntity);
            entity.Entity.UpdatedDate = DateTime.Now;
            entity.State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return changedEntity;
        }
    }
}
