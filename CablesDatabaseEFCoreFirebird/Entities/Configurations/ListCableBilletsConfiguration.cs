using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CablesDatabaseEFCoreFirebird.Entities.Configurations
{
    public class ListCableBilletsConfiguration : IEntityTypeConfiguration<ListCableBillets>
    {
        public void Configure(EntityTypeBuilder<ListCableBillets> builder)
        {
            builder.ToTable("LIST_CABLE_BILLETS");

            builder.Property(l => l.Id).HasColumnName("ID").HasColumnType("INTEGER").IsRequired();
            builder.HasKey(l => l.Id);

            builder.Property(l => l.CableId).HasColumnName("CABLE_ID").HasColumnType("INTEGER").IsRequired();
            builder.HasOne(l => l.Cable).WithMany(c => c.ListCableBillets).HasForeignKey(l => l.CableId);

            builder.Property(l => l.BilletId).HasColumnName("BILLET_ID").HasColumnType("INTEGER").IsRequired();
            builder.HasOne(l => l.Billet).WithMany(p => p.ListCableBillets).HasForeignKey(l => l.BilletId);
        }
    }
}
