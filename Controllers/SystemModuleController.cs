using Horus.Business;
using Horus.Data;
using Horus.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Horus.Controllers
{
    [ApiVersion("1.0")]
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class SystemModuleController : ControllerBase
    {
        private readonly ISystemModuleBusiness _systemModuleBusiness;
        public SystemModuleController(ISystemModuleBusiness systemModuleBusiness)
        {
            _systemModuleBusiness = systemModuleBusiness;
        }

        [HttpPost]
        public async Task<ActionResult> CreateSystemEvents(SystemModuleDto model)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { Erro = "Verifique os campos digitados!"});

             try
            {
                var newSystemModule = await _systemModuleBusiness.SaveSystemModuleAsync(model);
                return Ok(newSystemModule);
            }
            catch (Exception)
            {
                return BadRequest(new { Erro = "Não foi possível criar modulo" });
            }
        }
    }
}