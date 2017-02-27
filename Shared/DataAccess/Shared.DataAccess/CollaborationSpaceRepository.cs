using System;
using System.Collections.Generic;
using AspNetCoreMvcRecipes.Shared.DataAccess.Facade;
using AspNetCoreMvcRecipes.Shared.DataAccess.Util;
using System.Linq;

namespace AspNetCoreMvcRecipes.Shared.DataAccess
{
    /// <summary>
    /// Repository class used to access collaboration spaces
    /// </summary>
    public class CollaborationSpaceRepository : Repository<CollaborationSpace>, ICollaborationSpaceRepository
    {
        /// <summary>
        /// Constructor calls base
        /// </summary>
        /// <param name="context"></param>
        public CollaborationSpaceRepository(MoBContext context) : base(context)
        {

        }

        /// <summary>
        /// Gets all collaboration spaces for artists
        /// </summary>
        /// <param name="artistId"></param>
        /// <returns></returns>
        public virtual List<CollaborationSpace> GetCollaborationSpacesForArtist(int artistId)
        {
            var query = from e in _context.CollaborationSpaces
                        join a in _context.ArtistCollaborationSpaces
                        on e.CollaborationSpaceId equals a.CollaborationSpaceId
                        where a.ArtistId == artistId
                        select e;
            return query.ToList();

        }

        /// <summary>
        /// Gets all active collaboration spaces
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="resultsFound"></param>
        /// <returns></returns>
        public virtual List<CollaborationSpaceSearchResult> GetActiveCollaborationSpaces(CollaborationSpaceSearchParams filter, out int resultsFound)
        {
            if (filter == null)
                throw new ArgumentNullException("filter");

            var collabSpacesQuery = from a in _context.CollaborationSpaces
                                    join o in _context.CollaborationSpaceGenres
                                    on a.CollaborationSpaceId equals o.CollaborationSpaceId
                                    join p in _context.ArtistCollaborationSpaces
                                    on a.CollaborationSpaceId equals p.CollaborationSpaceId
                                    join artist in _context.Artists
                                    on p.ArtistId equals artist.ArtistId
                                    where a.Status != ProjectStatus.Canceled &&
                                      a.Status != ProjectStatus.OnHold &&
                                      a.Status != ProjectStatus.Published &&
                                      a.AllowPublicView == true &&
                                      p.IsCreator == true
                                    select new CollaborationSpaceSearchResult()
                                    {
                                        CollaborationSpaceId = a.CollaborationSpaceId,
                                        CreateDate = a.CreateDate,
                                        Description = a.Description,
                                        LastPostDate = a.LastPostDate,
                                        ModifiedDate = a.ModifiedDate,
                                        NumberComments = a.NumberComments,
                                        NumberViews = a.NumberViews,
                                        RestrictContributorsToBand = a.RestrictContributorsToBand,
                                        Status = a.Status,
                                        Title = a.Title,
                                        GenreLookUpId = o.GenreLookUpId,
                                        UserName = artist.UserName,
                                        WebSite = artist.WebSite,
                                        AvatarURL = artist.AvatarUrl
                                    };

            if (filter.GenreFilter != null && filter.GenreFilter.Count>0)
            {
                
                collabSpacesQuery = collabSpacesQuery.Where(LinqUtilities.BuildOrExpression<CollaborationSpaceSearchResult,
                        int>(p => p.GenreLookUpId, filter.GenreFilter));
            }

            //get rid of duplicates
            // EF Bug causing invalid caste exception
            // https://github.com/aspnet/EntityFramework/issues/1909
            //collabSpacesQuery = (from a in collabSpacesQuery
            //                     group a by a.CollaborationSpaceId into u
            //                     select u.First());


            // First round trip to the database that runs a query to
            // get the count
            resultsFound = collabSpacesQuery==null ? 0 : collabSpacesQuery.Count();
            int skip = GetSkip(filter.CurrentPageNumber, filter.ItemsPerPage);

            //several EF bugs causing incorrect results here
            // https://github.com/aspnet/EntityFramework/issues/1851
            collabSpacesQuery = collabSpacesQuery.OrderByText(filter.SortExpression).Skip(skip).Take(filter.ItemsPerPage);

            // second round trip to the database retrieves (count) 10 records
            return collabSpacesQuery?.ToList();

        }

        private int GetSkip(int page, int count)
        {
            if (page < 2)
            {
                return 0;
            }
            else
            {
                return page * count;
            }
        }


    }
}