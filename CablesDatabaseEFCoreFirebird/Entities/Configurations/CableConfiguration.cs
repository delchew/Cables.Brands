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
            builder.HasOne(c => c.InsulatedBillet).WithMany(i => i.Cables).HasForeignKey(c => c.BilletId);

            builder.Property(c => c.ElementsCount).HasColumnName("ELEMENTS_COUNT").HasColumnType("INTEGER").IsRequired();

            builder.Property(c => c.TwistedElementTypeId).HasColumnName("TWISTED_ELEMENT_TYPE_ID").HasColumnType("INTEGER").IsRequired();
            builder.HasOne(c => c.TwistedElementType).WithMany(t => t.Cables).HasForeignKey(c => c.TwistedElementTypeId);

            builder.Property(c => c.TechnicalConditionsId).HasColumnName("TECHNICAL_CONDITIONS_ID").HasColumnType("INTEGER").IsRequired();
            builder.HasOne(c => c.TechnicalConditions).WithMany(t => t.Cables).HasForeignKey(c => c.TechnicalConditionsId);

            builder.Property(c => c.FireProtectionClassId).HasColumnName("FIRE_PROTECT_ID").HasColumnType("INTEGER").IsRequired();
            builder.HasOne(c => c.FireProtectionClass).WithMany(f => f.Cables).HasForeignKey(c => c.FireProtectionClassId);

            builder.Property(c => c.CoverPolymerGroupId).HasColumnName("COVER_POLYMER_GROUP_ID").HasColumnType("INTEGER").IsRequired();
            builder.HasOne(c => c.CoverPolymerGroup).WithMany(c => c.Cables).HasForeignKey(c => c.CoverPolymerGroupId);

            builder.Property(c => c.CoverColorId).HasColumnName("COVER_COLOR_ID").HasColumnType("INTEGER").IsRequired();
            builder.HasOne(c => c.CoverColor).WithMany(c => c.Cables).HasForeignKey(c => c.CoverColorId);

            builder.Property(c => c.MaxCoverDiameter).HasColumnName("MAX_COVER_DIAMETER").HasColumnType("NUMERIC(3, 2)");

            builder.Property(c => c.ClimaticModId).HasColumnName("CLIMATIC_MOD_ID").HasColumnType("INTEGER").IsRequired();
            builder.HasOne(c => c.ClimaticMod).WithMany(c => c.Cables).HasForeignKey(c => c.ClimaticModId);

            builder.Property(c => c.OperatingVoltageId).HasColumnName("OPERATING_VOLTAGE_ID").HasColumnType("INTEGER").IsRequired();
            builder.HasOne(c => c.OperatingVoltage).WithMany(o => o.Cables).HasForeignKey(c => c.OperatingVoltageId);

        }
    }
}
