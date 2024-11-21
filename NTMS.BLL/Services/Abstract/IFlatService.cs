using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using NTMS.DTO;

namespace NTMS.BLL.Services.Abstract
{
    public interface IFlatService
    {

        Task<List<FlatDTO>> List();
        Task<FlatDTO> Create(FlatDTO model);
        Task<bool> Edit(FlatDTO model);
        Task<bool> Delete(int id);
    }
}
