using Data.Access;
using Data.Repositories.Abstraction;
using Data.Repositories.Base;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories
{
    public class OrderRepository : CrudRepository<Order>, IOrderRepository
    {
        public OrderRepository(ShopContext dbContext) : base(dbContext)
        {
        }

    }
}
