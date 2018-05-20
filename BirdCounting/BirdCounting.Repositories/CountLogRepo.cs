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
    public class CountLogRepo : ICountLogRepo
    {
        private ApplicationDbContext _context;

        private string _connectionstring;

        public CountLogRepo(ApplicationDbContext context, IConfiguration configuration)
        {
            this._context = context;
            this._connectionstring = ConfigurationExtensions.GetConnectionString(configuration, "DefaultConnection");
        }

        public int GetNumberOfCountsByBirdId(int id)
        {
            return _context.CountLogs.Where(b => b.BirdID == id).Count();
        }

        public int GetNumberOfCountsByUserId(string id, int birdId)
        {
            return _context.CountLogs.Where(b => b.BirdID == birdId).Where(b => b.applicationUser.Id == id).Count();
        }

        public void Post(CountLog countLog)
        {
            using(SqlConnection con = new SqlConnection(_connectionstring))
            {
                try
                {
                    string sql = "INSERT INTO CountLogs(birdID, applicationUserId, eventID, dateOfCount, comment)";
                    sql += "VALUES(@birdID, @applicationUserId, @eventID, @dateOfCount, @comment)";

                    SqlCommand cmd = new SqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("@birdID", countLog.BirdID);
                    cmd.Parameters.AddWithValue("@applicationUserId", countLog.UserID);
                    cmd.Parameters.AddWithValue("@eventID", countLog.EventID);
                    cmd.Parameters.AddWithValue("@dateOfCount", countLog.DateOfCount);
                    cmd.Parameters.AddWithValue("@comment", countLog.Comment);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                catch(Exception ex)
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
