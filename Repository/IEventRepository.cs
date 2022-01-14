
using Horus.Models;

namespace Horus.Repository
{
    public interface IEventRepository
    {
        Task<Event> AddEventsAsync(Event model);
    }
}
