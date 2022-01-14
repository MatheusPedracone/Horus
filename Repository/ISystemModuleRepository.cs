using Horus.Models;

namespace Horus.Repository
{
    public interface ISystemModuleRepository
    {
        Task<SystemModule> SaveSystemModules(SystemModule model);
    }
}