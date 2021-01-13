using Cables.Brands.Common;
using FirebirdSql.Data.FirebirdClient;
using Microsoft.EntityFrameworkCore;

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
            var builder = new FbConnectionStringBuilder
            {
                Charset = "none",
                UserID = "SYSDBA",
                Password = "masterkey",
                Dialect = 3,
                Database = @"Cables.Brands.FDB",
                DataSource = "localhost",
                Port = 3050,
            };
            var connection = new FbConnection(builder.ToString());
            optionsBuilder.UseFirebird(connection);
        }
    }
}
