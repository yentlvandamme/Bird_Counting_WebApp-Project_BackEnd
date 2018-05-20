using BirdCounting.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BirdCounting.Repositories
{
    public interface IEventRepo
    {
        List<Event> GetAllEvents();

        List<string> GetAllEventNames();

        int GetEventIdByEventName(string eventName);

        void Post(Event eventObj);
    }
}
