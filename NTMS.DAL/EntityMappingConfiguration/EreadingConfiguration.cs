using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NTMS.Model;

namespace NTMS.DAL.EntityMappingConfiguration
{
    public class EreadingConfiguration : IEntityTypeConfiguration<Ereading>, INtmsMapping
    {
        public void Configure(EntityTypeBuilder<Ereading> builder)
        {
            builder.HasKey(e => e.Id).HasName("PK_dbo.EReadings");

            builder.ToTable("EReadings");

            builder.HasIndex(e => e.EmeterId, "IX_EMeter_Id");

            builder.Property(e => e.EmeterId).HasColumnName("EMeter_Id");
            builder.Property(e => e.EndDate).HasColumnType("datetime");
            builder.Property(e => e.StartDate).HasColumnType("datetime");

            builder.HasOne(d => d.Emeter).WithMany(p => p.Ereadings)
                .HasForeignKey(d => d.EmeterId)
                .HasConstraintName("FK_dbo.EReadings_dbo.EMeters_EMeter_Id");
        }
    }
}
