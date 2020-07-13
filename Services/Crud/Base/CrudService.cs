using Data.Repositories.Abstraction.Base;
using Entities;
using Entities.Abstraction;
using Services.Abstraction.Crud.Base;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Services.Crud.Base
{
    public class CrudService<TEntity> : ICrudService<TEntity> where TEntity : BaseEntity
    {
        protected readonly IDbCrudRepository<TEntity> _repository;

        public CrudService(IDbCrudRepository<TEntity> repository) => _repository = repository;

        public async Task<TEntity> CreateAsync(TEntity entity) => await _repository.CreateThenSaveAsync(entity);

        public async Task<IEnumerable<TEntity>> GetAllAsync() => await _repository.GetAllAsync();

        public async Task<IEnumerable<TEntity>> GetAllWhereAsync(Expression<Func<TEntity, bool>> expression) => await _repository.GetAllWhereAsync(expression);

        public async Task<TEntity> GetAsync(Guid id) => await _repository.GetAsync(id);

        public Task<TEntity> RemoveAsync(TEntity entity) => RemoveAsync(entity.Id);

        public async Task<TEntity> RemoveAsync(Guid id) => await _repository.DeleteAsync(id);

        public async Task<TEntity> UpdateAsync(TEntity entity) => await _repository.UpdateAsync(entity);
    }
}
