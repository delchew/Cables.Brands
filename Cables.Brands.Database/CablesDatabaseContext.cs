using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Cables.Brands.Database
{
    public class CableContext : DbContext
    {
        public DbSet<Metal> Metals { get; set; }

        public CableContext()
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
