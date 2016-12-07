using Microsoft.AspNetCore.Mvc;
using System;

namespace Chapter3.Recipe02
{
    /// <summary>
    /// Summary description for AwayController
    /// </summary>
    public class AwayController : Controller
    {
        public IActionResult Somewhere()
        {
            ViewBag.Message = "This is a sample Website for something cool.";

            return View();
        }
    }
}