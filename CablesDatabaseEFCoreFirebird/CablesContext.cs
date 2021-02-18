using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
using CablesDatabaseEFCoreFirebird.Entities;
using CablesDatabaseEFCoreFirebird.Entities.Configurations;

namespace CablesDatabaseEFCoreFirebird
{
    public class CablesContext : DbContext
    {
        public DbSet<Conductor> Conductors { get; set; }
        public DbSet<Metal> Metals { get; set; }

        public CablesContext()
        {
            //Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("AppSettings.json");
            var config = builder.Build();
            var connectionString = config.GetConnectionString("DefaultConnection");

            optionsBuilder.UseFirebird(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MetalConfiguration());
            modelBuilder.ApplyConfiguration(new ConductorConfiguration());
        }
    }
}
