using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Horus.Dtos;
using Horus.Models;
using Horus.Repository;

namespace Horus.Business.Implementations
{
    public class ClientBusinessImplementation : IClientBusiness
    {
        public readonly IClientRepository _clientRepository;
        public ClientBusinessImplementation(IClientRepository clientRepository )
        {
            _clientRepository = clientRepository;
        }
        public async Task<ClientRegisterDto> CreateClientAsync(ClientRegisterDto clientRegisterDto)
        {
            return await _clientRepository.CreateClientAsync(clientRegisterDto);
        }
    }
}