using Microsoft.AspNetCore.Mvc;
using Recipe02.Models;

namespace Recipe02.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new SoftwareLicenceAgreementModel() { SoftwareProductName = "Some really Great Software"};
            return View("Index", model);
        }
        [HttpPost]
        public IActionResult Index(SoftwareLicenceAgreementModel model)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Download");
            }
            return View("Index", model);
        }

        public IActionResult Download()
        {
            return View("Download");
        }



        public IActionResult Error()
        {
            return View();
        }
    }
}
