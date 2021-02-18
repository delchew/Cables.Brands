using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CablesDatabaseEFCoreFirebird.Entities.Configurations
{
    public class TwistInfoConfiguration : IEntityTypeConfiguration<TwistInfo>
    {
        public void Configure(EntityTypeBuilder<TwistInfo> builder)
        {
            builder.ToTable("TWIST_INFO");

            builder.Property(t => t.Id).HasColumnName("ID").HasColumnType("INTEGER").IsRequired();
            builder.HasKey(t => t.Id);

            builder.Property(t => t.ElementsCount).HasColumnName("ELEMENTS_COUNT").HasColumnType("INTEGER").IsRequired();
            builder.Property(t => t.ElementsCount).HasColumnName("TWIST_COEFFICIENT").HasColumnType("NUMERIC(3, 2)").IsRequired();
            builder.Property(t => t.ElementsCount).HasColumnName("LAYER1_ELEMENTS_COUNT").HasColumnType("INTEGER").IsRequired();
            builder.Property(t => t.ElementsCount).HasColumnName("LAYER2_ELEMENTS_COUNT").HasColumnType("INTEGER").IsRequired().HasDefaultValue(0);
            builder.Property(t => t.ElementsCount).HasColumnName("LAYER3_ELEMENTS_COUNT").HasColumnType("INTEGER").IsRequired().HasDefaultValue(0);
            builder.Property(t => t.ElementsCount).HasColumnName("LAYER4_ELEMENTS_COUNT").HasColumnType("INTEGER").IsRequired().HasDefaultValue(0);
            builder.Property(t => t.ElementsCount).HasColumnName("LAYER5_ELEMENTS_COUNT").HasColumnType("INTEGER").IsRequired().HasDefaultValue(0);

        }
    }
}
