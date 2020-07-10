using Data.Repositories.Abstraction.Base;
using Entities;

namespace Data.Repositories.Abstraction
{
    public interface IItemRepository: ICrudRepository<Item>
    {
    }
}
