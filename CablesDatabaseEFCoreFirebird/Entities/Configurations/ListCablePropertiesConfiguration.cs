using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CablesDatabaseEFCoreFirebird.Entities.Configurations
{
    public class ListCablePropertiesConfiguration : IEntityTypeConfiguration<ListCableProperties>
    {
        public void Configure(EntityTypeBuilder<ListCableProperties> builder)
        {
            builder.ToTable("LIST_CABLE_PROPERTIES");

            builder.Property(l => l.Id).HasColumnName("ID").HasColumnType("INTEGER").IsRequired();
            builder.HasKey(l => l.Id);

            builder.Property(l => l.CableId).HasColumnName("CABLE_ID").HasColumnType("INTEGER").IsRequired();
            builder.HasOne(l => l.Cable).WithMany(c => c.ListCableProperties).HasForeignKey(l => l.CableId);

            builder.Property(l => l.PropertyId).HasColumnName("PROPERTY_ID").HasColumnType("INTEGER").IsRequired();
            builder.HasOne(l => l.Property).WithMany(p => p.ListCableProperties).HasForeignKey(l => l.PropertyId);
        }
    }
}
