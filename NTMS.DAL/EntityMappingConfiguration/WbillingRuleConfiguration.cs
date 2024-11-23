using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NTMS.Model;

namespace NTMS.DAL.EntityMappingConfiguration
{
    public class WbillingRuleConfiguration : IEntityTypeConfiguration<WbillingRule>, INtmsMapping
    {
        public void Configure(EntityTypeBuilder<WbillingRule> builder)
        {

            builder.HasKey(e => e.Id).HasName("PK_dbo.WBillingRules");

            builder.ToTable("WBillingRules");

            builder.Property(e => e.ServiceCharge).HasColumnType("decimal(18, 2)");
            builder.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");
            builder.Property(e => e.Vat).HasColumnType("decimal(18, 2)");
        }
    }
}
