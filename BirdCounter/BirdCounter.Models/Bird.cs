using BirdCounter.Models._core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BirdCounter.Models
{
    public class Bird : IEntity
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }

        public string ImageUrl { get; set; }
    }
}
