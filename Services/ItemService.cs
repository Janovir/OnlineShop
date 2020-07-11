using Data.Repositories.Abstraction;
using Entities;
using Services.Abstraction;
using Services.Abstraction.Crud.Base;
using Services.Crud.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ItemService : CrudService<Item>, IItemService
    {
        private IItemRepository _itemRepository;
        public ItemService(IItemRepository itemRepository) : base(itemRepository)
        {
            _itemRepository = itemRepository;
        }

        //private readonly IOrderService _orderService;
        public async Task<Item> GetItemWithOrderReferences(Guid id)
        {
            var item = await base.GetAsync(id);
            return item;//TODO: Missing order references
        }
    }
}
