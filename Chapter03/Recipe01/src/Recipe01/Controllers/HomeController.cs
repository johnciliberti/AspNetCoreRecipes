using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Recipe01.Models;

namespace Recipe01.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Message = "This is a sample Website for something cool.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewBag.Message = "Have questions? Stuff not working? Email John";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public IActionResult ControlFlow()
        {
            var model = new Guitar();
            model.Brand = "Charvel";
            model.Model = "Metal Shedder";
            model.WhammyBarType = "Floyd Rose";
            model.Description = "Death to all but metal";
            model.Strings = new List<string> { "E", "A", "D", "G", "B", "E" };
            model.HasWhammyBar = true;
            return View(model);
        }

        public IActionResult Variables()
        {
            var model = new Guitar();
            model.Brand = "Gibson";
            model.Model = "Les Paul";
            model.Description = "<blink>Very cool guitar</blink>";
            model.Strings = new List<string> { "E", "A", "D", "G", "B", "E" };
            model.HasWhammyBar = false;
            return View(model);
        }

        public IActionResult Loops()
        {
            var model = new List<Guitar>();
            model.Add(new Guitar { Brand = "Fendor", Model = "Stat", HasWhammyBar = true });
            model.Add(new Guitar { Brand = "Gibson", Model = "Les Paul", HasWhammyBar = false });
            model.Add(new Guitar { Brand = "Charvel", Model = "Metal", HasWhammyBar = true });
            model.Add(new Guitar { Brand = "Fendor", Model = "Telecaster", HasWhammyBar = false });
            return View(model);
        }

        public IActionResult Helper()
        {
            var model = new Guitar();
            model.Brand = "Gibson";
            model.Model = "Les Paul";
            model.HasWhammyBar = false;
            return View(model);
        }

        [HttpPost]
        public IActionResult Helper(Guitar model)
        {
            if (ModelState.IsValid)
            {
                return View("GuitarSaved", model);
            }
            return View(model);
        }

        public IActionResult CodeBlocks()
        {
            return View();
        }

        public IActionResult CodeNuggets()
        {
            var model = new Product();
            model.ProductId = 123;
            return View(model);
        }

        public IActionResult ExplicitMarkup()
        {
            var model = new Guitar { Brand = "Gibson", Model = "Les Paul", Strings = new List<string> { "E", "A", "D", "G", "B", "E" } };

            return View(model);
        }

        public IActionResult Comments()
        {
            return View();
        }
    }
}
