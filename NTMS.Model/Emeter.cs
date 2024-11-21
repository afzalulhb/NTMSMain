using System;
using System.Collections.Generic;

namespace NTMS.Model;

public partial class Emeter
{
    public int Id { get; set; }

    public string? MeterNumber { get; set; }

    public string? Description { get; set; }

    public bool IsActive { get; set; }

    public int? FlatId { get; set; }

    public virtual ICollection<Ereading> Ereadings { get; set; } = new List<Ereading>();

    public virtual Flat? Flat { get; set; }
}
