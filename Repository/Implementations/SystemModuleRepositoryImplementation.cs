using Horus.Data;
using Horus.Dtos;
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

        public Task<ClientSystemModuleDto> SaveSystemModules(ClientSystemModuleDto clientSystemModuleDto)
        {
            throw new NotImplementedException();
        }
    }
}