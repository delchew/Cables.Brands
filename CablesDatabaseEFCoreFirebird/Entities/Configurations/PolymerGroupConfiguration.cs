using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CablesDatabaseEFCoreFirebird.Entities.Configurations
{
    public class PolymerGroupConfiguration : IEntityTypeConfiguration<PolymerGroup>
    {
        public void Configure(EntityTypeBuilder<PolymerGroup> builder)
        {
            builder.ToTable("POLYMER_GROUP");

            builder.Property(p => p.Id).HasColumnName("ID").HasColumnType("INTEGER").IsRequired();
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Title).HasColumnName("POLYMER_GROUP").HasColumnType("VARCHAR(30)").IsRequired();
            builder.Property(p => p.TitleRus).HasColumnName("POLYMER_GROUP_RUS").HasColumnType("VARCHAR(30)").IsRequired();
        }
    }
}
