using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Horus.Dtos
{
    public class AddressDto
    {
        
        public string ZipCode { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public int AdressNumber { get; set; }
        public string UF { get; set; }
    }
}