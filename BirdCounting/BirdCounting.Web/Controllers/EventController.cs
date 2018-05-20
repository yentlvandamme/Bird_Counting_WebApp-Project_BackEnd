using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using BirdCounting.Models;
using BirdCounting.Services;
using BirdCounting.Web.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BirdCounting.Web.Controllers
{
    public class EventController : Controller
    {
        private IRegionService _regionService;

        private IEventService _eventService;

        public EventController(IRegionService regionService, IEventService eventService)
        {
            this._regionService = regionService;
            this._eventService = eventService;
        }

        // GET: Event
        public ActionResult Index()
        {
            return View();
        }

        // GET: Event/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Event/Create
        public ActionResult Create()
        {
            AddEventPage_VM addEventPage_VM = new AddEventPage_VM();

            // Create selectlist
            var listItems = new List<SelectListItem>();
            foreach(string r in _regionService.GetAllRegionNames())
            {
                if(r != null)
                {
                    listItems.Add(new SelectListItem { Text = r, Value = r.Trim() });
                }
            }

            // Adding SelectList (dropdownlist) to the viewmodel
            addEventPage_VM.selectRegions = new SelectList(listItems, "Value", "Text");

            return View(addEventPage_VM);
        }

        // POST: Event/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                string region = collection["selectedRegion"];

                // Creating object
                Event createdEvent = new Event
                {
                    EventName = collection["Event.EventName"],
                    ApplicationUserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier),
                    RegionID = _regionService.GetRegionIdByRegionName(region),
                    StartDate = Convert.ToDateTime(collection["Event.StartDate"]),
                    EndDate = Convert.ToDateTime(collection["Event.EndDate"])
                };

                // Posting event
                _eventService.Post(createdEvent);

                return Redirect("../Bird/Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Event/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Event/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Event/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Event/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}