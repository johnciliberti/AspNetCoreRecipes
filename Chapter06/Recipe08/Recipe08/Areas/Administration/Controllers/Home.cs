using Microsoft.AspNetCore.Mvc;

namespace Recipe08.Areas.Administration.Controllers
{
    [Area("Administration")]
    public class Home : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}