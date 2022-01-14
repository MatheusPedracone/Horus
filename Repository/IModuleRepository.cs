
using Horus.Models;

namespace Horus.Repository
{
    public interface IModuleRepository
    {
        Task<Module> AddModuleAsync(Module model);
    }
}