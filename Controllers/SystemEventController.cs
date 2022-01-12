using Horus.Business;
using Horus.Data;
using Microsoft.AspNetCore.Mvc;

namespace Horus.Controllers
{
    [ApiVersion("1.0")]
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class SystemEventController : ControllerBase
    {
        private readonly ISystemEventBusiness _systemEventBusiness;
        public SystemEventController(ISystemEventBusiness systemEventBusiness)
        {
            _systemEventBusiness = systemEventBusiness;
        }
    }
}