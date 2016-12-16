// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier

//using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.DatabaseGeneratedOption;

namespace Mvc6Recipes.Shared.DataAccess
{
    // MessageRecipient
    public partial class MessageRecipient
    {
        public int MessageRecipientId { get; set; } // MessageRecipientId (Primary key)

        public int MessageId { get; set; } // MessageId

        public int ArtistId { get; set; } // ArtistId

        public bool MessageRead { get; set; } // MessageRead

        public short MessageStatus { get; set; } // MessageStatus

        public string Folder { get; set; } // Folder

        // Foreign keys
        public virtual Artist Artist { get; set; } // FK_MessageRecipient_Artist

        public virtual Message Message { get; set; } // FK_MessageRecipient_Message
    }
}