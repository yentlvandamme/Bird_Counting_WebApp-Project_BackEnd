using BirdCounter.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BirdCounter.Repositories
{
    public interface IErrorLogRepo
    {
        // Get all logs
        Task<IEnumerable<ErrorLog>> GetAllErrorLogsAsync();

        // Get log by ID
        Task<ErrorLog> GetErrorLogByIdAsync(int id);

        // Get logs by user ID
        Task<IEnumerable<ErrorLog>> GetAllErrorLogsByUserIdAsync(string id);

        // Get all logs between two dates
        Task<IEnumerable<ErrorLog>> GetAllErrorLogsBetweenDatesAsync(DateTime startDate, DateTime endDate);
    }
}
