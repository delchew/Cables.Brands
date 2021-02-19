using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CablesDatabaseEFCoreFirebird.Entities.Configurations
{
    public class ListCablePowerColorConfiguration : IEntityTypeConfiguration<ListCablePowerColor>
    {
        public void Configure(EntityTypeBuilder<ListCablePowerColor> builder)
        {
            builder.ToTable("LIST_CABLE_PROWER_COLOR");

            builder.Property(l => l.Id).HasColumnName("ID").HasColumnType("INTEGER").IsRequired();
            builder.HasKey(l => l.Id);

            builder.Property(l => l.CableId).HasColumnName("CABLE_ID").HasColumnType("INTEGER").IsRequired();
            builder.HasOne(l => l.Cable).WithMany(c => c.ListCablePowerColors).HasForeignKey(l => l.CableId);

            builder.Property(l => l.PowerColorSchemeId).HasColumnName("POWER_COLOR_SCHEME_ID").HasColumnType("INTEGER").IsRequired();
            builder.HasOne(l => l.PowerColorScheme).WithMany(p => p.ListCablePowerColors).HasForeignKey(l => l.PowerColorSchemeId);
        }
    }
}
