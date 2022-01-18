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
        private readonly ISystemEventRepository _systemEventRepository;
        public SystemEventBusinessImplementation(ISystemEventRepository systemEventRepository)
        {
            _systemEventRepository = systemEventRepository;
        }

        public async Task<ClientSystemEventsDto> SaveSystemEventsAsync(ClientSystemEventsDto clientSystemEventsDto)
        {
            return await _systemEventRepository.SaveSystemEvents(clientSystemEventsDto);
        }
    }
}