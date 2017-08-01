using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StarWarsTravelBlog.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace StarWarsTravelBlog.Controllers
{
    public class LocationsController : Controller
    {
        private StarWarsTravelBlogContext db = new StarWarsTravelBlogContext();
        public IActionResult Index()
        {
            return View(db.Locations.ToList());
        }
        public IActionResult Details(int id)
        {
            var thisLocation = db.Locations.FirstOrDefault(Locations => Locations.id == id);
            return View(thisLocation);
        }
    }
}
