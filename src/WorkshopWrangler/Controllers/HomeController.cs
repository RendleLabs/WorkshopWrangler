using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WorkshopWrangler.Data;
using WorkshopWrangler.ViewModels;

namespace WorkshopWrangler.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDates _dates;

        public HomeController(IDates dates)
        {
            _dates = dates;
        }

        public IActionResult Index()
        {
            var model = new HomePage
            {
                AvailableDates = _dates.GetAvailableDates().ToArray()
            };
            return View(model);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
