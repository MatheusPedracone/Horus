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

        public Task<SystemEvent> AddSystemEvent(Guid clientId, SystemEvent systemEvents)
        {
            throw new NotImplementedException();
        }

        public async Task<SystemEvent[]> SaveSystemEvents(Guid clientId, SystemEvent[] systemEvents)
        {
            try
            {
                var getClientSystemEvents = _context.SystemEvents.Where(se => se.ClientId == clientId).ToArrayAsync();
                if (getClientSystemEvents == null) return null;

                foreach (var systemEvent in systemEvents)
                {
                    //crio
                    if (systemEvent.Id == null)
                    {
                        _context.Add(systemEvents);
                        await _context.SaveChangesAsync();
                    }
                    //faço a referência
                    else
                    {
                         
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}