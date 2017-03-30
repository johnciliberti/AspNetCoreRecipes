using Microsoft.AspNetCore.Mvc;
using Chapter07.Web.Strings;

namespace Chapter07.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }

        public IActionResult About()
        {
            ViewData[HomeStrings.ViewDataMessage] = HomeStrings.AboutMessage;

            return View("About");
        }

        public IActionResult Contact()
        {
            ViewData[HomeStrings.ViewDataMessage] = HomeStrings.ContactMessage;

            return View("Contact");
        }

        public IActionResult Error()
        {
            return View("Error");
        }
    }
}
