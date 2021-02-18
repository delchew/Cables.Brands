using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CablesDatabaseEFCoreFirebird.Entities.Configurations
{
    public class MetalConfiguration : IEntityTypeConfiguration<Metal>
    {
        public void Configure(EntityTypeBuilder<Metal> builder)
        {
            builder.ToTable("METAL");

            builder.Property(m => m.Id).HasColumnName("ID").HasColumnType("INTEGER").IsRequired();
            builder.HasKey(m => m.Id);

            builder.Property(m => m.MetalName).HasColumnName("METAL_NAME").HasColumnType("VARCHAR(30)");
            builder.Property(m => m.Density20).HasColumnName("DENSITY_20").HasColumnType("INTEGER").IsRequired();
        }
    }
}
