using System;
using System.Collections.Generic;

namespace NTMS.Model;

public partial class UtilityOption
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public decimal Cost { get; set; }

    public bool IsActive { get; set; }

    public virtual ICollection<Flat> Flats { get; set; } = new List<Flat>();
}
