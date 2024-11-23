using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NTMS.Model;

namespace NTMS.DAL.EntityMappingConfiguration
{
    public class WmeterConfiguration : IEntityTypeConfiguration<Wmeter>, INtmsMapping
    {
        public void Configure(EntityTypeBuilder<Wmeter> builder)
        {
            builder.HasKey(e => e.Id).HasName("PK_dbo.WMeters");

            builder.ToTable("WMeters");

            builder.HasIndex(e => e.FlatId, "IX_Flat_Id");

            builder.Property(e => e.FlatId).HasColumnName("Flat_Id");

            builder.HasOne(d => d.Flat).WithMany(p => p.Wmeters)
                .HasForeignKey(d => d.FlatId)
                .HasConstraintName("FK_dbo.WMeters_dbo.Flats_Flat_Id");
        }
    }
}
