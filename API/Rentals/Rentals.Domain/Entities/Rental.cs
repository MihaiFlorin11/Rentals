using Rentals.Application.Abstraction;
using Rentals.Domain.Enums;

namespace Rentals.Domain.Entities
{
    public class Rental : BaseEntity
    {
        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public decimal StartLatitude { get; set; }

        public decimal StartLongitude { get; set; }

        public decimal EndLatitude { get; set; }

        public decimal EndLongitude { get; set; }

        public RentalStatus Status { get; set; }

        public decimal TotalPrice { get; set; }

        public Customer Customer { get; set; } = new Customer();

        public Guid CustomerId { get; set; }

        public Vehicle Vehicle { get; set; } = new Vehicle();

        public Guid VehicleId { get; set; }
    }
}
