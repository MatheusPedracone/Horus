using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Horus.Dtos;
using Horus.Models;

namespace Horus.Business
{
    public interface ISystemEventBusiness
    {
        Task<SystemEvent> SaveSystemEventsAsync(SystemEvent model);
    }
}