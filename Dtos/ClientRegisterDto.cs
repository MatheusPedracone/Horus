using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Horus.Models;

namespace Horus.Dtos
{
    public class ClientRegisterDto
    {
        public string Name { get; set; }
        public string FantasyName { get; set; }
        public string Cnpj { get; set; }
        public string ContributorType { get; set; }
        public string Cellphone { get; set; }
        public string Email { get; set; }
        public AddressDto Address{ get; set; }
    }
}