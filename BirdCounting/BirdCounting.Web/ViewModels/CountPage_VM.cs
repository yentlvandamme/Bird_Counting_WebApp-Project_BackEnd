using BirdCounting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdCounting.Web.ViewModels
{
    public class CountPage_VM
    {
        public List<Bird> lstBirds { get; set; }
        
        public Dictionary<string, string> countValues { get; set; }
    }
}
