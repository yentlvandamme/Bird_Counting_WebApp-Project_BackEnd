using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BirdCounter.Models;

namespace BirdCounter.Repositories
{
    public class CountLogRepo : ICountLogRepo
    {
        public async Task<int> GeNumberOfLogsByBirdIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CountLog>> GetAllLogsAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<CountLog> GetLogByIdAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<int> GetNumberOfLogsByEventIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<int> GetNumberOfLogsByUserIdAsync(string id)
        {
            throw new NotImplementedException();
        }
    }
}
