using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BirdCounter.Models;
using Microsoft.AspNetCore.Identity;

namespace BirdCounter.Web.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfRegistration { get; set; }


        // Foreign key constraint
        public ICollection<CountLog> CountLog { get; set; }

        public ICollection<Event> Event { get; set; }
    }
}
