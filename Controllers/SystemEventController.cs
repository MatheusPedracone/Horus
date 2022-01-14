using Horus.Business;
using Horus.Data;
using Horus.Dtos;
using Horus.Models;
using Horus.Repository;
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
        public readonly DataContext _context;
        public SystemEventController(ISystemEventBusiness systemEventBusiness, DataContext context)
        {
            _context = context;
            _systemEventBusiness = systemEventBusiness;
        }

        [HttpPut("")]
        public async Task<ActionResult<SystemEvent>> SaveSystemEvents(SystemEvent model)
        {
            // var client = _context.Clients.FirstOrDefault();

            // var systemEvent = _context.SystemEvents.FirstOrDefault();

            // var findClientEvent = await _context.Events
            //                                         .AsNoTracking()
            //                                         .Where(e => e.EventName == model.Event.EventName)
            //                                         .FirstOrDefaultAsync();

            try
            {
                // if (findClientEvent == null)
                // {
                    _context.SystemEvents.AddRange(model);
                    await _context.SaveChangesAsync();
                // }

                return Ok(model);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}