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
    // CollaborationSpaceMedia
    public partial class CollaborationSpaceMedia
    {
        public int CollaborationSpaceMediaId { get; set; } // CollaborationSpaceMediaId (Primary key)

        public int CollaborationSpaceId { get; set; } // CollaborationSpaceId

        public int MediaId { get; set; } // MediaId

        public DateTime ModifiedDate { get; set; } // ModifiedDate

        public bool Archive { get; set; } // Archive

        // Foreign keys
        public virtual CollaborationSpace CollaborationSpace { get; set; } // FK_CollaborationSpaceMedia_CollaborationSpace

        public virtual Medium Medium { get; set; } // FK_CollaborationSpaceMedia_ToTable_1

        public CollaborationSpaceMedia()
        {
            ModifiedDate = System.DateTime.Now;
            Archive = false;
            InitializePartial();
        }

        partial void InitializePartial();
    }
}