using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NTMS.API.Utility;
using NTMS.BLL.Services;
using NTMS.BLL.Services.Abstract;
using NTMS.DTO;

namespace NTMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TenantController : ControllerBase
    {
        private readonly ITenantService _tenantService;

        public TenantController(ITenantService tenantService)
        {
            _tenantService = tenantService;
        }
        [HttpGet, Route("List")]
        public async Task<IActionResult> List()
        {
            var rsp = new Response<List<TenantDTO>>();

            try {
                rsp.status = true;
                rsp.value = await _tenantService.List();
            } catch (Exception ex) {
                rsp.status = false;
                rsp.msg = ex.Message;
            }
            return Ok(rsp);
        }

        [HttpPost, Route("Create")]
        public async Task<IActionResult> Create([FromBody] TenantDTO tenant)
        {
            var rsp = new Response<TenantDTO>();

            try
            {
                rsp.status = true;
                rsp.value = await _tenantService.Create(tenant);
            }
            catch (Exception ex) { rsp.status = false; rsp.msg = ex.Message; }
            return Ok(rsp);
        }

        [HttpPut, Route("Edit")]
        public async Task<IActionResult> Edit([FromBody] TenantDTO tenant)
        {
            var rsp = new Response<bool>();

            try
            {
                rsp.status = true;
                rsp.value = await _tenantService.Edit(tenant);
            }
            catch (Exception ex) { rsp.status = false; rsp.msg = ex.Message; }
            return Ok(rsp);
        }

        [HttpDelete, Route("Delete/{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var rsp = new Response<bool>();

            try
            {
                rsp.status = true;
                rsp.value = await _tenantService.Delete(id);
            }
            catch (Exception ex) { rsp.status = false; rsp.msg = ex.Message; }
            return Ok(rsp);
        }
    }
}
