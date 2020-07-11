using Data.Repositories.Abstraction.Base;
using Entities;
using Entities.Abstraction;
using Services.Abstraction.Crud.Base;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.Crud.Base
{
    public class CrudService<TEntity> : ICrudService<TEntity> where TEntity : BaseEntity
    {
        protected readonly ICrudRepository<TEntity> _repository;

        public CrudService(ICrudRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public Task CreateAsync(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync() => await _repository.GetAllAsync();

        public async Task<TEntity> GetAsync(Guid id) => await _repository.GetAsync(id);

        public Task<TEntity> RemoveAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> RemoveAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        Task<TEntity> ICrudService<TEntity>.CreateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
