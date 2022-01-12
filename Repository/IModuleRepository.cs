
using Horus.Models;

namespace Horus.Repository
{
    public interface IModuleRepository
    {
        Task<Module> AddModule(Module module);
    }
}