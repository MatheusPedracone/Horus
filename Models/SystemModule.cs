
namespace Horus.Models
{
    public class SystemModule
    {
        public Guid Id { get; set; }
        public Guid ModuleId { get; set; }
        public Module Module { get; set; }
        public long Count { get; set; }
        public DateTime Date { get; set; }
        public Guid ClientId { get; set; }
        public Client Client { get; set; }
    }
}