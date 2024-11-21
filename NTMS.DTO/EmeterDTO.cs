using NTMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTMS.DTO
{
    public class EmeterDTO
    {
        public int Id { get; set; }

        public string? MeterNumber { get; set; }


        public int IsActive { get; set; }

        public int? FlatId { get; set; }
        public string? FlatDescription { get; set; }

       // public virtual ICollection<EreadingDTO>? Ereadings { get; set; } 
    }
}
