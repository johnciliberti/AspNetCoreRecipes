using Chapter01.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Chapter01.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // maps to About.chtml
        // the view location logic will use refection to get
        // the action name and then use it to find a matching view
        // this version is more difficult to unit test
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View("about");
        }

        // also will map to About.chtml since we pass view name as an argument
        public IActionResult About2()
        {
            ViewData["Message"] = "Your application description page.";

            return View("about");
        }

        // This one maps to OtherView.chtml
        // the string in the argument gives the name of the view
        // since OtherView.chtml does not exist an error will occure at runtime
        public IActionResult About3()
        {
            ViewData["Message"] = "Your application description page.";

            return View("otherView");
        }
        public IActionResult IHaveNoView()
        {
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult GuitarCase()
        {
            var model = new GuitarCaseModel();
            model.Cables = new List<GuitarCable> { new GuitarCable { Brand = "ACME", Length = 12 } };
            model.MyGuitar = new Guitar { BodyStyle = "Strat", Brand = "Fendor", Finish = "White" };
            return View(model);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
