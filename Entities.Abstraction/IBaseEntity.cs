using System;

namespace Entities.Abstraction
{
    public interface IBaseEntity
    {
        Guid Id { get; set; }
        string Name { get; set; }
    }
}
