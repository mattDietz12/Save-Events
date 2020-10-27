using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using FlashFlyers.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace FlashFlyers.Controllers
{
    public class SaveEventsController : Controller
    {
        private const bool EventSaved = true;
     
        private readonly StandardModel _standardDbContext;

        public SaveEventsController(StandardModel standardDbContext)
        {
            _standardDbContext = standardDbContext;
        }

        public IActionResult Index()
        {
            return View(_standardDbContext.Events);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost] 
        public IActionResult SavedEvent(int id)
        {
            var saveEvnt = _standardDbContext.Events.Where(x => x.Id == id).FirstOrDefault();
            saveEvnt.Saved = EventSaved;
            
            /*
            saveEvnt.Title = Event.Title;
            saveEvnt.Description = Event.Description;
            saveEvnt.FileName = Event.FileName;
            saveEvnt.Date = Event.Building;
            saveEvnt.Time = Event.Date;
            saveEvnt.Building = Event.Time;
            saveEvnt.Room = Event.Room;
            saveEvnt.Campus = Event.Campus;
            */

            _standardDbContext.SaveChanges();
            _standardDbContext.Dispose();
            return RedirectToAction("Index");
        }
    }
}
