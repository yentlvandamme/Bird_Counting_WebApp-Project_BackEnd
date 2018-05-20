using BirdCounting.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdCounting.Web.ViewModels
{
    public class PostCountPage_VM
    {
        public Bird Bird { get; set; }

        public SelectList selectEvents { get; set; }

        public string selectedEvent { get; set; }

        public CountLog createdLog { get; set; }
    }
}
