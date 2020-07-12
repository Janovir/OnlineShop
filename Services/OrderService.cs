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
    public class OrderService : CrudService<Order>, IOrderService
    {
        private IOrderRepository _orderRepository;
        private IItemService _itemService;

        public OrderService(IOrderRepository orderRepository, IItemService itemService) : base(orderRepository)
        {
            _orderRepository = orderRepository;
            _itemService = itemService;
        }

        //private readonly IOrderService _orderService;
        public async Task<Order> GetWithItemsAsync(Guid id)
        {
            var order = await base.GetAsync(id);
            order.Items = (await _itemService.GetAllAsync()).Where(i => i.OrderId == id);

            return order;
        }
    }
}
