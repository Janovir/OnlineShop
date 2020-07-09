using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Entities
{
    public class Order : BaseEntity
    {
        public IEnumerable<Item> Items { get; set; }
    }
}
