// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier

//using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.DatabaseGeneratedOption;

namespace Mvc6Recipes.Shared.DataAccess
{
    // ArtistProfile
    public partial class ArtistProfile
    {
        public int ArtistId { get; set; } // ArtistId (Primary key)

        public string Bio { get; set; } // Bio

        public string MusicalInfluences { get; set; } // MusicalInfluences

        public string ProfileTemplateName { get; set; } // ProfileTemplateName

        public string FirstName { get; set; } // FirstName

        public string LastName { get; set; } // LastName

        // Foreign keys
        public virtual Artist Artist { get; set; } // FK_ArtistProfile_Artist

        public ArtistProfile()
        {
            ProfileTemplateName = "basic";
            InitializePartial();
        }

        partial void InitializePartial();
    }
}