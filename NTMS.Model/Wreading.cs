using System;
using System.Collections.Generic;

namespace NTMS.Model;

public partial class Wreading
{
    public int Id { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public int PreviousReading { get; set; }

    public int CurrentReading { get; set; }

    public int? WmeterId { get; set; }

    public virtual Wmeter? Wmeter { get; set; }
}
