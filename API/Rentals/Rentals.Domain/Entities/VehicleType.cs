namespace Rentals.Domain.Entities
{
    public class VehicleType
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Name { get; set; } = string.Empty;

        public decimal BaseRatePerMinute { get; set; }

        public decimal? UnlockFee { get; set; }

        public string Currency { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; }

        public ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
    }
}
