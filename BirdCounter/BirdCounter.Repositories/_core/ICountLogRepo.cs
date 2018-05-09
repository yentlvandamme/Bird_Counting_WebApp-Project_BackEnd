using BirdCounter.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BirdCounter.Repositories
{
    interface ICountLogRepo
    {
        // Get all logs
        Task<IEnumerable<CountLog>> GetAllLogsAsync();

        // Get log by ID
        Task<CountLog> GetLogByIdAsync();

        // Get number of logs by UserID
        //Task<IEnumerable<CountLog>> GetAllLogsByUserIdAsync(string id);
        Task<int> GetNumberOfLogsByUserIdAsync(string id);

        // Get number of logs by BirdID
        //Task<IEnumerable<CountLog>> GetAllLogsByBirdIdAsync(int id);
        Task<int> GeNumberOfLogsByBirdIdAsync(int id);

        // Get number of logs by EventID
        //Task<IEnumerable<CountLog>> GetAllLogsByEventIdAsync(int id);
        Task<int> GetNumberOfLogsByEventIdAsync(int id);
    }
}
