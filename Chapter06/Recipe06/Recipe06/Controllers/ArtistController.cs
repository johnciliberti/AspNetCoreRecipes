using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreMvcRecipes.Shared.DataAccess;

namespace Recipe06.Controllers
{
    public class ArtistController : Controller
    {
        private IUnitOfWork _unitOfWork = null;
        public ArtistController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            
            var artists = _unitOfWork.ArtistRepository.GetNewArtists();
            return View(artists);
        }

    }
}