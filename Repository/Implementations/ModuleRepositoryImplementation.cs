using Horus.Data;
using Horus.Models;

namespace Horus.Repository.Implementations
{
    public class ModuleRepositoryImplementation : IModuleRepository
    {
        private readonly DataContext _context;
        public ModuleRepositoryImplementation(DataContext context)
        {
            _context = context;
        }
        public async Task<Module> AddModule(Module module)
        {
            try
            {
                var newModule = _context.Modules.Add(module);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return module;
        }
    }
}