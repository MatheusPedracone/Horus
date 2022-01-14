
using Horus.Business;
using Horus.Data;
using Horus.Dtos;
using Horus.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Horus.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class ClientController : ControllerBase
    {
        private readonly IClientBusiness _clientBusiness;
        public ClientController(IClientBusiness clientBusiness)
        {
            _clientBusiness = clientBusiness;
        }

        [HttpPost("")]
        public async Task<ActionResult<ClientRegisterDto>> PostClientAsync([FromBody] ClientRegisterDto clientRegisterDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { Erro = "Verifique os campos digitados!" });

            try
            {
                var newClientDto = _clientBusiness.CreateClientAsync(clientRegisterDto);
                return Ok(newClientDto);
            }
            catch (Exception)
            {
                return BadRequest(new { Erro = "Não foi possível criar cliente" });
            }
        }

        [HttpGet("")]
        public async Task<ActionResult<Client>> Get([FromBody] Client client)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { Erro = "Verifique os campos digitados!"});

            try
            {
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest(new { Erro = "Não foi possível criar cliente!"});
            }
        }

        [HttpPut("")]
        public async Task<ActionResult<ClientSystemEventsDto>> PutclientSystemEventsDto([FromBody] ClientSystemEventsDto clientSystemEventsDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { Erro = "Verifique os campos digitados!"});

            try
            {
                return Ok(clientSystemEventsDto);
            }
            catch (Exception)
            {
                return BadRequest(new { Erro = "Não foi possível criar cliente!"});
            }
        }
    }
}