using System;
using System.Collections.Generic;


namespace AspNetCoreMvcRecipes.Shared.DataAccess
{
    /// <summary>
    /// Manages alerts for application
    /// </summary>
    public partial class Alert
    {
        /// <summary>
        /// Unique ID for Alert
        /// </summary>
        public int AlertId { get; set; } // AlertId (Primary key)

        /// <summary>
        /// Headline used in  email subject and page header
        /// </summary>
        public string Headline { get; set; } // Headline

        /// <summary>
        /// Short summary of alert
        /// </summary>
        public string Summary { get; set; } // Summary


        /// <summary>
        /// Artist ID
        /// </summary>
        public int ArtistId { get; set; }

        /// <summary>
        /// person or bot that performed the action that generated the alert
        /// </summary>
        public string ActorDisplayName { get; set; } // ActorDisplayName

        /// <summary>
        /// person or bot that performed the action that generated the alert, web page
        /// </summary>
        public string ActorUrl { get; set; }

        /// <summary>
        /// The URL to the avatar for the person or bot that performed the action that generated the alert
        /// </summary>
        public string ActorAvatarUrl { get; set; }

        /// <summary>
        /// URL for alert
        /// </summary>
        public string AlertUrl { get; set; } // AlertUrl

        /// <summary>
        /// Date the alert was added
        /// </summary>
        public DateTime AlertAddedDate { get; set; } // AlertAddedDate

        /// <summary>
        /// Number of clicks alert has generated
        /// </summary>
        public int ClickCount { get; set; } // ClickCount

        /// <summary>
        /// Date the alert was targeting
        /// </summary>
        public DateTime AlertDate { get; set; } // AlertDate

        /// <summary>
        /// Alert category
        /// </summary>
        public int Category { get; set; } // Category

        /// <summary>
        /// Item alert was about
        /// </summary>
        public string ItemIdentifier { get; set; } // ItemIdentifier

        /// <summary>
        /// ID of item that alert will alert to
        /// </summary>
        public int ItemDetailIdentifier { get; set; }

        /// <summary>
        /// Link to tags
        /// </summary>
        public virtual ICollection<AlertTag> AlertTags { get; set; } // AlertTag.FK_AlertTag_Alert

        /// <summary>
        /// Constructor sets defaults
        /// </summary>
        public Alert()
        {
            ClickCount = 0;
            AlertDate = System.DateTime.Now;
            ItemDetailIdentifier = 0;
            AlertTags = new List<AlertTag>();
            InitializePartial();
        }

        partial void InitializePartial();
    }
}