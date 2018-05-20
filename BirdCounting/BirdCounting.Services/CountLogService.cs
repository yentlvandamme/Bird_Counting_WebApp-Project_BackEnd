using BirdCounting.Models;
using BirdCounting.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace BirdCounting.Services
{
    public class CountLogService : ICountLogService
    {
        private ICountLogRepo _countLogRepo;

        public CountLogService(ICountLogRepo countLogRepo)
        {
            this._countLogRepo = countLogRepo;
        }

        public int GetNumberOfCountsByBirdId(int id)
        {
            return _countLogRepo.GetNumberOfCountsByBirdId(id);
        }

        public int GetNumberOfCountsByUserId(string id, int birdId)
        {
            return _countLogRepo.GetNumberOfCountsByUserId(id, birdId);
        }

        public void Post(CountLog countLog)
        {
            _countLogRepo.Post(countLog);
        }
    }
}
