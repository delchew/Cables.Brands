using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
using CablesDatabaseEFCoreFirebird.Entities;
using CablesDatabaseEFCoreFirebird.Entities.Configurations;

namespace CablesDatabaseEFCoreFirebird
{
    public class CablesContext : DbContext
    {
        public DbSet<Cable> Cables { get; set; }
        public DbSet<CableProperty> CableProperties { get; set; }
        public DbSet<CableShortName> CableShortNames { get; set; }
        public DbSet<ClimaticMod> ClimaticMods { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Conductor> Conductors { get; set; }
        public DbSet<FireProtectionClass> FireProtectionClasses { get; set; }
        public DbSet<InsulatedBillet> InsulatedBillets { get; set; }
        public DbSet<ListCablePowerColor> ListCablePowerColors { get; set; }
        public DbSet<ListCableProperties> ListCableProperties { get; set; }
        public DbSet<Metal> Metals { get; set; }
        public DbSet<OperatingVoltage> OperatingVoltages { get; set; }
        public DbSet<PolymerGroup> PolymerGroups { get; set; }
        public DbSet<PowerColorScheme> PowerColorSchemes { get; set; }
        public DbSet<TechnicalConditions> TechnicalConditions { get; set; }
        public DbSet<TwistedElementType> TwistedElementTypes { get; set; }
        public DbSet<TwistInfo>TwistInfos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("AppSettings.json");
            var config = builder.Build();
            var connectionString = config.GetConnectionString("MacBookConnection");

            optionsBuilder.UseFirebird(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CableConfiguration());
            modelBuilder.ApplyConfiguration(new CablePropertyConfiguration());
            modelBuilder.ApplyConfiguration(new CableShortNameConfiguration());
            modelBuilder.ApplyConfiguration(new ClimaticModConfiguration());
            modelBuilder.ApplyConfiguration(new ColorConfiguration());
            modelBuilder.ApplyConfiguration(new CableShortNameConfiguration());
            modelBuilder.ApplyConfiguration(new ConductorConfiguration());
            modelBuilder.ApplyConfiguration(new FireProtectionClassConfiguration());
            modelBuilder.ApplyConfiguration(new ListCablePowerColorConfiguration());
            modelBuilder.ApplyConfiguration(new ListCablePropertiesConfiguration());
            modelBuilder.ApplyConfiguration(new MetalConfiguration());
            modelBuilder.ApplyConfiguration(new OperatingVoltageConfiguration());
            modelBuilder.ApplyConfiguration(new PolymerGroupConfiguration());
            modelBuilder.ApplyConfiguration(new PowerColorSchemeConfiguration());
            modelBuilder.ApplyConfiguration(new TechnicalConditionsConfiguration());
            modelBuilder.ApplyConfiguration(new TwistedElementTypeConfiguration());
            modelBuilder.ApplyConfiguration(new TwistInfoConfiguration());
        }
    }
}
