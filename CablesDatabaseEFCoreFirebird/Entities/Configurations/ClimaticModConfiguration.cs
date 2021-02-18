using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CablesDatabaseEFCoreFirebird.Entities.Configurations
{
    public class ClimaticModConfiguration : IEntityTypeConfiguration<ClimaticMod>
    {
        public void Configure(EntityTypeBuilder<ClimaticMod> builder)
        {
            builder.ToTable("CLIMATIC_MOD");

            builder.Property(c => c.Id).HasColumnName("ID").HasColumnType("INTEGER").IsRequired();
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Title).HasColumnName("TITLE").HasColumnType("VARCHAR(10)").IsRequired();
            builder.Property(c => c.Description).HasColumnName("DESCRIPTION").HasColumnType("VARCHAR(100)").IsRequired();
        }
    }
}
