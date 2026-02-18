using Rentals.Application.Abstraction;
using Rentals.Domain.Enums;

namespace Rentals.Domain.Entities
{
    public class Vehicle : BaseEntity
    {
        public string PlateNumber { get; set; } = string.Empty;

        public VehicleStatus Status { get; set; }

        public int BatteryPercent { get; set; }

        public decimal LastKnownLatitude { get; set; } = decimal.Zero;

        public decimal LastKnownLongitude { get; set; } = decimal.Zero;

        public VehicleType VehicleType { get; set; } = new VehicleType();

        public Guid VehicleTypeId {  get; set; }

        public ICollection<Rental> Rentals { get; set; } = new List<Rental>();
    }
}
