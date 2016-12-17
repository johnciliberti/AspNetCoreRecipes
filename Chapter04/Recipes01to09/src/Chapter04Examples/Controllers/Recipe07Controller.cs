using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreMvcRecipes.Shared.DataAccess;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;

namespace Chapter04.Controllers
{
    

    public class Recipe07Controller : Controller
    {
        private readonly MoBContext _db;
        public Recipe07Controller(MoBContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var query = from a in _db.GenreLookUps
                        select new SelectListItem
                        {
                            Text = a.GenreName,
                            Value = a.GenreLookUpId.ToString()
                        };

            return View(query.ToList());

        }
    }
}
