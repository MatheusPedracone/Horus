using Horus.Data;
using Horus.Models;

namespace Horus.Repository.Implementations
{
    public class EventRepositoryImplementation : IEventRepository
    {
        private readonly DataContext _context;
        public EventRepositoryImplementation(DataContext context)
        {
            _context = context;
        }
        public async Task<Event> AddEvents(Event events)
        {
            try
            {
                var newEvent = _context.Events.Add(events);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return events;
        }
    }
}