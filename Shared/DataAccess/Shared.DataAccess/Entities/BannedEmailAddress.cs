namespace AspNetCoreMvcRecipes.Shared.DataAccess
{
    /// <summary>
    /// Tracks banned email addresses for people who have violated terms of service
    /// </summary>
    public partial class BannedEmailAddress
    {
        /// <summary>
        /// The email address that is banned (Primary key)
        /// </summary>
        public string EmailAddress { get; set; }
    }
}