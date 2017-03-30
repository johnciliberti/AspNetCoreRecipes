
using System;


namespace AspNetCoreMvcRecipes.Shared.DataAccess
{
    /// <summary>
    /// Tracks alert registrations for collaboration spaces
    /// </summary>
    public partial class CollaborationSpaceAlert
    {
        /// <summary>
        /// Primary key
        /// </summary>
        public int CollaborationSpaceAlertId { get; set; }

        /// <summary>
        /// ID of collaboration space
        /// </summary>
        public int CollaborationSpaceId { get; set; }

        /// <summary>
        /// Artist ID
        /// </summary>
        public int ArtistId { get; set; }

        /// <summary>
        /// The date and time alert was created
        /// </summary>
        public DateTime CreateDate { get; set; } // CreateDate

        /// <summary>
        /// Link to artists FK_CollaborationSpaceAlerts_Artist
        /// </summary>
        public virtual Artist Artist { get; set; }

        /// <summary>
        /// Link for collaboration spaces FK_CollaborationSpaceAlerts_CollaborationSpace
        /// </summary>
        public virtual CollaborationSpace CollaborationSpace { get; set; } 

        /// <summary>
        /// Constructor establishes default values
        /// </summary>
        public CollaborationSpaceAlert()
        {
            CreateDate = System.DateTime.Now;
            InitializePartial();
        }

        partial void InitializePartial();
    }
}