using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BirdCounter.Models.Data
{
    public class BirdCounterDBContext : DbContext
    {
        // TODO: Solve the problem in the DBContext-file
        //public ConventionNSDBContext(DbContextOptions options) : base(options)
        //{
        //}

        public DbSet<User> Users { get; set; }

        public DbSet<Event> Events { get; set; }

        public DbSet<Region> Regions { get; set; }

        public DbSet<Bird> Birds { get; set; }

        public DbSet<CountLog> CountLogs { get; set; }

        public DbSet<ErrorLog> ErrorLogs { get; set; }
    }
}
