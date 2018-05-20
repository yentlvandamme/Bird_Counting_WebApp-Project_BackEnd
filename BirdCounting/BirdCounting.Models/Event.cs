using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BirdCounting.Models
{
    public class Event : IEntity
    {
        [Key]
        [ScaffoldColumn(false)]
        public int ID { get; set; }

        [ScaffoldColumn(false)]
        public string ApplicationUserId { get; set; }

        [ScaffoldColumn(false)]
        public int RegionID { get; set; }

        public string EventName { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        // Navigation Properties
        public ICollection<CountLog> CountLogs { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        public Region Region { get; set; }
    }
}
