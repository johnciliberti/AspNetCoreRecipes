using System.Collections.Generic;
using System.Linq;

namespace AspNetCoreMvcRecipes.Shared.DataAccess
{
    /// <summary>
    /// Repository that simplifies accessing and modifying artist information
    /// </summary>
    public class ArtistRepository : Repository<Artist>, IArtistRepository
    {
        /// <summary>
        /// Constructor allows Db Context to be injected
        /// </summary>
        /// <param name="context">Mob DB Context</param>
        public ArtistRepository(MoBContext context) : base(context)
        {

        }


        /// <summary>
        /// Gets a list of artists
        /// </summary>
        /// <param name="page">Allows you to move between pages</param>
        /// <returns>List of artists</returns>
        public virtual IList<Artist> GetNewArtists(int page=1)
        {
            var pageSize = 20;
            var skip = (page - 1) * pageSize;
            var query = (from e in _context.Artists
                         select e).Skip(skip).Take(20).OrderByDescending(a => a.CreateDate);
            return query.ToList();

        }
    }
}