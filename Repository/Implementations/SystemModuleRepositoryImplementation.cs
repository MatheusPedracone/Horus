using Horus.Data;
using Horus.Models;

namespace Horus.Repository.Implementations
{
    public class SystemModuleRepositoryImplementation : ISystemModuleRepository
    {
        private readonly DataContext _context;
        public SystemModuleRepositoryImplementation(DataContext context)
        {
            _context = context;
        }
        public Task<SystemModule> SaveSystemModules(SystemModule systemModule)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}