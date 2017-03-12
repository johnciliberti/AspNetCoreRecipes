using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Recipe02.DataAccess.Entities;
using Recipe02.DataAccess.Repository;

namespace Recipe02.Core.Web.Controllers
{
    public class HomeController : Controller
    {
        private IGuitarRepository _guitarRepository;
        public HomeController(IGuitarRepository guitarRepository)
        {
            _guitarRepository = guitarRepository;
        }

        public IActionResult Index()
        {
            var guitarList = _guitarRepository.GetAllGuitars();

            return View("Index", guitarList);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
