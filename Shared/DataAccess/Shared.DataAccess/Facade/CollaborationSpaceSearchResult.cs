using System;
using AspNetCoreMvcRecipes.Shared.DataAccess;
using System.Collections.Generic;

namespace AspNetCoreMvcRecipes.Shared.DataAccess.Facade
{
    /// <summary>
    /// View Model for search results pages
    /// </summary>
    public class CollaborationSpaceSearchResult
    {
        /// <summary>
        /// Collaboration space ID
        /// </summary>
        public int CollaborationSpaceId { get; set; }
        /// <summary>
        /// Date collaboration space was created
        /// </summary>
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// Description of the collaboration space
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// The date of the last post
        /// </summary>
        public DateTime? LastPostDate { get; set; }
        /// <summary>
        /// Last date and time collaboration space was modified
        /// </summary>
        public DateTime ModifiedDate { get; set; }
        /// <summary>
        /// Number of comments
        /// </summary>
        public int NumberComments { get; set; }
        /// <summary>
        /// Number of times collaboration space has been viewed
        /// </summary>
        public int NumberViews { get; set; }

        /// <summary>
        /// If true only band members can contribute
        /// </summary>
        public bool RestrictContributorsToBand { get; set; }

        /// <summary>
        /// The status of the Collaboration Space 
        /// </summary>
        public ProjectStatus Status { get; set; }

        /// <summary>
        /// The title of the collaboration space
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Primary Genre ID for space
        /// </summary>
        public int GenreLookUpId { get; set; }

        /// <summary>
        /// User name of the artist who created the space
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// The website of the artist who created the space
        /// </summary>
        public string WebSite { get; set; }

        /// <summary>
        /// URL of the Artist Avatar
        /// </summary>
        public string AvatarURL { get; set; }

    }
   

}