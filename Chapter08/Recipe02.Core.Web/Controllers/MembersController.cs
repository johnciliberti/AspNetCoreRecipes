using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using AspNetCoreMvcRecipes.Shared.DataAccess;

namespace Recipe02.Core.Web.Controllers
{
    [Authorize(Roles = "Members")]
    public class MembersController : Controller
    {
        private IUnitOfWork _unitOfWork;
        public MembersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult MyCollaborationSpaces()
        {
            var id = 1784;
            var model = _unitOfWork.CollaborationSpaceRepository.GetCollaborationSpacesForArtist(id);

            return View("MyCollaborationSpaces", model);
        }

    }
}