using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CablesDatabaseEFCoreFirebird.Entities.Configurations
{
    public class CableBrandNameConfiguration : IEntityTypeConfiguration<CableBrandName>
    {
        public void Configure(EntityTypeBuilder<CableBrandName> builder)
        {
            builder.ToTable("CABLE_BRAND_NAME");

            builder.Property(c => c.Id).HasColumnName("ID").HasColumnType("INTEGER").IsRequired();
            builder.HasKey(c => c.Id);

            builder.Property(c => c.BrandName).HasColumnName("BRAND_NAME").HasColumnType("VARCHAR(50)").IsRequired();
        }
    }
}
