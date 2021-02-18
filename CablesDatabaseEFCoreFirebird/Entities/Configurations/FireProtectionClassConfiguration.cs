using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CablesDatabaseEFCoreFirebird.Entities.Configurations
{
    public class FireProtectionClassConfiguration : IEntityTypeConfiguration<FireProtectionClass>
    {
        public void Configure(EntityTypeBuilder<FireProtectionClass> builder)
        {
            builder.ToTable("FIRE_PROTECTION_CLASS");

            builder.Property(c => c.Id).HasColumnName("ID").HasColumnType("INTEGER").IsRequired();
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Class).HasColumnName("CLASS").HasColumnType("VARCHAR(20)").IsRequired();
            builder.Property(c => c.Designation).HasColumnName("DESIGNATION").HasColumnType("VARCHAR(20)").IsRequired();
        }
    }
}
