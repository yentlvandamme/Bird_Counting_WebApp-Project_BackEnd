using BirdCounter.Models._core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BirdCounter.Models
{
    public class CountLog : IEntity
    {
        [Key]
        public int ID { get; set; }

        public int BirdID { get; set; }

        public int UserID { get; set; }

        public int EventID { get; set; }

        public DateTime DateOfCount { get; set; }

        public string Comment { get; set; }
    }
}
