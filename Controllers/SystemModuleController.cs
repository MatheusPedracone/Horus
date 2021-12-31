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
    public class SystemModuleController : ControllerBase
    {
        private readonly DataContext _context;
        public SystemModuleController(DataContext context)
        {
            _context = context;
        }

        
        // [HttpPost]
        // public async Task<ActionResult<Client>> Post(Client model)
        // {
        //     try
        //     {

        //         var createSystemEvents = _context.Clients.AddAsync(model);
        //         await _context.SaveChangesAsync();
        //         return Ok(createSystemEvents);
        //     }
        //     catch (Exception)
        //     {
        //         return BadRequest(new { Erro = "Não foi possível criar cliente" });
        //     }
        // }
    }
}