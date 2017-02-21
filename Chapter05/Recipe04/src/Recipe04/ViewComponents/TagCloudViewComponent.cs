using AspNetCoreMvcRecipes.Shared.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Recipe04.Models;
using System.Collections.Generic;
using System.Linq;

namespace Recipe04.ViewComponents
{
    public class TagCloudViewComponent : ViewComponent
    {
        private readonly MoBContext _context;
        public TagCloudViewComponent(MoBContext dbcontext)
        {
            _context = dbcontext;
        }

        public IViewComponentResult Invoke()
        {
            var items = (from songs in _context.Songs
                         join genres in _context.GenreLookUps on songs.GenreId equals
                         genres.GenreLookUpId
                         where songs.GenreId.HasValue
                         select new { genres.GenreName, songs.GenreId }).ToList();

            var grouped = items.GroupBy(s => s.GenreName).Select(
            gen => new { Name = gen.Key, Count = gen.Count() });


            var model = new TagCloud();


            foreach (var item in grouped)
            {
                var cti = new TagCloudItem
                {
                    DisplayText = item.Name,
                    Url = string.Concat("/Genres/", item.Name),
                    Weight = item.Count
                };

                model.AddItem(cti);
            }
            return View(model);
        }
    }

}

