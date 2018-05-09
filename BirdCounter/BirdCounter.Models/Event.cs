using BirdCounter.Models._core;
using BirdCounter.Web.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BirdCounter.Models
{
    public class Event : IEntity
    {
        [Key]
        public int ID { get; set; }

        public int UserID { get; set; }

        public int RegionID { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }


        // Foreign key constraint
        public ICollection<CountLog> CountLog { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        public Region Region { get; set; }
    }
}
