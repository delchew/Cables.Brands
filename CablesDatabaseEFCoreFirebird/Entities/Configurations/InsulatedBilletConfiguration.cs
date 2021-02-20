using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CablesDatabaseEFCoreFirebird.Entities.Configurations
{
    public class InsulatedBilletConfiguration : IEntityTypeConfiguration<InsulatedBillet>
    {
        public void Configure(EntityTypeBuilder<InsulatedBillet> builder)
        {
            builder.ToTable("INSULATED_BILLET");

            builder.Property(b => b.Id).HasColumnName("ID").HasColumnType("INTEGER").IsRequired();
            builder.HasKey(b => b.Id);

            builder.Property(b => b.ConductorId).HasColumnName("COND_ID").HasColumnType("INTEGER").IsRequired();
            builder.HasOne(b => b.Conductor).WithMany(c => c.InsulatedBillets).HasForeignKey(b => b.ConductorId);

            builder.Property(b => b.PolymerGroupId).HasColumnName("POLYMER_GROUP_ID").HasColumnType("INTEGER").IsRequired();
            builder.HasOne(b => b.PolymerGroup).WithMany(p => p.InsulatedBillets).HasForeignKey(b => b.PolymerGroupId);

            builder.Property(b => b.OperatingVoltageId).HasColumnName("OPERATING_VOLTAGE_ID").HasColumnType("INTEGER").IsRequired();
            builder.HasOne(b => b.OperatingVoltage).WithMany(o => o.InsulatedBillets).HasForeignKey(b => b.OperatingVoltageId);

            builder.Property(b => b.Diameter).HasColumnName("DIAMETER").HasColumnType("NUMERIC(3, 2)").IsRequired();

            builder.Property(b => b.MinThickness).HasColumnName("MIN_THICKNESS").HasColumnType("NUMERIC(2, 2)");

            builder.Property(b => b.NominalThickness).HasColumnName("NOMINAL_THICKNESS").HasColumnType("NUMERIC(2, 2)");

            builder.Property(b => b.CableShortNameId).HasColumnName("CABLE_SHORT_NAME_ID").HasColumnType("INTEGER").IsRequired();
            builder.Property(b => b.CableShortNameId).HasColumnName("CABLE_SHORT_NAME_ID").HasColumnType("INTEGER").IsRequired();
            builder.HasOne(b => b.CableShortName).WithMany(c => c.InsulatedBillets).HasForeignKey(b => b.CableShortNameId);
        }
    }
}
