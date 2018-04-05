using BirdCounter.Models._core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BirdCounter.Models
{
    public class Region : IEntity
    {
        [Key]
        public int ID { get; set; }

        public string Place { get; set; }
    }
}
