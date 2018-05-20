using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BirdCounting.Models
{
    public class ErrorLog : IEntity
    {
        [Key]
        [ScaffoldColumn(false)]
        public int ID { get; set; }

        [ScaffoldColumn(false)]
        public string UserID { get; set; }

        public string ErrorDescription { get; set; }

        public DateTime DateOfError { get; set; }

        // Navigation Properties
        public ApplicationUser applicationUser { get; set; }
    }
}
