using Microsoft.AspNetCore.Mvc;
using System;

namespace Chapter3.Recipe02
{
    /// <summary>
    /// Summary description for SomeAreaController
    /// </summary>
   [Area("FarFarAway")]
    public class ControllerInAreaController : Controller
    {
        
        public IActionResult InHappyLand()
        {
            ViewBag.Message = "Welcome to Far Far Away In Happy Land";

            return View();
        }
    }
}