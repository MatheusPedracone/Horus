using Horus.Dtos;
using Horus.Models;

namespace Horus.Repository
{
    public interface ISystemEventRepository
    {
        Task<ClientSystemEventsDto> SaveSystemEvents(ClientSystemEventsDto clientSystemEventsDto);
    }
}