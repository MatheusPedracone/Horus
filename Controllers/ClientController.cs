using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Horus.Data;
using Horus.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Horus.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientController : ControllerBase
    {
        private readonly DataContext _context;
        public ClientController(DataContext context)
        {
            _context = context;
        }

        [HttpPost("CreateClient")]
        public async Task<ActionResult<Client>> CreateClient([FromBody] Client model)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { Erro = "Verifique os campos digitados!" });

            var cnpj = await _context
            .Clients
            .AsNoTracking()
            .Where(e => e.Cnpj == model.Cnpj)
            .FirstOrDefaultAsync();

            if (cnpj != null)
            {
                return NotFound(new { Erro = "cliente já existe" });
            }

            try
            {
                _context.Clients.Add(model);
                await _context.SaveChangesAsync();
                return Ok(model);
            }
            catch (Exception)
            {
                return BadRequest(new { Erro = "Não foi possível criar cliente" });
            }
        }
    }
}