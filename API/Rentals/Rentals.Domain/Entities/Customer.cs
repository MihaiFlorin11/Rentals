using Rentals.Application.Abstraction;
using Rentals.Domain.Enums;

namespace Rentals.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Email { get; set; } = string.Empty;

        public string Phone { get; set; } = string.Empty;

        public string FullName { get; set; } = string.Empty;

        public CustomerStatus Status { get; set; }

        public bool IsActive { get; set; }

        public ICollection<Rental> Rentals { get; set; } = new List<Rental>();

        public ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();
    }
}
