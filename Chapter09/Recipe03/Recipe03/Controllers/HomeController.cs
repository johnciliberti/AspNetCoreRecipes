using Microsoft.AspNetCore.Mvc;
using Recipe03.Models;

namespace Recipe03.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(HotelReservation model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("ReservationSuccess");
            }
            return View("Index", model);
        }

        public IActionResult ReservationSucess()
        {
            return View("ReservationSucess");
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
