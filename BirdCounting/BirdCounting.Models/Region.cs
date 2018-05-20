using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BirdCounting.Models
{
    public class Region : IEntity
    {
        [Key]
        [ScaffoldColumn(false)]
        public int ID { get; set; }

        public string Place { get; set; }

        // Navigation Properties
        public ICollection<Event> Events { get; set; }
    }
}
