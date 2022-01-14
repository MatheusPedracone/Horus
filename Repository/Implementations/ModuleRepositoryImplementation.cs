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
        public async Task<Module> AddModuleAsync(Module model)
        {
            try
            {
                var newModule = _context.Modules.Add(model);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return model;
        }
    }
}