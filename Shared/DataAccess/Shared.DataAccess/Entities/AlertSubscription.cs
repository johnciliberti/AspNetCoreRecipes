// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier

//using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.DatabaseGeneratedOption;

namespace Mvc6Recipes.Shared.DataAccess
{
    // AlertSubscription
    public partial class AlertSubscription
    {
        public int AlertSubscriptionId { get; set; } // AlertSubscriptionId (Primary key)

        public int ArtistId { get; set; } // ArtistId

        public string Tags { get; set; } // Tags

        // Foreign keys
        public virtual Artist Artist { get; set; } // FK_AlertSubscription_Artist
    }
}