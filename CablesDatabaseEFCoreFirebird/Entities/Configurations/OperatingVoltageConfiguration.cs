using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CablesDatabaseEFCoreFirebird.Entities.Configurations
{
    public class OperatingVoltageConfiguration : IEntityTypeConfiguration<OperatingVoltage>
    {
        public void Configure(EntityTypeBuilder<OperatingVoltage> builder)
        {
            builder.ToTable("OPERATING_VOLTAGE");

            builder.Property(o => o.Id).HasColumnName("ID").HasColumnType("INTEGER").IsRequired();
            builder.HasKey(o => o.Id);

            builder.Property(o => o.ACVoltage).HasColumnName("AC_VOLTAGE").HasColumnType("INTEGER").IsRequired();
            builder.Property(o => o.ACFriquency).HasColumnName("AC_FRIQUENCY").HasColumnType("INTEGER").IsRequired();
            builder.Property(o => o.DCVoltage).HasColumnName("DC_VOLTAGE").HasColumnType("INTEGER");
            builder.Property(o => o.Description).HasColumnName("DESCRIPTION").HasColumnType("VARCHAR(100)");
        }
    }
}
