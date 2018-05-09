using BirdCounter.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BirdCounter.Repositories
{
    public interface IEventRepo
    {
        // Get all events
        Task<IEnumerable<Event>> GetAllEventsAsync();

        // Get event by ID
        Task<Event> GetEventByIdAsync(int id);

        // Get all events by region ID
        Task<IEnumerable<Event>> GetAllEventsByRegionIdAsync(int id);

        // Get all events by startdate
        Task<IEnumerable<Event>> GetAllEventsByStartDateAsync(DateTime startDate);

        // Get all events by enddate
        Task<IEnumerable<Event>> GetAllEventsByEndDateAsync(DateTime endDate);

        // Get all events by user ID
        Task<IEnumerable<Event>> GetAllEventsByUserIdAsync(string id);
    }
}
