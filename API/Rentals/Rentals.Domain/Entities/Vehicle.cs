using Rentals.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rentals.Domain.Entities
{
    public class Vehicle
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string PlateNumber { get; set; } = string.Empty;

        public VehicleStatus Status { get; set; }

        public int BatteryPercent { get; set; }

        public decimal LastKnownLatitude { get; set; } = decimal.Zero;

        public decimal LastKnownLongitude { get; set; } = decimal.Zero;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedAt { get; set; }

        public VehicleType VehicleType { get; set; } = new VehicleType();

        public Guid VehicleTypeId {  get; set; }

        public ICollection<Rental> Rentals { get; set; } = new List<Rental>();
    }
}
