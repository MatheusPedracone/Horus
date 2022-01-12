

namespace Horus.Models
{
    public class SystemEvent
    {
        public Guid Id { get; set; }
        public Guid EventId { get; set; }
        public Event Event { get; set; } 
        public long Count { get; set; } 
        public DateTime Date { get; set; }
        public Guid ClientId { get; set; }
        public Client Client { get; set; }
    }
}