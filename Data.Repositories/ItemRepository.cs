using Data.Access;
using Data.Repositories.Abstraction;
using Data.Repositories.Base;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories
{
    public class ItemRepository : DbCrudRepository<Item>, IItemRepository
    {
        public ItemRepository(ShopContext dbContext) : base(dbContext)
        {
        }

    }
}
