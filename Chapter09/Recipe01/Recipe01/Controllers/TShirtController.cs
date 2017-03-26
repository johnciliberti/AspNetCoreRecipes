using Microsoft.AspNetCore.Mvc;
using Recipe01.ViewModels;

namespace Recipe01.Controllers
{
    public class TShirtController : Controller
    {

        // GET: TShirt/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: TShirt/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TShirtViewModel viewModel)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("CreateSuccess", viewModel);
            }
            
             return View("Create", viewModel);
            
        }

        public IActionResult CreateSuccess(TShirtViewModel viewModel)
        {
            return View("CreateSuccess", viewModel);
        }

      
    }
}