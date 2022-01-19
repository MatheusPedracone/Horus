using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Horus.Models;
using Horus.Repository;

namespace Horus.Business.Implementations
{
    public class ModuleBusinessImplementation : IModuleBusiness
    {
        private readonly IModuleRepository _moduleRepository;
        public ModuleBusinessImplementation(IModuleRepository moduleRepository)
        {
            _moduleRepository = moduleRepository;
        }
        public async Task<Module> AddModuleAsync(Module module)
        {
            return await _moduleRepository.AddModuleAsync(module);
        }
    }
}