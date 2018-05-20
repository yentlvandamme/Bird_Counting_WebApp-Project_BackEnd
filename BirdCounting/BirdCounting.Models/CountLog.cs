using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BirdCounting.Models
{
    public class CountLog : IEntity
    {
        [Key]
        [ScaffoldColumn(false)]
        public int ID { get; set; }

        [ScaffoldColumn(false)]
        public int BirdID { get; set; }

        [ScaffoldColumn(false)]
        public string UserID { get; set; }

        [ScaffoldColumn(false)]
        public int EventID { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DateOfCount { get; set; }

        public string Comment { get; set; }

        // Navigation Properties
        public Bird Bird { get; set; }

        public ApplicationUser applicationUser { get; set; }

        public Event Event { get; set; }
    }
}
