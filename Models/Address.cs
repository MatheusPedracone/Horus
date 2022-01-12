
namespace Horus.Models
{
    public class Address
    { 
        public Guid Id { get; set; }
        public string ZipCode { get; set; } 
        public string Street { get; set; } 
        public string City { get; set; } 
        public string County { get; set; } 
        public int AdressNumber { get; set; }
        public string UF { get; set; } 
        public Guid ClientId { get; set; }
        public Client Client { get; set; }
    }
}