using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Horus.Dtos;
using Horus.Models;
using Horus.Repository;

namespace Horus.Business.Implementations
{
    public class SystemEventBusinessImplementation : ISystemEventBusiness
    {
        private readonly ISystemEventRepository _repository;
        public SystemEventBusinessImplementation(ISystemEventRepository repository)
        {
            _repository = repository;
        }
        // public async Task<SystemEvent> SaveSystemEventsAsync(SystemEvent model)
        // {
        //     return await _repository.SaveSystemEvents(model);
        // }
    }
}