using BirdCounting.Models;
using BirdCounting.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace BirdCounting.Services
{
    public class EventService : IEventService
    {
        private IEventRepo _eventRepo;

        public EventService(IEventRepo eventRepo)
        {
            this._eventRepo = eventRepo;
        }

        public List<Event> GetAllEvents()
        {
            return _eventRepo.GetAllEvents();
        }

        public List<string> GetAllEventNames()
        {
            return _eventRepo.GetAllEventNames();
        }

        public int GetEventIdByEventName(string eventName)
        {
            return _eventRepo.GetEventIdByEventName(eventName);
        }

        public void Post(Event eventObj)
        {
            _eventRepo.Post(eventObj);
        }
    }
}
