using Horus.Business;
using Horus.Data;
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
    }
}