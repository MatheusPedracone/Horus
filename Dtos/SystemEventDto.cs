using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Horus.Dtos
{
    public class SystemEventDto
    {
        public string Event { get; set; }
        public long Count { get; set; }
        public DateTime Date { get; set; }
    }
}