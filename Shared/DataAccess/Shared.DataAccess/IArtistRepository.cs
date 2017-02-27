using System.Collections.Generic;

namespace AspNetCoreMvcRecipes.Shared.DataAccess
{
    public interface IArtistRepository
    {
        List<Artist> GetNewArtists(int page = 1);
    }
}