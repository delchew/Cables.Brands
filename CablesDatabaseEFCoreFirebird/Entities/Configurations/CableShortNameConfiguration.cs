using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CablesDatabaseEFCoreFirebird.Entities.Configurations
{
    public class CableShortNameConfiguration : IEntityTypeConfiguration<CableShortName>
    {
        public void Configure(EntityTypeBuilder<CableShortName> builder)
        {
            builder.ToTable("CABLE_SHORT_NAME");

            builder.Property(c => c.Id).HasColumnName("ID").HasColumnType("INTEGER").IsRequired();
            builder.HasKey(c => c.Id);

            builder.Property(c => c.ShortName).HasColumnName("SHORT_NAME").HasColumnType("VARCHAR(50)").IsRequired();
        }
    }
}
