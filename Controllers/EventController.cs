using Horus.Business;
using Horus.Models;
using Microsoft.AspNetCore.Mvc;

namespace Horus.Controllers
{
    [ApiVersion("1.0")]
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class EventController : ControllerBase
    {
        private readonly IEventBusiness _eventBusiness;
        public EventController(IEventBusiness eventBusiness)
        {
            _eventBusiness = eventBusiness;

        }

        [HttpPost]
        public async Task<ActionResult> CreateEvents(Event model)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { Erro = "Verifique os campos digitados!"});

            try
            {
                var newEvent = await _eventBusiness.AddEvents(model);
                return Ok(newEvent);
            }
            catch (Exception)
            {
                return BadRequest(new { Erro = "Não foi possível criar evento" });
            }
        }
    }
}