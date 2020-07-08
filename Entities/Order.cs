using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Entities
{
    public class Order : BaseEntity
    {
        public IEnumerable<Order> Orders { get; set; }
    }
}
