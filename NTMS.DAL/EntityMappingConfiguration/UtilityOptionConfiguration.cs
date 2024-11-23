using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NTMS.Model;

namespace NTMS.DAL.EntityMappingConfiguration
{
    public class UtilityOptionConfiguration : IEntityTypeConfiguration<UtilityOption>, INtmsMapping
    {
        public void Configure(EntityTypeBuilder<UtilityOption> builder)
        {
            builder.HasKey(e => e.Id).HasName("PK_dbo.UtilityOptions");

            builder.Property(e => e.Cost).HasColumnType("decimal(18, 2)");

            builder.HasMany(d => d.Flats).WithMany(p => p.UtilityOptions)
                .UsingEntity<Dictionary<string, object>>(
                    "UtilityOptionFlat",
                    r => r.HasOne<Flat>().WithMany()
                        .HasForeignKey("FlatId")
                        .HasConstraintName("FK_dbo.UtilityOptionFlats_dbo.Flats_Flat_Id"),
                    l => l.HasOne<UtilityOption>().WithMany()
                        .HasForeignKey("UtilityOptionId")
                        .HasConstraintName("FK_dbo.UtilityOptionFlats_dbo.UtilityOptions_UtilityOption_Id"),
                    j =>
                    {
                        j.HasKey("UtilityOptionId", "FlatId").HasName("PK_dbo.UtilityOptionFlats");
                        j.ToTable("UtilityOptionFlats");
                        j.HasIndex(new[] { "FlatId" }, "IX_Flat_Id");
                        j.HasIndex(new[] { "UtilityOptionId" }, "IX_UtilityOption_Id");
                        j.IndexerProperty<int>("UtilityOptionId").HasColumnName("UtilityOption_Id");
                        j.IndexerProperty<int>("FlatId").HasColumnName("Flat_Id");
                    });
        }
    }
}
