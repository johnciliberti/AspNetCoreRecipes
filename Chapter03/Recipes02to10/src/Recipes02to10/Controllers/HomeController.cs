using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Chapter3.Recipe02to10.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        
        public IActionResult Secure()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult Cart()
        {
            return View();
        }
        public IActionResult Alerts()
        {
            return View();
        }

        public IActionResult Storage()
        {
            return View();
        }
    }
}