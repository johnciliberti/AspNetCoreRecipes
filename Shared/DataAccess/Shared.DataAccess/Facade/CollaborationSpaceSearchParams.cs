using System;
using System.Collections.Generic;

namespace Mvc6Recipes.Shared.DataAccess.Facade
{
    public class CollaborationSpaceSearchParams
    {
        public int CurrentPageNumber { get; set; }
        public int ItemsPerPage { get; set; }
        public string SortExpression { get; set; }
        public List<int> GenreFilter { get; set; }
        public List<ProjectCopyrightModel> CollaborationModelFilter { get; set; }
        public List<ProjectStatus> StatusFilter { get; set; }
    }
}