using Entities;
using Services.Abstraction.Crud.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstraction
{
    public interface IOrderService : ICrudService<Order>
    {
        Task<Order> GetWithItemsAsync(Guid id);
    }
}
