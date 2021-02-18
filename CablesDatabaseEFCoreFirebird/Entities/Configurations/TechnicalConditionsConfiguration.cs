using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CablesDatabaseEFCoreFirebird.Entities.Configurations
{
    public class TechnicalConditionsConfiguration : IEntityTypeConfiguration<TechnicalConditions>
    {
        public void Configure(EntityTypeBuilder<TechnicalConditions> builder)
        {
            builder.ToTable("TECHNICAL_CONDITIONS");

            builder.Property(t => t.Id).HasColumnName("ID").HasColumnType("INTEGER").IsRequired();
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Title).HasColumnName("TECH_CONDITIONS_TITLE").HasColumnType("VARCHAR(50)").IsRequired();
        }
    }
}
