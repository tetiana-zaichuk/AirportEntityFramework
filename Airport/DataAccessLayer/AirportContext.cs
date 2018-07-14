using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer
{
    public class AirportContext : DbContext
    {
        public DbSet<Aircraft> Aircrafts { get; set; }
        public DbSet<AircraftType> AircraftsTypes { get; set; }
        public DbSet<Crew> Crews { get; set; }
        public DbSet<Departure> Departures { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Pilot> Pilots { get; set; }
        public DbSet<Stewardess> Stewardesses { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        public AirportContext(DbContextOptions<AirportContext> options) : base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated(); 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Airportdb;Trusted_Connection=True;");
            //optionsBuilder.UseSqlServer("", b => b.MigrationsAssembly("PresentationLayer"));
        }
    }
}


