// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier

//using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.DatabaseGeneratedOption;

namespace Mvc6Recipes.Shared.DataAccess
{
    // MessageSpam
    public partial class MessageSpam
    {
        public int MessageSpamId { get; set; } // MessageSpamID (Primary key)

        public int MessageId { get; set; } // MessageID

        public int MessageBodyHash { get; set; } // MessageBodyHash
    }
}