using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Horus.Models
{
    public class Client
    {
        public Guid Guid { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MinLength(3, ErrorMessage = "O nome precisa ter no mínimo 3 caracteres")]
        [MaxLength(200, ErrorMessage = "O nome precisa ter no máximo 200 caracteres")]
        public string? Name { get; set; } 

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MinLength(14, ErrorMessage = "O Cnpj  precisa ter no mínimo 14 caracteres")]
        [MaxLength(14, ErrorMessage = "O Cnpj precisa ter no máximo 14 caracteres")]
        public string? Cnpj { get; set; } 

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string? ContributorType { get; set; } 

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MinLength(11, ErrorMessage = "O celular precisa ter no mínimo 11 caracteres")]
        [MaxLength(11, ErrorMessage = "O celular precisa ter no máximo 11 caracteres")]
        public string? Cellphone { get; set; } 

        [EmailAddress(ErrorMessage = "Este campo precisa ser um email válido")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string? Email { get; set; } 
        public Address? Address { get; set; }
        public List<SystemModule>? SystemModules { get; set; }
        public List<SystemEvent>? SystemEvents { get; set; }

         
    }
}