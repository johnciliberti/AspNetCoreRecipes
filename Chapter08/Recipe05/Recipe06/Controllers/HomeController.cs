using System;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreMvcRecipes.Shared.DataAccess;
using Recipe05.Models;
using Microsoft.AspNetCore.Http;

namespace Recipe05.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        // make sure you add the service descriptor to StartUp.cs 
        // ConfigureServices for this to work
        private IUnitOfWork _UnitOfWork;
        public HomeController(IUnitOfWork unitOfWork)
        {
            _UnitOfWork = unitOfWork;
        }

        public IActionResult GridViewReplacementWithInplaceEditing(int? Selected)
        {
            //hard code artistId for this example
            var skills = _UnitOfWork.ArtistSkillRepository.Query(a => a.ArtistId == 2);
            var model = new InlineEditingArtistSkillListModel()
            {
                ArtistSkillList = skills
            };
            if (Selected.HasValue)
            {
                model.SelectedRow = Selected.Value;
            }
            return View("GridViewReplacementWithInplaceEditing", model);
        }

        [HttpPost]
        public IActionResult GridViewReplacementWithInplaceEditing(FormCollection collection)
        {
            ArtistSkill skill = new ArtistSkill();
            skill.ArtistId = Int32.Parse(collection["item.ArtistId"]);
            skill.ArtistTalentId = Int32.Parse(collection["item.ArtistTalentID"]);
            skill.TalentName = collection["item.TalentName"];
            skill.SkillLevel = Int32.Parse(collection["item.SkillLevel"]);
            skill.Details = collection["item.Details"];
            skill.Styles = collection["item.Styles"];
            _UnitOfWork.ArtistSkillRepository.Update(skill);
            return RedirectToAction("GridViewReplacementWithInplaceEditing");
        }



        public IActionResult Error()
        {
            return View();
        }
    }
}
