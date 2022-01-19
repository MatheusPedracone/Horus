using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Horus.Dtos;

namespace Horus.Business
{
    public interface ISystemModuleBusiness
    {
        Task<ClientSystemModuleDto> SaveSystemModuleAsync(ClientSystemModuleDto clientSystemModuleDto);
    }
}