using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BirdCounter.Models;

namespace BirdCounter.Repositories
{
    public class ErrorLogRepo : IErrorLogRepo
    {
        public async Task<IEnumerable<ErrorLog>> GetAllErrorLogsAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ErrorLog>> GetAllErrorLogsBetweenDatesAsync(DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ErrorLog>> GetAllErrorLogsByUserIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<ErrorLog> GetErrorLogByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
