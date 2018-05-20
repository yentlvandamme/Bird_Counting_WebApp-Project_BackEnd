using BirdCounting.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdCounting.Web.ViewModels
{
    public class AddEventPage_VM
    {
        public Event Event { get; set; }

        public SelectList selectRegions { get; set; }
    }
}
