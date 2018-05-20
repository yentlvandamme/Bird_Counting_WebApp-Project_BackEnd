using BirdCounting.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BirdCounting.Services
{
    public interface ICountLogService
    {
        int GetNumberOfCountsByBirdId(int id);

        int GetNumberOfCountsByUserId(string id, int birdId);

        void Post(CountLog countLog);
    }
}
