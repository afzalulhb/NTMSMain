using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NTMS.Model;

namespace NTMS.DAL.EntityMappingConfiguration
{
    public class EmeterConfiguration : IEntityTypeConfiguration<Emeter>, INtmsMapping
    {
        public void Configure(EntityTypeBuilder<Emeter> builder)
        {
            builder.HasKey(e => e.Id).HasName("PK_dbo.EMeters");

            builder.ToTable("EMeters");

            builder.HasIndex(e => e.FlatId, "IX_Flat_Id");

            builder.Property(e => e.FlatId).HasColumnName("Flat_Id");

            builder.HasOne(d => d.Flat).WithMany(p => p.Emeters)
                .HasForeignKey(d => d.FlatId)
                .HasConstraintName("FK_dbo.EMeters_dbo.Flats_Flat_Id");
        }
    }
}
