using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Horus.Models
{
    public class Address
    {
        public Guid Guid { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MinLength(8, ErrorMessage = "O cep precisa ter no mínimo 8 caracteres")]
        [MaxLength(8, ErrorMessage = "O cep precisa ter no máximo 8 caracteres")]
        public string? ZipCode { get; set; } 

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MinLength(3, ErrorMessage = "A rua precisa ter no mínimo 8 caracteres")]
        [MaxLength(200, ErrorMessage = "O rua precisa ter no máximo 8 caracteres")]
        public string? Street { get; set; } 

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MinLength(3, ErrorMessage = "A cidade precisa ter no mínimo 3 caracteres")]
        [MaxLength(100, ErrorMessage = "A cidade precisa ter no máximo 100 caracteres")]
        public string? City { get; set; } 

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MinLength(3, ErrorMessage = "O bairro precisa ter no mínimo 8 caracteres")]
        [MaxLength(100, ErrorMessage = "O bairro precisa ter no máximo 8 caracteres")]
        public string? County { get; set; } 

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(100, ErrorMessage = "O número precisa ter no máximo 100 caracteres")]
        public int AdressNumber { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MinLength(2, ErrorMessage = "O UF precisa ter no mínimo 2 caracteres")]
        [MaxLength(2, ErrorMessage = "O UF precisa ter no máximo 2 caracteres")]
        public string? UF { get; set; } 
        public Guid ClientId { get; set; }
        public Client? Client { get; set; }

       
    }
}