using Microsoft.AspNetCore.Mvc;
using AspNetCoreMvcRecipes.Shared.DataAccess;

namespace Recipe04.Web.Controllers
{
    public class HomeController : Controller
    {
        IUnitOfWork _UnitOfWork;
        public HomeController(IUnitOfWork unitOfWork)
        {
            _UnitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            var model = _UnitOfWork.ArtistRepository.GetNewArtists();
            return View("Index", model);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
