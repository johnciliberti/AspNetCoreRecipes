using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Recipes01to09.Areas.FarFarAway.Controllers
{
    public class ControllerInAreaController : Controller
    {
        [Area("FarFarAway")]
        public IActionResult InHappyLand()
        {
            ViewBag.Message = "Welcome to Far Far Away In Happy Land";

            return View();
        }
    }
}
