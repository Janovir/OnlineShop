using Data.Repositories.Abstraction.Base;
using Entities;

namespace Data.Repositories.Abstraction
{
    public interface IOrderRepository: IDbCrudRepository<Order>
    {
    }
}
