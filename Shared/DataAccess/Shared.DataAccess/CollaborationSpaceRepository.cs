using System;
using System.Collections.Generic;
using Mvc6Recipes.Shared.DataAccess.Facade;
using Mvc6Recipes.Shared.DataAccess.Util;
using System.Linq;

namespace Mvc6Recipes.Shared.DataAccess
{
    public class CollaborationSpaceRepository : Repository<CollaborationSpace>
    {
        public CollaborationSpaceRepository(MoBContext context) : base(context)
        {

        }


        public List<CollaborationSpace> GetCollaborationSpacesForArtist(int artistId)
        {
            var query = from e in _context.CollaborationSpaces
                        join a in _context.ArtistCollaborationSpaces
                        on e.CollaborationSpaceId equals a.CollaborationSpaceId
                        where a.ArtistId == artistId
                        select e;
            return query.ToList();

        }

        public List<CollaborationSpaceSearchResult> GetActiveCollaborationSpaces(CollaborationSpaceSearchParams filter, out int resultsFound)
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
            int skip = getSkip(filter.CurrentPageNumber, filter.ItemsPerPage);

            //several EF bugs causing incorrect results here
            // https://github.com/aspnet/EntityFramework/issues/1851
            collabSpacesQuery = collabSpacesQuery.OrderByText(filter.SortExpression).Skip(skip).Take(filter.ItemsPerPage);

            // second round trip to the database retrieves (count) 10 records
            return collabSpacesQuery == null ?  null : collabSpacesQuery.ToList();

        }

        private int getSkip(int page, int count)
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