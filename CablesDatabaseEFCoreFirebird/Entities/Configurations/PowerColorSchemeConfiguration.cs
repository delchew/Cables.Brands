using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CablesDatabaseEFCoreFirebird.Entities.Configurations
{
    public class PowerColorSchemeConfiguration : IEntityTypeConfiguration<PowerColorScheme>
    {
        public void Configure(EntityTypeBuilder<PowerColorScheme> builder)
        {
            builder.ToTable("POWER_WIRES_COLOR_SCHEME");

            builder.Property(p => p.Id).HasColumnName("ID").HasColumnType("INTEGER").IsRequired();
            builder.HasKey(p => p.Id);

            builder.Property(p => p.ColorScheme).HasColumnName("COLOR_SCHEME").HasColumnType("VARCHAR(10)").IsRequired();
            builder.Property(p => p.ColorSchemeRus).HasColumnName("COLOR_SCHEME_RUS").HasColumnType("VARCHAR(10)").IsRequired();
        }
    }
}
