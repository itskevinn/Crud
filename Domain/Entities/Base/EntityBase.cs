using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Base
{
    public class EntityBase<T> : DomainEntity, IEntityBase<T>
    {
        public T Id { get; set; } = default!;
    }
}
