using Horus.Data;
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

        public async Task<SystemEvent> SaveSystemEvents(SystemEvent model)
        {
            var systemEvent = _context.SystemEvents
                                                    .AsNoTracking()
                                                    .Where(e => e.Date == model.Date)
                                                    .FirstOrDefault();

            var clientCnpj = _context.Clients
                                            .AsNoTracking()
                                            .Where(c => c.Cnpj == model.Client.Cnpj)
                                            .Where(c => c.FantasyName == model.Client.FantasyName)
                                            .FirstOrDefault();

            var findClientEvent = await _context.Events
                                                    .AsNoTracking()
                                                    .Where(e => e.EventName == model.Event.EventName)
                                                    .FirstOrDefaultAsync();

            if (clientCnpj == null)
            {
                var newClient = new Client
                {
                    Cnpj = clientCnpj.Cnpj,
                    FantasyName = clientCnpj.FantasyName,
                };
                _context.Clients.Add(newClient);
                await _context.SaveChangesAsync();
            }

            if (findClientEvent != null)
            {
                systemEvent.Count = systemEvent.Count + model.Count;
                _context.SaveChanges();
            }

            try
            {
                clientCnpj.Id = systemEvent.ClientId;
                _context.SystemEvents.Add(model);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return null;
        }
    }
}