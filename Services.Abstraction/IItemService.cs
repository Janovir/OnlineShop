using Entities;
using Services.Abstraction.Crud.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstraction
{
    public interface IItemService : ICrudService<Item>
    {
        Task<Item> GetItemWithOrderReferences(Guid id);
    }
}
