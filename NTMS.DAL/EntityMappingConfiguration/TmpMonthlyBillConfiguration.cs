using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NTMS.Model;

namespace NTMS.DAL.EntityMappingConfiguration
{
    public class TmpMonthlyBillConfiguration : IEntityTypeConfiguration<TmpMonthlyBill>, INtmsMapping
    {
        public void Configure(EntityTypeBuilder<TmpMonthlyBill> builder)
        {
            builder
                   .HasNoKey()
                   .ToTable("tmpMonthlyBills");

            builder.Property(e => e.BillEndDate).HasMaxLength(50);
            builder.Property(e => e.BillStartDate).HasMaxLength(50);
            builder.Property(e => e.BillingPeriod).HasMaxLength(50);
            builder.Property(e => e.CleanerBill).HasMaxLength(50);
            builder.Property(e => e.ConsumedElectricUnit).HasMaxLength(50);
            builder.Property(e => e.DemandCharge).HasMaxLength(50);
            builder.Property(e => e.ElectricMeterCurrentReading).HasMaxLength(50);
            builder.Property(e => e.ElectricMeterLastReading).HasMaxLength(50);
            builder.Property(e => e.ElectricMeterNo).HasMaxLength(50);
            builder.Property(e => e.ElectricityBill).HasMaxLength(50);
            builder.Property(e => e.ElectricityCharge).HasMaxLength(50);
            builder.Property(e => e.FlatCode).HasMaxLength(10);
            builder.Property(e => e.GasBill).HasMaxLength(50);
            builder.Property(e => e.HouseRent).HasMaxLength(50);
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.MinimumCharge).HasMaxLength(50);
            builder.Property(e => e.PrincipalAmount).HasMaxLength(50);
            builder.Property(e => e.ServiceCharge).HasMaxLength(50);
            builder.Property(e => e.TenantName).HasMaxLength(256);
            builder.Property(e => e.Total).HasMaxLength(50);
            builder.Property(e => e.TotalConsumedWaterUnit).HasMaxLength(50);
            builder.Property(e => e.Vat)
                .HasMaxLength(50)
                .HasColumnName("VAT");
            builder.Property(e => e.WaterBill).HasMaxLength(50);
            builder.Property(e => e.WaterMeter1ConsumedUnit).HasMaxLength(50);
            builder.Property(e => e.WaterMeter1CurrentReading).HasMaxLength(50);
            builder.Property(e => e.WaterMeter1LastReading).HasMaxLength(50);
            builder.Property(e => e.WaterMeter1No).HasMaxLength(50);
            builder.Property(e => e.WaterMeter2ConsumedUnit).HasMaxLength(50);
            builder.Property(e => e.WaterMeter2CurrentReading).HasMaxLength(50);
            builder.Property(e => e.WaterMeter2LastReading).HasMaxLength(50);
            builder.Property(e => e.WaterMeter2No).HasMaxLength(50);
            builder.Property(e => e.WaterUnitPrice).HasMaxLength(50);
        }
    }
}
