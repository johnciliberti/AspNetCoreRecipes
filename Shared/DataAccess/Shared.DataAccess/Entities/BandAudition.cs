// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier

using System.Collections.Generic;

//using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.DatabaseGeneratedOption;

namespace Mvc6Recipes.Shared.DataAccess
{
    // BandAudition
    public partial class BandAudition
    {
        public int BandAuditionId { get; set; } // BandAuditionId (Primary key)

        public int ProjectOpenPositionId { get; set; } // ProjectOpenPositionId

        public int ArtistId { get; set; } // ArtistId

        public int SongId { get; set; } // SongId

        public int VotesRequired { get; set; } // VotesRequired

        public int VotesRecieved { get; set; } // VotesRecieved

        public string Status { get; set; } // Status

        // Reverse navigation
        public virtual ICollection<BandAuditionComment> BandAuditionComments { get; set; } // BandAuditionComment.FK_BandAuditionComment_BandAudition

        // Foreign keys
        public virtual Artist Artist { get; set; } // FK_BandAudition_Artist

        public virtual Song Song { get; set; } // FK_BandAudition_Song

        public BandAudition()
        {
            BandAuditionComments = new List<BandAuditionComment>();
            InitializePartial();
        }

        partial void InitializePartial();
    }
}