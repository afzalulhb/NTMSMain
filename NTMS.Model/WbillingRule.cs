using System;
using System.Collections.Generic;

namespace NTMS.Model;

public partial class WbillingRule
{
    public int Id { get; set; }

    public decimal UnitPrice { get; set; }

    public decimal ServiceCharge { get; set; }

    public decimal Vat { get; set; }
}
