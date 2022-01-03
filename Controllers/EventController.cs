using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Horus.Data;
using Horus.Models;
using Microsoft.AspNetCore.Mvc;

namespace Horus.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventController : ControllerBase
    {
        private readonly DataContext _context;
        public EventController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult> CreateEvents(Event model)
        {
            try
            {
                var newEvent = _context.Events.Add(model);
                await _context.SaveChangesAsync();
                return Ok(newEvent);
            }
            catch (Exception)
            {
                return BadRequest(new { Erro = "Não foi possível criar evento" });
            }
        }
    }
}