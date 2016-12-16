using System.Collections.Generic;
using System.Linq;

namespace Mvc6Recipes.Shared.DataAccess
{
    public class ArtistRepository : Repository<Artist>
    {
        public ArtistRepository(MoBContext context) : base(context)
        {

        }

        public List<Artist> GetNewArtists()
        {
            var query = (from e in _context.Artists
                        select e).Take(20);
            return query.ToList();

        }
    }
}