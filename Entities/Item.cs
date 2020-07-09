using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Item : BaseEntity
    {
        public Guid OrderId { get; set; }
        public decimal Price { get; set; }
    }
}
