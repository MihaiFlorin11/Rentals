using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Rentals.Domain.Entities;
using Rentals.Infrastructure.DatabaseSettings;

namespace Rentals.Infrastructure.Context
{
    public class DatabaseContext : DbContext
    {
        private readonly DbSettings _dbSettings;

        public DbSet<Vehicle> Vehicles { get; set; }

        public DbSet<VehicleType> VehicleTypes { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Invoice> Invoices { get; set; }

        public DbSet<Rental> Rentals { get; set; }

        public DatabaseContext(IOptions<DbSettings> optionSettings)
        {
            this._dbSettings = optionSettings.Value;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(this._dbSettings.ConnectionString);
        }
    }
}
