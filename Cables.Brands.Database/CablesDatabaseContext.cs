using Cables.Brands.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Cables.Brands.Database
{
    public class CablesDatabaseContext : DbContext
    {
        public DbSet<FireProtectionClass> FireProtectionClasses { get; set; }

        public CablesDatabaseContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("AppSettings.json");
            var config = builder.Build();
            var connectionString = config.GetConnectionString("MacBookConnection");

            optionsBuilder.UseFirebird(connectionString);
        }
    }
}
