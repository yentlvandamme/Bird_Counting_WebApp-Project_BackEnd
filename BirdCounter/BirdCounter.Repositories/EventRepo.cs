using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BirdCounter.Models;

namespace BirdCounter.Repositories
{
    public class EventRepo : IEventRepo
    {
        public async Task<IEnumerable<Event>> GetAllEventsAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Event>> GetAllEventsByEndDateAsync(DateTime endDate)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Event>> GetAllEventsByRegionIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Event>> GetAllEventsByStartDateAsync(DateTime startDate)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Event>> GetAllEventsByUserIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<Event> GetEventByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
