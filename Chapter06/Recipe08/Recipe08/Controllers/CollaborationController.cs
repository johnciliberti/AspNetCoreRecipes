using Microsoft.AspNetCore.Mvc;

namespace Recipe08.Controllers
{
    [Area("Collaboration")]
    public class CollaborationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
