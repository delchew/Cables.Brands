using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CablesDatabaseEFCoreFirebird.Entities.Configurations
{
    public class ConductorConfiguration : IEntityTypeConfiguration<Conductor>
    {
        public void Configure(EntityTypeBuilder<Conductor> builder)
        {
            builder.ToTable("CONDUCTOR");

            builder.Property(c => c.Id).HasColumnName("ID").HasColumnType("INTEGER").IsRequired();
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Title).HasColumnName("TITLE").HasColumnType("VARCHAR(20)").HasMaxLength(20).IsRequired();

            builder.Property(c => c.WiresCount).HasColumnName("WIRES_COUNT").HasColumnType("INTEGER").IsRequired();

            builder.Property(c => c.Class).HasColumnName("CLASS").HasColumnType("INTEGER").IsRequired();

            builder.Property(c => c.WiresDiameter).HasColumnName("WIRES_DIAMETER").HasColumnType("NUMERIC(3, 3)").IsRequired();

            builder.Property(c => c.ConductorDiameter).HasColumnName("CONDUCTOR_DIAMETER").HasColumnType("NUMERIC(3, 3)").IsRequired();

            builder.Property(c => c.AreaInSqrMm).HasColumnName("AREA_IN_SQR_MM").HasColumnType("NUMERIC(3, 3)").IsRequired();

            builder.Property(c => c.MetalId).HasColumnName("METAL_ID").HasColumnType("INTEGER").IsRequired();
            builder.HasOne(c => c.Metal).WithMany(m => m.Conductors).HasForeignKey(c => c.MetalId);
        }
    }
}
