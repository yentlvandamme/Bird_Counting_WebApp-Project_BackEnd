using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BirdCounting.Models;
using BirdCounting.Repositories;
using BirdCounting.Services;
using BirdCounting.Web.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace BirdCounting.Web.Controllers
{
    public class BirdController : Controller
    {
        public IBirdService _birdService;

        public IEventService _eventService;

        public ICountLogService _countLogService;

        public BirdController(IBirdService birdService, IEventService eventService, ICountLogService countLogService)
        {
            this._birdService = birdService;
            this._eventService = eventService;
            this._countLogService = countLogService;
        }

        // GET: Bird
        public ActionResult Index()
        {
            CountPage_VM countPage_VM = new CountPage_VM();
            List<Bird> birdList = new List<Bird>();

            // Create list of all the birds
            countPage_VM.lstBirds = birdList = _birdService.GetAllBirds();

            // Create dictionary of all the birds with their counts
            Dictionary<string, string> CountValuesDict = new Dictionary<string, string>();

            foreach (Bird b in birdList)
            {
                // Add values to the dictionary
                int count = _countLogService.GetNumberOfCountsByBirdId(b.ID);
                CountValuesDict.Add(b.Name, count.ToString());
            }

            // Filling viewmodel with the dictionary
            countPage_VM.countValues = CountValuesDict;

            return View(countPage_VM);
        }

        // GET: Bird/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Bird/Create
        public ActionResult Create(int id)
        {
            PostCountPage_VM postCountPage_VM = new PostCountPage_VM();
            List<Event> eventLst = new List<Event>();
            List<Event> eventPastLst = new List<Event>();

            // Get bird by id
            postCountPage_VM.Bird = _birdService.GetBirdById(id);

            // Create selectlist
            var listItems = new List<SelectListItem>();
            foreach(string e in _eventService.GetAllEventNames())
            {
                if(e != null)
                {
                    listItems.Add(new SelectListItem { Text = e, Value = e.Trim() });   
                }
            }

            // Adding SelectList (dropdownlist) to the viewmodel
            postCountPage_VM.selectEvents = new SelectList(listItems, "Value", "Text") ;

            // Adding number of total spots
            postCountPage_VM.TotalSpots = _countLogService.GetNumberOfCountsByBirdId(id);

            // Adding number of personal spots
            //string UserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            //postCountPage_VM.PersonalSpots = _countLogService.GetNumberOfCountsByUserId(UserId, id);

            return View(postCountPage_VM);
        }

        // POST: Bird/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection, CountLog countLog)
        {
            try
            {
                // Getting values by key
                string eventName = collection["selectedEvent"];
                int birdID = Convert.ToInt32(collection["createdLog.BirdID"]);

                // Creating an object to POST
                CountLog count = new CountLog
                {
                    BirdID = birdID,
                    UserID = this.User.FindFirstValue(ClaimTypes.NameIdentifier),
                    EventID = _eventService.GetEventIdByEventName(eventName),
                    DateOfCount = DateTime.Now,
                    Comment = collection["createdLog.Comment"]
                };

                _countLogService.Post(count);

                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return View();
            }
        }

        // GET: Bird/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Bird/Edit/5
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

        // GET: Bird/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Bird/Delete/5
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