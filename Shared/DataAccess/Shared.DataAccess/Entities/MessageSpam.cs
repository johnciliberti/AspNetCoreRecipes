namespace AspNetCoreMvcRecipes.Shared.DataAccess
{
    /// <summary>
    /// Tracks massages that have flagged as SPAM by end users
    /// </summary>
    public partial class MessageSpam
    {
        /// <summary>
        /// Unique id for record
        /// </summary>
        public int MessageSpamId { get; set; } // (Primary key)

        /// <summary>
        /// The ID of message that was flagged
        /// </summary>
        public int MessageId { get; set; }

        /// <summary>
        /// Hash of message body. Use hash to make comparisons faster
        /// </summary>
        public int MessageBodyHash { get; set; }
    }
}