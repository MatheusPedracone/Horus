using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Horus.Dtos;
using Horus.Models;

namespace Horus.Repository
{
    public interface IClientRepository
    {
        Task<ClientRegisterDto> CreateClientAsync(ClientRegisterDto clientRegisterDto);
    }
}