using Microsoft.EntityFrameworkCore;
using CablesDatabaseEFCoreFirebird.Entities;
using CablesDatabaseEFCoreFirebird.Entities.Configurations;

namespace CablesDatabaseEFCoreFirebird
{
    public class CablesContext : DbContext
    {
        private string _connectionString;

        public DbSet<Cable> Cables { get; set; }
        public DbSet<CableProperty> CableProperties { get; set; }
        public DbSet<CableBrandName> CableBrandNames { get; set; }
        public DbSet<ClimaticMod> ClimaticMods { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Conductor> Conductors { get; set; }
        public DbSet<FireProtectionClass> FireProtectionClasses { get; set; }
        public DbSet<FlatCableSize> FlatCableSizes { get; set; }
        public DbSet<InsulatedBillet> InsulatedBillets { get; set; }
        public DbSet<ListCableBillets> ListCableBillets { get; set; }
        public DbSet<ListCablePowerColor> ListCablePowerColors { get; set; }
        public DbSet<ListCableProperties> ListCableProperties { get; set; }
        public DbSet<Metal> Metals { get; set; }
        public DbSet<OperatingVoltage> OperatingVoltages { get; set; }
        public DbSet<PolymerGroup> PolymerGroups { get; set; }
        public DbSet<PowerColorScheme> PowerColorSchemes { get; set; }
        public DbSet<TechnicalConditions> TechnicalConditions { get; set; }
        public DbSet<TwistedElementType> TwistedElementTypes { get; set; }
        public DbSet<TwistInfo>TwistInfos { get; set; }

        public CablesContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseFirebird(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CableConfiguration());
            modelBuilder.ApplyConfiguration(new CablePropertyConfiguration());
            modelBuilder.ApplyConfiguration(new CableBrandNameConfiguration());
            modelBuilder.ApplyConfiguration(new ClimaticModConfiguration());
            modelBuilder.ApplyConfiguration(new ColorConfiguration());
            modelBuilder.ApplyConfiguration(new ConductorConfiguration());
            modelBuilder.ApplyConfiguration(new FireProtectionClassConfiguration());
            modelBuilder.ApplyConfiguration(new FlatCableSizeConfiguration());
            modelBuilder.ApplyConfiguration(new InsulatedBilletConfiguration());
            modelBuilder.ApplyConfiguration(new ListCablePowerColorConfiguration());
            modelBuilder.ApplyConfiguration(new ListCablePropertiesConfiguration());
            modelBuilder.ApplyConfiguration(new ListCableBilletsConfiguration());
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
