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
    // CollaborationSpaceAlerts
    public partial class CollaborationSpaceAlert
    {
        public int CollaborationSpaceAlertId { get; set; } // CollaborationSpaceAlertId (Primary key)

        public int CollaborationSpaceId { get; set; } // CollaborationSpaceId

        public int ArtistId { get; set; } // ArtistId

        public DateTime CreateDate { get; set; } // CreateDate

        // Foreign keys
        public virtual Artist Artist { get; set; } // FK_CollaborationSpaceAlerts_Artist

        public virtual CollaborationSpace CollaborationSpace { get; set; } // FK_CollaborationSpaceAlerts_CollaborationSpace

        public CollaborationSpaceAlert()
        {
            CreateDate = System.DateTime.Now;
            InitializePartial();
        }

        partial void InitializePartial();
    }
}