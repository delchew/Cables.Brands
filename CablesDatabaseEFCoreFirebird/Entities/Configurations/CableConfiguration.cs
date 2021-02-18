using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CablesDatabaseEFCoreFirebird.Entities.Configurations
{
    public class CableConfiguration : IEntityTypeConfiguration<Cable>
    {
        public void Configure(EntityTypeBuilder<Cable> builder)
        {
            builder.ToTable("CABLE");

            builder.Property(c => c.Id).HasColumnName("ID").HasColumnType("INTEGER").IsRequired();
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Title).HasColumnName("TITLE").HasColumnType("VARCHAR(50)").IsRequired();
            builder.Property(c => c.BilletId).HasColumnName("BILLET_ID").HasColumnType("INTEGER").IsRequired();
            builder.Property(c => c.ElementsCount).HasColumnName("ELEMENTS_COUNT").HasColumnType("INTEGER").IsRequired();
            builder.Property(c => c.TwistedElementTypeId).HasColumnName("TWISTED_ELEMENT_TYPE_ID").HasColumnType("INTEGER").IsRequired();
            builder.Property(c => c.TechnicalConditionsId).HasColumnName("TECHNICAL_CONDITIONS_ID").HasColumnType("INTEGER").IsRequired();
            builder.Property(c => c.FireProtectionClassId).HasColumnName("FIRE_PROTECT_ID").HasColumnType("INTEGER").IsRequired();
            builder.Property(c => c.CoverPolymerGroupId).HasColumnName("COVER_POLYMER_GROUP_ID").HasColumnType("INTEGER").IsRequired();
            builder.Property(c => c.CoverColorId).HasColumnName("COVER_COLOR_ID").HasColumnType("INTEGER").IsRequired();
            builder.Property(c => c.MaxCoverDiameter).HasColumnName("MAX_COVER_DIAMETER").HasColumnType("NUMERIC(3, 2)");
            builder.Property(c => c.ClimaticModId).HasColumnName("CLIMATIC_MOD_ID").HasColumnType("INTEGER").IsRequired();
            builder.Property(c => c.OperatingVoltageId).HasColumnName("OPERATING_VOLTAGE_ID").HasColumnType("INTEGER").IsRequired();
        }
    }
}
