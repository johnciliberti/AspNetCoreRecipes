using System.Collections.Generic;
using AspNetCoreMvcRecipes.Shared.DataAccess.Facade;

namespace AspNetCoreMvcRecipes.Shared.DataAccess
{
    /// <summary>
    /// Interface for repository for collaboration spaces
    /// </summary>
    public interface ICollaborationSpaceRepository
    {
        /// <summary>
        /// Gets list of collaboration spaces
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="resultsFound"></param>
        /// <returns></returns>
        List<CollaborationSpaceSearchResult> GetActiveCollaborationSpaces(CollaborationSpaceSearchParams filter, out int resultsFound);

        /// <summary>
        /// Gets list of collaboration spaces for a specific artist
        /// </summary>
        /// <param name="artistId"></param>
        /// <returns></returns>
        List<CollaborationSpace> GetCollaborationSpacesForArtist(int artistId);
    }
}