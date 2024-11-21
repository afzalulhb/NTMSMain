using System;
using System.Collections.Generic;

namespace NTMS.Model;

public partial class TmpMonthlyBill
{
    public int Id { get; set; }

    public string? TenantName { get; set; }

    public string? BillingPeriod { get; set; }

    public string? BillStartDate { get; set; }

    public string? BillEndDate { get; set; }

    public string? ElectricMeterNo { get; set; }

    public string? ElectricMeterCurrentReading { get; set; }

    public string? ElectricMeterLastReading { get; set; }

    public string? ConsumedElectricUnit { get; set; }

    public string? ElectricityCharge { get; set; }

    public string? DemandCharge { get; set; }

    public string? ServiceCharge { get; set; }

    public string? MinimumCharge { get; set; }

    public string? PrincipalAmount { get; set; }

    public string? Vat { get; set; }

    public string? ElectricityBill { get; set; }

    public string? WaterMeter1No { get; set; }

    public string? WaterMeter1CurrentReading { get; set; }

    public string? WaterMeter1LastReading { get; set; }

    public string? WaterMeter1ConsumedUnit { get; set; }

    public string? WaterMeter2No { get; set; }

    public string? WaterMeter2CurrentReading { get; set; }

    public string? WaterMeter2LastReading { get; set; }

    public string? WaterMeter2ConsumedUnit { get; set; }

    public string? TotalConsumedWaterUnit { get; set; }

    public string? WaterUnitPrice { get; set; }

    public string? WaterBill { get; set; }

    public string? HouseRent { get; set; }

    public string? GasBill { get; set; }

    public string? CleanerBill { get; set; }

    public string? Total { get; set; }

    public string? FlatCode { get; set; }
}
