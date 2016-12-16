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
    // Alert
    public partial class Alert
    {
        public int AlertId { get; set; } // AlertId (Primary key)

        public string Headline { get; set; } // Headline

        public string Summary { get; set; } // Summary

        public int ArtistId { get; set; } // ArtistId

        public string ActorDisplayName { get; set; } // ActorDisplayName

        public string ActorUrl { get; set; } // ActorUrl

        public string ActorAvatarUrl { get; set; } // ActorAvatarUrl

        public string AlertUrl { get; set; } // AlertUrl

        public DateTime AlertAddedDate { get; set; } // AlertAddedDate

        public int ClickCount { get; set; } // ClickCount

        public DateTime AlertDate { get; set; } // AlertDate

        public int Category { get; set; } // Category

        public string ItemIdentifier { get; set; } // ItemIdentifier

        public int ItemDetailIdentifier { get; set; } // ItemDetailIdentifier

        // Reverse navigation
        public virtual ICollection<AlertTag> AlertTags { get; set; } // AlertTag.FK_AlertTag_Alert

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