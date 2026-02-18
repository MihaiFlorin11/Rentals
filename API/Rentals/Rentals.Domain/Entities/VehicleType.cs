using Rentals.Application.Abstraction;

namespace Rentals.Domain.Entities
{
    public class VehicleType : BaseEntity
    {
        public string Name { get; set; } = string.Empty;

        public decimal BaseRatePerMinute { get; set; }

        public decimal? UnlockFee { get; set; }

        public string Currency { get; set; } = string.Empty;

        public ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
    }
}
