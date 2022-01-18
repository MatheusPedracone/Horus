using Horus.Business;
using Horus.Models;
using Microsoft.AspNetCore.Mvc;

namespace Horus.Controllers
{
    [ApiVersion("1.0")]
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class ModuleController : ControllerBase
    {
        private readonly IModuleBusiness _moduleBusiness;
        public ModuleController(IModuleBusiness moduleBusiness)
        {
            _moduleBusiness = moduleBusiness;
        }

        [HttpPost]
        public async Task<ActionResult> CreateEvents(Module model)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { Erro = "Verifique os campos digitados!"});

            try
            {
                var newModule = await _moduleBusiness.AddModuleAsync(model);
                return Ok(newModule);
            }
            catch (Exception)
            {
                return BadRequest(new { Erro = "Não foi possível criar modulo" });
            }
        }
    }
}