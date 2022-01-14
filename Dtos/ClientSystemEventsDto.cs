using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Horus.Dtos
{
    public class ClientSystemEventsDto
    {
        public string FantasyName { get; set; }
        public string Cnpj { get; set; }
        public List<SystemEventDto> Events { get; set; }
    }
}