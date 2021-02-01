using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstResponsiveWebAppWoodburn.Models;

namespace FirstResponsiveWebAppWoodburn.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Age = 0;
            ViewBag.AgeAtEndOfYear = 0;
            ViewBag.Name = "";
            return View();
        }
        [HttpPost]
        public IActionResult Index(AgeModel model)
        {
            if (ModelState.IsValid)  // Check valid state
            {
                ViewBag.Age = model.AgeThisYear();  // Call AgeThisYear() function and assign
                ViewBag.AgeAtEndOfYear = model.AgeByEndOfYear();  // Call AgeByEndOfYear() function and assign
                ViewBag.Name = model.Name;  // Assign name
            }
            else // Assign defaults
            {
                ViewBag.Age = 0;
                ViewBag.AgeAtEndOfYear = 0;
                ViewBag.Name = "";
            }
            return View(model); 
        }
    }
}
