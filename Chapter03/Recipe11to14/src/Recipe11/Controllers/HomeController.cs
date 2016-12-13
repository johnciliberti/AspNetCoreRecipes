using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Recipe12.Models;

namespace Recipe11.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        #region Samples for Recipe 11
        public IActionResult StandardHtmlHelpers()
        {
            return View();
        }
        #endregion

        #region Samples for Recipe 12
        public IActionResult StronglyTypedHtmlHelpers()
        {
            return View();
        }

        [HttpPost]
        public IActionResult StronglyTypedHtmlHelpers(LoginViewModel model)
        {
            return View(model);
        }
        #endregion

        #region Samples for Recipe 13
        public IActionResult TemplatedHtmlHelpers(LoginViewModel model)
        {
            return View(model);
        }
        #endregion

        #region Samples for Recipe 14
        public IActionResult InlineFunction()
        {
            return View();
        }
        #endregion


        public IActionResult Error()
        {
            return View();
        }
    }
}
