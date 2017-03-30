using System.Collections.Generic;

namespace AspNetCoreMvcRecipes.Shared.DataAccess
{
    /// <summary>
    /// Repository for artists
    /// </summary>
    public interface IArtistRepository
    {
        /// <summary>
        /// Gets list of artists
        /// </summary>
        /// <param name="page">The page number. Default is page 1</param>
        /// <returns>List of artists</returns>
        IList<Artist> GetNewArtists(int page = 1);
    }
}