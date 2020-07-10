using Entities.Abstraction;
using Services.Abstraction.Crud.Base;
using System.Threading.Tasks;

namespace Services.Crud.Base
{
    public class CrudService<TEntity> : ICrudService<TEntity> where TEntity : class, IBaseEntity
    {
        public Task CreateAsync(TEntity entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
