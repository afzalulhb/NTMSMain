using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NTMS.Model;

namespace NTMS.DAL.EntityMappingConfiguration
{
    public class WreadingConfiguration : IEntityTypeConfiguration<Wreading>, INtmsMapping
    {
        public void Configure(EntityTypeBuilder<Wreading> builder)
        {
            builder.HasKey(e => e.Id).HasName("PK_dbo.WReadings");

            builder.ToTable("WReadings");

            builder.HasIndex(e => e.WmeterId, "IX_EMeter_Id");

            builder.Property(e => e.EndDate).HasColumnType("datetime");
            builder.Property(e => e.StartDate).HasColumnType("datetime");
            builder.Property(e => e.WmeterId).HasColumnName("WMeter_Id");

            builder.HasOne(d => d.Wmeter).WithMany(p => p.Wreadings)
                .HasForeignKey(d => d.WmeterId)
                .HasConstraintName("FK_dbo.WReadings_dbo.WMeters_WMeter_Id");
        }
    }
}
