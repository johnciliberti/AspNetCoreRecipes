using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Recipe05.ViewModels;
using Recipe05.Models;

namespace Recipe05.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new GuitarBuilderViewModel { Guitar = new Guitar { Name = "My New Guitar" } };
            return View("Index", model);
        }

        [HttpPost]
        public async Task<IActionResult> Index(GuitarBuilderViewModel model)
        {
            var adapter = new GuitarBuilderToGuitarAdapter();
            model.Guitar = adapter.BuildGuitar(model);
            await TryUpdateModelAsync(model.Guitar);
            if (ModelState.IsValid)
            {
                return RedirectToAction("OrderRecieved");
            }
            return View("Index", model);
        }
        public IActionResult OrderRecieved()
        {
            return View("OrderRecieved");
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}
