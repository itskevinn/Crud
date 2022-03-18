using Domain.Entities.Base;

namespace Domain.Entities
{
    public class Person : EntityBase<Guid>
    {
        public string Name { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public int Age { get; set; }
    }
}
