using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CablesDatabaseEFCoreFirebird.Entities.Configurations
{
    public class ColorConfiguration : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.ToTable("COLOR");

            builder.Property(c => c.Id).HasColumnName("ID").HasColumnType("INTEGER").IsRequired();
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Title).HasColumnName("COLOR_NAME").HasColumnType("VARCHAR(20)").IsRequired();
            builder.Property(c => c.TitleRus).HasColumnName("COLOR_NAME_RUS").HasColumnType("VARCHAR(20)").IsRequired();
        }
    }
}
