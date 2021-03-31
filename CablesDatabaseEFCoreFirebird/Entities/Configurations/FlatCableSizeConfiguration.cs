using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CablesDatabaseEFCoreFirebird.Entities.Configurations
{
    public class FlatCableSizeConfiguration : IEntityTypeConfiguration<FlatCableSize>
    {
        public void Configure(EntityTypeBuilder<FlatCableSize> builder)
        {
            builder.ToTable("FLAT_CABLE_SIZE");

            builder.Property(s => s.Id).HasColumnName("ID").HasColumnType("INTEGER").IsRequired();
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Height).HasColumnName("HEIGHT").HasColumnType("NUMERIC(3, 2)").IsRequired();

            builder.Property(s => s.Width).HasColumnName("WIDTH").HasColumnType("NUMERIC(3, 2)").IsRequired();

            builder.Property(s => s.CableId).HasColumnName("CABLE_ID").HasColumnType("INTEGER").IsRequired();
            builder.HasOne(s => s.Cable).WithOne(c => c.FlatCableSize).HasForeignKey<FlatCableSize>(s => s.CableId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
