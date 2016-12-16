// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier

using System;

//using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.DatabaseGeneratedOption;

namespace Mvc6Recipes.Shared.DataAccess
{
    // CollaborationSpaceInvite
    public partial class CollaborationSpaceInvite
    {
        public int CollaborationSpaceInviteId { get; set; } // CollaborationSpaceInviteId (Primary key)

        public int CollaborationSpaceId { get; set; } // CollaborationSpaceId

        public string EmailAddress { get; set; } // EmailAddress

        public int ArtistId { get; set; } // ArtistId

        public int? BandId { get; set; } // BandId

        public Guid LinkIdentifier { get; set; } // LinkIdentifier

        public DateTime CreateDate { get; set; } // CreateDate

        // Foreign keys
        public virtual Artist Artist { get; set; } // FK_CollaborationSpaceInvite_Artist

        public virtual CollaborationSpace CollaborationSpace { get; set; } // FK_CollaborationSpaceInvite_CollaborationSpace
    }
}