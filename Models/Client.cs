using System;
using System.ComponentModel.DataAnnotations;

namespace Horus.Models
{
    public class Client
    {
        [Key]
        public Guid Guid { get; set; }

        public string? Name { get; set; }

        public string? Cnpj { get; set; }

        public string? ContributorType { get; set; }

        public string? Cellphone { get; set; }
        public string? Email { get; set; }
        public Address? Address { get; set; }
        public List<SystemModule>? SystemModules { get; set; }
        public List<SystemEvent>? SystemEvents { get; set; }
    }
}