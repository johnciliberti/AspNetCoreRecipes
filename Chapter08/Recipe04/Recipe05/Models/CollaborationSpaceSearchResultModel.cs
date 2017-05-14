using AspNetCoreMvcRecipes.Shared.DataAccess;
using AspNetCoreMvcRecipes.Shared.DataAccess.Facade;
using System.Collections.Generic;

namespace Recipe04.Models
{
    public class CollaborationSpaceSearchResultModel
    {
        public IList<CollaborationSpaceSearchResult>
                  CollaborationSpaceSearchResults
        { get; set; }
        public IList<GenreLookUp> GenreLookUpList { get; set; }
        public int NumberOfResults { get; set; }
        public string ResultsDescription { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public string SortExpression { get; set; }
        public int GenreLookUpId { get; set; }
        public int TotalPages
        {
            get
            {
                if (ItemsPerPage != 0)
                {
                    return NumberOfResults / ItemsPerPage;
                }
                return 0;
            }
        }
    }

}
