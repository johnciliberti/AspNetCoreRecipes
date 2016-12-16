// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier

//using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.DatabaseGeneratedOption;

namespace Mvc6Recipes.Shared.DataAccess
{
    // CollaborationSpaceGenre
    public partial class CollaborationSpaceGenre
    {
        public int CollaborationSpaceGenreId { get; set; } // CollaborationSpaceGenreId (Primary key)

        public int CollaborationSpaceId { get; set; } // CollaborationSpaceId

        public int GenreLookUpId { get; set; } // GenreLookUpId

        // Foreign keys
        public virtual CollaborationSpace CollaborationSpace { get; set; } // FK_CollaborationSpaceGenre_CollaborationSpace

        public virtual GenreLookUp GenreLookUp { get; set; } // FK_CollaborationSpaceGenre_GenreLookUp
    }
}