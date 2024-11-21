using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NTMS.API.Utility;
using NTMS.BLL.Services.Abstract;
using NTMS.DTO;

namespace NTMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlatController : ControllerBase
    {
        private readonly IFlatService _flatService;

        public FlatController(IFlatService flatService)
        {
            _flatService = flatService;
        }
        [HttpGet,Route("List")]
        public async Task<IActionResult> List()
        {
            var rsp = new Response<List<FlatDTO>>();

            try
            {
                rsp.status = true;
                rsp.value = await _flatService.List();
            }
            catch (Exception ex) { 
            rsp.status = false;
                rsp.msg = ex.Message;
            }
            return Ok(rsp);
        }
        [HttpPost, Route("Create")]
        public async Task<IActionResult> Create([FromBody] FlatDTO flat)
        {
            var rsp = new Response<FlatDTO>();

            try { 
            rsp.status = true;
                rsp.value =await _flatService.Create(flat);
            } catch (Exception ex) { rsp.status = false; rsp.msg = ex.Message; }
            return Ok(rsp);
        }

        [HttpPut, Route("Edit")]
        public async Task<IActionResult> Edit([FromBody] FlatDTO flat)
        {
            var rsp = new Response<bool>();

            try
            {
                rsp.status = true;
                rsp.value = await _flatService.Edit(flat);
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
                rsp.value = await _flatService.Delete(id);
            }
            catch (Exception ex) { rsp.status = false; rsp.msg = ex.Message; }
            return Ok(rsp);
        }
    }
}
