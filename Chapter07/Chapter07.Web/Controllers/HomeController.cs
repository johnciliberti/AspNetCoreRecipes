using Microsoft.AspNetCore.Mvc;
using Chapter07.Web.Strings;

namespace Chapter07.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(HomeStrings.IndexView);
        }

        public IActionResult About()
        {
            ViewData[HomeStrings.ViewDataMessageKey] = HomeStrings.AboutMessage;

            return View(HomeStrings.AboutView);
        }

        public IActionResult Contact()
        {
            ViewData[HomeStrings.ViewDataMessageKey] = HomeStrings.ContactMessage;

            return View(HomeStrings.ContactView);
        }

        public IActionResult Error()
        {
            return View(HomeStrings.ErrorView);
        }
    }
}
