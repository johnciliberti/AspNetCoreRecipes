using AspNetCoreMvcRecipes.Shared.DataAccess;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Recipe04.Web.ViewComponents
{
    public class ArtistCardViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(Artist artist)
        {
            return View(artist);
        }

    }
}
