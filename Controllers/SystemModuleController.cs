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

    }
}