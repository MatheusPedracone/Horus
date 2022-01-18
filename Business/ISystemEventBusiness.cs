
using Horus.Dtos;


namespace Horus.Business
{
    public interface ISystemEventBusiness
    {
        Task<ClientSystemEventsDto> SaveSystemEventsAsync(ClientSystemEventsDto clientSystemEventsDto);
    }
}