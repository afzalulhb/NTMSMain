using System;
using System.Collections.Generic;

namespace NTMS.Model;

public partial class Ereading
{
    public int Id { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public int PreviousReading { get; set; }

    public int CurrentReading { get; set; }

    public int? EmeterId { get; set; }

    public virtual Emeter? Emeter { get; set; }
}
