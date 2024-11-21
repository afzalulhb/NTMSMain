using Microsoft.AspNetCore.Mvc;
using NTMS.API.Utility;
using NTMS.BLL.Services.Abstract;
using NTMS.DTO;

namespace NTMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EReadingController : ControllerBase
    {
        private readonly IEreadingService _readingService;

        public EReadingController(IEreadingService readingService)
        {
            _readingService = readingService;
        }
        [HttpGet, Route("Load")]
        public async Task<IActionResult> Load(int meterId, string firstDate, string lastDate)
        {
            var rsp = new Response<EreadingDTO>();

            try
            {
                rsp.status = true;
                rsp.value = await _readingService.LoadReading(meterId, firstDate, lastDate);
            }
            catch (Exception ex)
            {
                rsp.status = false;
                rsp.msg = ex.Message;
            }
            return Ok(rsp);
        }

        [HttpGet, Route("LastReading")]
        public async Task<IActionResult> LastReading(int meterId)
        {
            var rsp = new Response<EreadingDTO>();

            try
            {
                rsp.status = true;
                rsp.value = await _readingService.GetLastReading(meterId);
            }
            catch (Exception ex)
            {
                rsp.status = false;
                rsp.msg = ex.Message;
            }
            return Ok(rsp);
        }
        [HttpPost, Route("Create")]
        public async Task<IActionResult> Create([FromBody] EreadingDTO reading)
        {
            var rsp = new Response<EreadingDTO>();

            try
            {
                rsp.status = true;
                rsp.value = await _readingService.Create(reading);
            }
            catch (Exception ex) { rsp.status = false; rsp.msg = ex.Message; }
            return Ok(rsp);
        }

        [HttpPut, Route("Edit")]
        public async Task<IActionResult> Edit([FromBody] EreadingDTO reading)
        {
            var rsp = new Response<bool>();

            try
            {
                rsp.status = true;
                rsp.value = await _readingService.Edit(reading);
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
                rsp.value = await _readingService.Delete(id);
            }
            catch (Exception ex) { rsp.status = false; rsp.msg = ex.Message; }
            return Ok(rsp);
        }
    }
}
