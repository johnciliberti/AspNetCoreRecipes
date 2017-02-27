using System.Collections.Generic;
using AspNetCoreMvcRecipes.Shared.DataAccess.Facade;

namespace AspNetCoreMvcRecipes.Shared.DataAccess
{
    public interface ICollaborationSpaceRepository
    {
        List<CollaborationSpaceSearchResult> GetActiveCollaborationSpaces(CollaborationSpaceSearchParams filter, out int resultsFound);
        List<CollaborationSpace> GetCollaborationSpacesForArtist(int artistId);
    }
}