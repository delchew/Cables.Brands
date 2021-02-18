using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CablesDatabaseEFCoreFirebird.Entities.Configurations
{
    public class CablePropertyConfiguration : IEntityTypeConfiguration<CableProperty>
    {
        public void Configure(EntityTypeBuilder<CableProperty> builder)
        {
            builder.ToTable("CABLE_PROPERTIES");

            builder.Property(c => c.Id).HasColumnName("ID").HasColumnType("INTEGER").IsRequired();
            builder.HasKey(c => c.Id);

            builder.Property(c => c.PropertyInfo).HasColumnName("PROPERTY_INFO").HasColumnType("VARCHAR(50)").IsRequired();
        }
    }
}
