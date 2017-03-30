using Microsoft.AspNetCore.Mvc;
using Recipe04.Models;

namespace Recipe04.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(BandViewModel model)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("BandNameReserved");
            }
            return View("Index" , model);
        }

        public IActionResult BandNameReserved()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
