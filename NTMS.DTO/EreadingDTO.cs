using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTMS.DTO
{
    public class EreadingDTO
    {
        public int Id { get; set; }

        public string StartDate { get; set; }

        public string EndDate { get; set; }

        public int PreviousReading { get; set; }

        public int CurrentReading { get; set; }

        public int? EmeterId { get; set; }
        public string? EmeterNumber { get; set; }
    }
}
