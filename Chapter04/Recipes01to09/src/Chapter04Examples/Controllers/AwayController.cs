using Microsoft.AspNetCore.Mvc;


namespace Recipes01to09.Controllers
{
    public class AwayController : Controller
    {
        public IActionResult Somewhere()
        {
            ViewBag.Message = "This is a sample Website for something cool.";

            return View();
        }
    }
}
