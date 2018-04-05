using BirdCounter.Models._core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BirdCounter.Models
{
    public class ErrorLog : IEntity
    {
        [Key]
        public int ID { get; set; }

        public int UserID { get; set; }

        public string ErrorDescription { get; set; }

        public DateTime DateOfError { get; set; }
    }
}
