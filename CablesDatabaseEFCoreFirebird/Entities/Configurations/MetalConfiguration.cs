using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CablesDatabaseEFCoreFirebird.Entities.Configurations
{
    public class MetalConfiguration : IEntityTypeConfiguration<Metal>
    {
        public void Configure(EntityTypeBuilder<Metal> builder)
        {
            builder.ToTable("METAL");

            builder.Property(m => m.Id).HasColumnName("ID").HasColumnType("INTEGER").IsRequired().HasDefaultValue(0);
            builder.HasKey(u => u.Id);

            builder.Property(m => m.MetalName).HasColumnName("METAL_NAME").HasColumnType("VARCHAR(30)").HasDefaultValue();
            builder.Property(m => m.Density20).HasColumnName("DENSITY_20").HasColumnType("INTEGER").IsRequired().HasDefaultValue(0);
        }
    }
}
