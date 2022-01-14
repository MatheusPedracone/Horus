using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Horus.Data;
using Horus.Dtos;
using Horus.Models;
using Microsoft.EntityFrameworkCore;

namespace Horus.Repository.Implementations
{
    public class ClientRepositoryImplementation : IClientRepository
    {
        private readonly DataContext _context;
        public ClientRepositoryImplementation(DataContext context)
        {
            _context = context;
        }
        public async Task<ClientRegisterDto> CreateClientAsync(ClientRegisterDto clientRegisterDto)
        {
            try
            {
                _context.Clients.Add(new Client
                {
                    Name = clientRegisterDto.Name,
                    FantasyName = clientRegisterDto.FantasyName,
                    Cnpj = clientRegisterDto.Cnpj,
                    ContributorType = clientRegisterDto.ContributorType,
                    Cellphone = clientRegisterDto.Cellphone,
                    Email = clientRegisterDto.Email,
                    Address = new Address
                    {
                        ZipCode = clientRegisterDto.Address.ZipCode,
                        Street = clientRegisterDto.Address.Street,
                        City = clientRegisterDto.Address.City,
                        County = clientRegisterDto.Address.County,
                        AdressNumber = clientRegisterDto.Address.AdressNumber,
                        UF = clientRegisterDto.Address.UF
                    }
                });
                await _context.SaveChangesAsync();
            }
            catch (System.Exception)
            {
                throw;
            }
            return null;
        }

        
    }
}