using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Horus.Models;
using Horus.Repository;

namespace Horus.Business.Implementations
{
    public class EventBusinessImplementation : IEventBusiness
    {
        private readonly IEventRepository _repository;
        public EventBusinessImplementation(IEventRepository repository)
        {
            _repository = repository;
        }
        public async Task<Event> AddEventsAsync(Event events)
        {
            return await _repository.AddEventsAsync(events);
        }
    }
}