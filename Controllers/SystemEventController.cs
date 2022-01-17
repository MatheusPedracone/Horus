using Horus.Business;
using Horus.Data;
using Horus.Dtos;
using Horus.Models;
using Microsoft.AspNetCore.Mvc;

namespace Horus.Controllers
{
    [ApiVersion("1.0")]
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class SystemEventController : ControllerBase
    {
        private readonly ISystemEventBusiness _systemEventBusiness;
        public readonly DataContext _context;
        public SystemEventController(ISystemEventBusiness systemEventBusiness, DataContext context)
        {
            _context = context;
            _systemEventBusiness = systemEventBusiness;
        }

        [HttpPost("")]
        public async Task<ActionResult> SaveSystemEvents([FromBody] SystemEvent model)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { Erro = "Verifique os campos digitados!" });

            try
            {
               var createSystemEvent = await _systemEventBusiness.SaveSystemEventsAsync(model);
                return Ok(createSystemEvent);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}