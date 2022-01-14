using Horus.Models;

namespace Horus.Repository
{
    public interface ISystemEventRepository
    {
        Task<SystemEvent> SaveSystemEvents(SystemEvent model);
    }
}