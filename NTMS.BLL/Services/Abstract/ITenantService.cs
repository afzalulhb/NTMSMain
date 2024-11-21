using NTMS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTMS.BLL.Services.Abstract
{
    public interface ITenantService
    {
        Task<List<TenantDTO>> List();
        Task<TenantDTO> Create(TenantDTO model);
        Task<bool>Edit(TenantDTO model);
        Task<bool>Delete(int id);
    }
}
