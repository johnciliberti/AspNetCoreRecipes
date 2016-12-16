// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier

//using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.DatabaseGeneratedOption;

namespace Mvc6Recipes.Shared.DataAccess
{
    // BandGenre
    public partial class BandGenre
    {
        public int BandGenreId { get; set; } // BandGenreId (Primary key)

        public int BandId { get; set; } // BandId

        public int GenreLookUpId { get; set; } // GenreLookUpId

        // Foreign keys
        public virtual Band Band { get; set; } // FK_BandGenre_Band

        public virtual GenreLookUp GenreLookUp { get; set; } // FK_BandGenre_GenreLookUp
    }
}