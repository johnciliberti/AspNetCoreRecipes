namespace AspNetCoreMvcRecipes.Shared.DataAccess
{
    /// <summary>
    /// Tracks alerts an artist is subscribed to
    /// </summary>
    public partial class AlertSubscription
    {
        /// <summary>
        /// Primary key for class
        /// </summary>
        public int AlertSubscriptionId { get; set; } 

        /// <summary>
        /// Artist who is subscribing to alert
        /// </summary>
        public int ArtistId { get; set; } // ArtistId


        /// <summary>
        /// One or more tags separated by commas
        /// </summary>
        public string Tags { get; set; } // Tags

        /// <summary>
        /// FK_AlertSubscription_Artist
        /// </summary>
        public virtual Artist Artist { get; set; }
    }
}