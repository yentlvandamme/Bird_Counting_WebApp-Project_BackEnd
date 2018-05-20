using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace BirdCounting.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DateOfCreation { get; set; }

        // Navigation Properties
        public ICollection<CountLog> CountLogs { get; set; }

        public ICollection<Event> Events { get; set; }

        public ICollection<ErrorLog> ErrorLogs { get; set; }
    }
}
