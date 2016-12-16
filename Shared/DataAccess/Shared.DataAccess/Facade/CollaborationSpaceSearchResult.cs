using System;
using Mvc6Recipes.Shared.DataAccess;
using System.Collections.Generic;

namespace Mvc6Recipes.Shared.DataAccess.Facade
{
    public class CollaborationSpaceSearchResult
    {
        public int CollaborationSpaceId { get; set; }
        public DateTime CreateDate { get; set; }
        public string Description { get; set; }
        public DateTime? LastPostDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int NumberComments { get; set; }
        public int NumberViews { get; set; }
        public bool RestrictContributorsToBand { get; set; }
        public ProjectStatus Status { get; set; }
        public string Title { get; set; }
        public int GenreLookUpId { get; set; }
        public string UserName { get; set; }
        public string WebSite { get; set; }
        public string AvatarURL { get; set; }

    }
   

}