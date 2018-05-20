using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BirdCounting.Models
{
    public class Bird : IEntity
    {
        [Key]
        [ScaffoldColumn(false)]
        public int ID { get ; set; }

        public string Name { get; set; }

        [ScaffoldColumn(false)]
        public string ImageUrl {
            get
            {
                return "/images/" + this.Name.Replace(" ", "").ToLower() + ".jpg";
            }
        }

        // Navigation Properties
        public ICollection<CountLog> CountLogs { get; set; }
    }
}
