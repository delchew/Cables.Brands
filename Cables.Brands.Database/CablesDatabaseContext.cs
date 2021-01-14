using Cables.Brands.Common;
using FirebirdSql.Data.FirebirdClient;
using FirebirdSql.EntityFrameworkCore;
using FirebirdSql.EntityFrameworkCore.Firebird;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Cables.Brands.Database
{
    public class CablesDatabaseContext : DbContext
    {
        public DbSet<FireProtectionClass> FireProtectionClasses { get; set; }
        //public CablesDatabaseContext()
        //{
        //    Database.EnsureCreated();
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            var builder = new FbConnectionStringBuilder
            {
                Charset = "none",
                UserID = "SYSDBA",
                Password = "masterkey",
                Dialect = 3,
                DataSource = "localhost",
                Port = 3050,
                Database = @"E:\Distr\firebird\CablesBrands.FDB"

            };

            optionsBuilder.UseFirebird(builder.ToString());
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var builder = modelBuilder.Entity<FireProtectionClass>();
            builder.Property(x => x.Id).HasColumnName("ID");
            builder.Property(x => x.ProtectionClass).HasColumnName("PROTECTION_CLASS");
            builder.Property(x => x.Designation).HasColumnName("DESIGNATION");
            builder.ToTable("FIRE_PROTECTION_CLASSES");
        }
    }
}
