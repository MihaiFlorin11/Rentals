using Microsoft.EntityFrameworkCore;
using Rentals.Domain.Entities;

namespace Rentals.Infrastructure
{
    public class RentalsDbContext : DbContext
    {
        public RentalsDbContext(DbContextOptions<RentalsDbContext> options) : base(options) { }

        public DbSet<Vehicle> Vehicles { get; set; }

        public DbSet<VehicleType> VehicleTypes { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Invoice> Invoices { get; set; }

        public DbSet<Rental> Rentals { get; set; }
    }
}
