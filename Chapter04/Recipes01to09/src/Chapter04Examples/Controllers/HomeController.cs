using Microsoft.AspNetCore.Mvc;
using Chapter04.Models.Recipe03;
using Chapter04.Models.Recipe04;

namespace Chapter04.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Recipe01()
        {
            return View();
        }

        public IActionResult Recipe02()
        {
            return View();
        }

        public IActionResult Recipe03()
        {
            var model = new Contact { AllowContactAboutOffers = true };
            return View(model);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Recipe03(Contact model)
        {
            if (ModelState.IsValid)
            {
                return View("Recipe03Thanks", model);
            }
            return View(model);
        }

        public IActionResult Recipe04()
        {
            Tristate model = new Tristate { NullableBoolValue = null };
            return View(model);
        }

        [HttpPost]
        public IActionResult Recipe04(Tristate model)
        {
            return View(model);

        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
