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
        public async Task<Event> AddEventsAsync(Event model)
        {
            try
            {
                var newEvent = _context.Events.Add(model);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return model;
        }
    }
}