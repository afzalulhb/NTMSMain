using NTMS.Model;

namespace NTMS.DTO
{
    public class FlatDTO
    {
        public int Id { get; set; }

        public string? Code { get; set; }

        public string? Rent { get; set; }

   /*     public virtual ICollection<Emeter> Emeters { get; set; } 

        public virtual ICollection<TenantDTO> Tenants { get; set; }

        public virtual ICollection<Wmeter> Wmeters { get; set; } 

        public virtual ICollection<UtilityOption> UtilityOptions { get; set; }*/
    }
}
