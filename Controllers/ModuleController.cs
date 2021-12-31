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
    public class ModuleController : ControllerBase
    {
        private readonly DataContext _context;
        public ModuleController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult> CreateEvents(Module model)
        {
            try
            {
                var newModule = await _context.Modules.AddAsync(model);
                await _context.SaveChangesAsync();
                return Ok(newModule);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}