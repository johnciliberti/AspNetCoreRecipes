using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreMvcRecipes.Shared.DataAccess;


namespace Chapter07.Web.Controllers
{
    public class ArtistAdminController : Controller
    {

        private IUnitOfWork _DataAccessLayer;

        public ArtistAdminController(IUnitOfWork dataAccessLayer)
        {
            _DataAccessLayer = dataAccessLayer;
        }
        // GET: /<controller>/
        public IActionResult List()
        {
            return View("List");
        }

        public IActionResult Review()
        {
            return View("Review");
        }

        public IActionResult DeleteConfirm()
        {
            return View("DeleteConfirm");
        }

        public IActionResult DeleteCompleted()
        {
            return View("DeleteCompleted");
        }

        public IActionResult DeleteFailed()
        {
            return View("DeleteFailed");
        }
    }
}
