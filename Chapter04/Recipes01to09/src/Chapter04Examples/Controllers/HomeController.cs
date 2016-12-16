using Chapter04.Models.Recipe03;
using Chapter04.Models.Recipe04;
using Chapter04.Models.Recipe05;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace Chapter04.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Recipe01()
        {
            return View();
        }

        public IActionResult Recipe02()
        {
            return View();
        }

        #region Recipe 3
        public IActionResult Recipe03()
        {
            var model = new Contact { AllowContactAboutOffers = true };
            return View(model);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Recipe03(Contact model)
        {
            if (ModelState.IsValid)
            {
                return View("Recipe03Thanks", model);
            }
            return View(model);
        }
        #endregion

        #region Recipe 4
        public IActionResult Recipe04()
        {
            Tristate model = new Tristate { NullableBoolValue = null };
            return View(model);
        }

        [HttpPost]
        public IActionResult Recipe04(Tristate model)
        {
            return View(model);

        }
        #endregion

        #region Recipe 5
        private List<SelectListItem> _items = new List<SelectListItem>
        {
           new SelectListItem { Value="", Text="Please Select a Brand"},
           new SelectListItem { Value="1", Text="Gibson" },
           new SelectListItem { Value="2", Text="Charvel" },
           new SelectListItem { Value="3", Text="Ibenez" },
           new SelectListItem { Value="4", Text="Jackson"  }
        };

        public IActionResult Recipe05()
        {
            var model = new GuitarBrandViewModel { Brands=_items};
            return View(model);
        }

        [HttpPost]
        public IActionResult Recipe05(GuitarBrandViewModel model)
        {
            model.Brands = _items;
            if (model.SelectedBrandId != 0)
            {
                model.SelectedBrand = (from b in _items
                                       where b.Value == model.SelectedBrandId.ToString()
                                       select new GuitarBrand
                                       {
                                           GuitarBrandId = int.Parse(b.Value),
                                           Name = b.Text
                                       }).FirstOrDefault();

            }

            return View(model);
        }

        #endregion

        public IActionResult Error()
        {
            return View();
        }
    }
}
