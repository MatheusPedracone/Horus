using Horus.Dtos;
using Horus.Models;

namespace Horus.Repository
{
    public interface ISystemModuleRepository
    {
        Task<ClientSystemModuleDto> SaveSystemModules(ClientSystemModuleDto clientSystemModuleDto);
    }
}