using System;
using System.Collections.Generic;

namespace AspNetCoreMvcRecipes.Shared.DataAccess.Facade
{
    /// <summary>
    /// Search parameters for collaboration spaces
    /// </summary>
    public class CollaborationSpaceSearchParams
    {
        /// <summary>
        /// current page number in search
        /// </summary>
        public int CurrentPageNumber { get; set; }
        /// <summary>
        /// Number of items per page
        /// </summary>
        public int ItemsPerPage { get; set; }
        /// <summary>
        /// Sort expression used in the search
        /// </summary>
        public string SortExpression { get; set; }
        /// <summary>
        /// Allows you to filer results by Genre
        /// </summary>
        public IList<int> GenreFilter { get; set; }
        /// <summary>
        /// Allows you to filter by collaboration model
        /// </summary>
        public IList<ProjectCopyrightModel> CollaborationModelFilter { get; set; }
        /// <summary>
        /// Allows you to filter by status
        /// </summary>
        public IList<ProjectStatus> StatusFilter { get; set; }
    }
}