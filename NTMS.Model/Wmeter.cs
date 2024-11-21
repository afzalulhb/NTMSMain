using System;
using System.Collections.Generic;

namespace NTMS.Model;

public partial class Wmeter
{
    public int Id { get; set; }

    public string? MeterNumber { get; set; }

    public bool IsActive { get; set; }

    public int? FlatId { get; set; }

    public virtual Flat? Flat { get; set; }

    public virtual ICollection<Wreading> Wreadings { get; set; } = new List<Wreading>();
}
