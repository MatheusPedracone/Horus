using Horus.Models;

namespace Horus.Repository
{
    public interface ISystemEventRepository
    {
        Task<SystemEvent> AddSystemEvent(Guid clientId, SystemEvent systemEvents);
        Task<SystemEvent> SaveSystemEvents(Guid clientId, SystemEvent[] systemEvents);
    }
}