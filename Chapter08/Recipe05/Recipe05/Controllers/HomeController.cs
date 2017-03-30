using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreMvcRecipes.Shared.DataAccess;
using Recipe05.Models;
using AspNetCoreMvcRecipes.Shared.DataAccess.Facade;

namespace Recipe05.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(IUnitOfWork unitOfWork)
        {
            _UnitOfWork = unitOfWork;
        }
        private IUnitOfWork _UnitOfWork;

        [Route("/{Page?}/{SortExpression?}/{Genres?}")]
        public IActionResult Index(int? Page,
                                        string SortExpression,
                                        bool? Accending,
                                        List<int> Genres)
        {
            //Set default values for all optional  parameters
            var safePage = Page ?? 1;
            var safeSortExpression =
               string.IsNullOrEmpty(SortExpression) ? "CreateDate" : SortExpression;

            bool useDefaultSort = Accending.HasValue ? Accending.Value : true;

            var resultsFound = 0;
            var model = new CollaborationSpaceSearchResultModel();
            var search =
              new CollaborationSpaceSearchParams
              {
                  SortExpression = safeSortExpression,
                  CurrentPageNumber = safePage,
                  ItemsPerPage = 10,
                  GenreFilter = Genres
              };

            model.CollaborationSpaceSearchResults =
            _UnitOfWork.CollaborationSpaceRepository.GetActiveCollaborationSpaces(search,
                                             out resultsFound);
            model.NumberOfResults = resultsFound;
            model.GenreLookUpList = 
                (IList<GenreLookUp>)_UnitOfWork.GenreLookUpRepository.Query();
            model.CurrentPage = safePage;
            model.ItemsPerPage = 10;
            model.SortExpression = safeSortExpression;

            // if a filter has been selected add to the model
            // so we can show what filter is selected in the view
            if (Genres != null && Genres.Count > 0)
            {
                model.GenreLookUpId = Genres[0];
            }

            model.ResultsDescription =
            string.Format("Displaying records {0} - {1} of {2} sorted by {3}",
                (safePage * 10),
                (safePage * 10) + 10,
                resultsFound,
                safeSortExpression);
            return View("Index", model);

        }


        public IActionResult Error()
        {
            return View();
        }
    }
}
