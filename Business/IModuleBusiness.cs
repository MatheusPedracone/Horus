using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Horus.Models;

namespace Horus.Business
{
    public interface IModuleBusiness
    {
        Task<Module> AddModule(Module module);
    }
}