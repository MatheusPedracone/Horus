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
        private readonly IModuleRepository _repository;
        public ModuleBusinessImplementation(IModuleRepository repository)
        {
            _repository = repository;
        }
        public async Task<Module> AddModule(Module module)
        {
            return await _repository.AddModule(module);
        }
    }
}