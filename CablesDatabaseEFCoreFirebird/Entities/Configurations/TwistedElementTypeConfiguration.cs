using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CablesDatabaseEFCoreFirebird.Entities.Configurations
{
    public class TwistedElementTypeConfiguration : IEntityTypeConfiguration<TwistedElementType>
    {
        public void Configure(EntityTypeBuilder<TwistedElementType> builder)
        {
            builder.ToTable("TWISTED_ELEMENT_TYPE");

            builder.Property(t => t.Id).HasColumnName("ID").HasColumnType("INTEGER").IsRequired();
            builder.HasKey(t => t.Id);

            builder.Property(t => t.ElementType).HasColumnName("ELEMENT_TYPE").HasColumnType("VARCHAR(20)").IsRequired();
        }
    }
}
