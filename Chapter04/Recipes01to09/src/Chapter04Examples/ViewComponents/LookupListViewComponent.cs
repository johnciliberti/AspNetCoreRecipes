using System.Linq;
using AspNetCoreMvcRecipes.Shared.DataAccess;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;

namespace Chapter04.ViewComponents
{
    public class LookupListViewComponent : ViewComponent
    {
        private readonly MoBContext _dbContext;

        public LookupListViewComponent(MoBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IViewComponentResult Invoke()
        {
            var query = from a in _dbContext.GenreLookUps
                        select new SelectListItem
                        {
                            Text = a.GenreName,
                            Value = a.GenreLookUpId.ToString()
                        };

            return View(query.ToList());
        }
    }
}
