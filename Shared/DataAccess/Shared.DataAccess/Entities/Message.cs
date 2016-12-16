// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier

using System;
using System.Collections.Generic;

//using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.DatabaseGeneratedOption;

namespace Mvc6Recipes.Shared.DataAccess
{
    // Message
    public partial class Message
    {
        public int MessageId { get; set; } // MessageId (Primary key)

        public int ArtistId { get; set; } // ArtistID

        public string Subject { get; set; } // Subject

        public short Importance { get; set; } // Importance

        public DateTime DateSent { get; set; } // DateSent

        public string MessageBody { get; set; } // MessageBody

        // Reverse navigation
        public virtual ICollection<MessageRecipient> MessageRecipients { get; set; } // MessageRecipient.FK_MessageRecipient_Message

        // Foreign keys
        public virtual Artist Artist { get; set; } // FK_Message_Artist

        public Message()
        {
            MessageRecipients = new List<MessageRecipient>();
            InitializePartial();
        }

        partial void InitializePartial();
    }
}