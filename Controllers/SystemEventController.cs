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
    public class SystemEventController : ControllerBase
    {
        private readonly DataContext _context;
        public SystemEventController(DataContext context)
        {
            _context = context;
        }

       
    }
}