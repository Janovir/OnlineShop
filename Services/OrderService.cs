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
        public OrderService(IOrderRepository orderRepository) : base(orderRepository)
        {
            _orderRepository = orderRepository;
        }

        //private readonly IOrderService _orderService;
        public async Task<Order> GetOrderWithItems(Guid id)
        {
            var order = await base.GetAsync(id);
            return order;//TODO: Missing order references
        }
    }
}
