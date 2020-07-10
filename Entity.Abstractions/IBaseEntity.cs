using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Abstractions
{
    public interface IBaseEntity
    {
        Guid Id { get; set; }
        string Name { get; set; }
    }
}
