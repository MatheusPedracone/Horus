using Horus.Business;
using Horus.Data;
using Horus.Dtos;
using Horus.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Horus.Controllers
{
    [ApiVersion("1.0")]
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class SystemEventController : ControllerBase
    {
        private readonly ISystemEventBusiness _systemEventBusiness;
        public SystemEventController(ISystemEventBusiness systemEventBusiness)
        {
            _systemEventBusiness = systemEventBusiness;
        }

        [HttpPost("")]
        public async Task<ActionResult> SaveSystemEvents([FromBody] ClientSystemEventsDto clientSystemEventsDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { Erro = "Verifique os campos digitados!" });

            try
            {
                var newSystemEvent = await _systemEventBusiness.SaveSystemEventsAsync(clientSystemEventsDto);
                return Ok(newSystemEvent);
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}