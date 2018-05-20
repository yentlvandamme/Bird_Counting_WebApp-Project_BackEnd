using BirdCounting.Models;
using BirdCounting.Web.Data;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace BirdCounting.Repositories
{
    public class EventRepo : IEventRepo
    {
        private ApplicationDbContext _context;

        private string _connectionstring;

        public EventRepo(ApplicationDbContext context, IConfiguration configuration)
        {
            this._context = context;
            this._connectionstring = ConfigurationExtensions.GetConnectionString(configuration, "DefaultConnection");
        }

        public List<Event> GetAllEvents()
        {
            return _context.Events.OrderBy(e => e.Region).ToList();
        }

        public List<string> GetAllEventNames()
        {
            return _context.Events.Select(e => e.EventName)
                                  .Distinct()
                                  .ToList();
        }

        public int GetEventIdByEventName(string eventName)
        {
            return _context.Events.Where(e => e.EventName == eventName)
                                  .Select(e => e.ID)
                                  .Distinct()
                                  .SingleOrDefault();
        }

        public void Post(Event eventObj)
        {
            using (SqlConnection con = new SqlConnection(_connectionstring))
            {
                try
                {
                    string sql = "INSERT INTO Events(applicationUserId, regionID, eventName, startDate, endDate)";
                    sql += "VALUES(@applicationUserId, @regionID, @eventName, @startDate, @endDate)";

                    SqlCommand cmd = new SqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("@applicationUserId", eventObj.ApplicationUserId);
                    cmd.Parameters.AddWithValue("@regionID", eventObj.RegionID);
                    cmd.Parameters.AddWithValue("@eventName", eventObj.EventName);
                    cmd.Parameters.AddWithValue("@startDate", eventObj.StartDate);
                    cmd.Parameters.AddWithValue("@endDate", eventObj.EndDate);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}
