namespace Rentals.Application.Abstraction
{
    public abstract class BaseEntity
    {
        public Guid Guid { get; set; } = Guid.NewGuid();

        public bool IsDeleted { get; set; }

        public DateTimeOffset CreatedAt { get; set; }

        public DateTimeOffset ModifiedAt { get; set; }
    }
}
