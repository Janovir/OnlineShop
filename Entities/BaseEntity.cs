using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public abstract class BaseEntity
    {
        public virtual Guid Id { get; set; }
        public virtual string Name { get; set; }
        //public virtual DateTime CreatedDate { get; set; }
        public virtual DateTime UpdatedDate { get; set; }
    }
}
