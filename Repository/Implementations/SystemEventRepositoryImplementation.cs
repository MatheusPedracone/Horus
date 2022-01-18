using Horus.Data;
using Horus.Dtos;
using Horus.Models;
using Microsoft.EntityFrameworkCore;

namespace Horus.Repository.Implementations
{
    public class SystemEventRepositoryImplementation : ISystemEventRepository
    {
        private readonly DataContext _context;
        public SystemEventRepositoryImplementation(DataContext context)
        {
            _context = context;
        }

        public async Task<ClientSystemEventsDto> SaveSystemEvents(ClientSystemEventsDto clientSystemEventsDto)
        {
            var clientCnpj = _context.Clients
                                            .Include(c => c.SystemEvents)
                                            .Where(c => c.Cnpj == clientSystemEventsDto.Cnpj)
                                            .FirstOrDefault();

            if (clientCnpj == default)
            {
                var newClient = new Client
                {
                    Cnpj = clientSystemEventsDto.Cnpj,
                    FantasyName = clientSystemEventsDto.FantasyName,
                };
                _context.Clients.Add(newClient);
                await _context.SaveChangesAsync();
                clientCnpj = newClient;
            }

            if (clientSystemEventsDto.Events.Any())
            {
                foreach (var events in clientSystemEventsDto.Events)
                {
                    var eventEntity = _context.Events.FirstOrDefault(e => e.EventName == events.EventName);
                    if (eventEntity == default)
                    {
                        var newEvent = new Event();
                        newEvent.EventName = events.EventName;
                        await _context.Events.AddAsync(newEvent);
                        await _context.SaveChangesAsync();
                        eventEntity = newEvent;
                    }

                    var clientSystemEvent = clientCnpj.SystemEvents.FirstOrDefault(s => s.EventId == eventEntity.Id);

                    if (clientSystemEvent != default)
                    {
                        clientSystemEvent.Count += events.Count;
                        // clientSystemEvent.Count = clientSystemEvent.Count + events.Count;
                    }
                    else
                    {
                        var newSystemEvent = new SystemEvent();
                        newSystemEvent.EventId = eventEntity.Id;
                        newSystemEvent.Count = events.Count;
                        clientCnpj.SystemEvents.Add(newSystemEvent);
                        await _context.SaveChangesAsync();
                    }
                }
            }
            return null;
        }
    }
}