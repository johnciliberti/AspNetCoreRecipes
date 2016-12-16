// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier

//using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.DatabaseGeneratedOption;

namespace Mvc6Recipes.Shared.DataAccess
{
    // webpages_OAuthMembership
    public partial class WebpagesOAuthMembership
    {
        public string Provider { get; set; } // Provider (Primary key)

        public string ProviderUserId { get; set; } // ProviderUserId (Primary key)

        public int UserId { get; set; } // UserId
    }
}