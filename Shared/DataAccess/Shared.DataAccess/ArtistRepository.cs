using System.Collections.Generic;
using System.Linq;

namespace AspNetCoreMvcRecipes.Shared.DataAccess
{
    /// <summary>
    /// Repository that simplifies accessing and modifing artist information
    /// </summary>
    public class ArtistRepository : Repository<Artist>
    {
        public ArtistRepository(MoBContext context) : base(context)
        {

        }

        /// <summary>
        /// Get a list of the last 20 artists to register for the site.
        /// </summary>
        /// <returns>List of Artists</returns>
        public List<Artist> GetNewArtists()
        {
            var query = (from e in _context.Artists
                        select e).Take(20);
            return query.ToList();

        }
    }
}