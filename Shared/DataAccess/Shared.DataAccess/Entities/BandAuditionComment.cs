// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier

//using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.DatabaseGeneratedOption;

namespace Mvc6Recipes.Shared.DataAccess
{
    // BandAuditionComment
    public partial class BandAuditionComment
    {
        public int BandAuditionCommentId { get; set; } // BandAuditionCommentId (Primary key)

        public int BandAuditionId { get; set; } // BandAuditionId

        public int ArtistId { get; set; } // ArtistId

        public string Comment { get; set; } // Comment

        public int Rating { get; set; } // Rating

        public bool Vote { get; set; } // Vote

        // Foreign keys
        public virtual Artist Artist { get; set; } // FK_BandAuditionComment_Artist

        public virtual BandAudition BandAudition { get; set; } // FK_BandAuditionComment_BandAudition

        public BandAuditionComment()
        {
            Rating = 0;
            Vote = false;
            InitializePartial();
        }

        partial void InitializePartial();
    }
}