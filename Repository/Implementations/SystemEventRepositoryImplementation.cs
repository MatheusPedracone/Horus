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
            var client = _context.Clients.FirstOrDefault(); 

            var findClientEvent = await _context.Events
                                                    .AsNoTracking()
                                                    .Where(e => e.EventName == model.Event.EventName)
                                                    .FirstOrDefaultAsync();
                                    
            // if (findClientEvent != null)
            // {
            //     return null;
            // }

            try
            {
                client.Id = model.ClientId;
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