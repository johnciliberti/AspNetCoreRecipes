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
    // Band
    public partial class Band
    {
        public int BandId { get; set; } // BandId (Primary key)

        public string BandName { get; set; } // BandName

        public string BandBio { get; set; } // BandBio

        public string BandLogoUrl { get; set; } // BandLogoUrl

        public string BandBackgroundImageUrl { get; set; } // BandBackgroundImageUrl

        public string BandDisplayPhotoUrl { get; set; } // BandDisplayPhotoUrl

        public DateTime? CreateDate { get; set; } // CreateDate

        public DateTime? ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation
        public virtual ICollection<ArtistBand> ArtistBands { get; set; } // ArtistBand.FK_ArtistBand_ToBand

        public virtual ICollection<BandGenre> BandGenres { get; set; } // BandGenre.FK_BandGenre_Band

        public virtual ICollection<CollaborationSpace> CollaborationSpaces { get; set; } // CollaborationSpace.FK_CollaborationSpace_ToTable

        public virtual ICollection<PlayList> PlayLists { get; set; } // PlayList.FK_PlayList_Band

        public Band()
        {
            ArtistBands = new List<ArtistBand>();
            BandGenres = new List<BandGenre>();
            CollaborationSpaces = new List<CollaborationSpace>();
            PlayLists = new List<PlayList>();
            InitializePartial();
        }

        partial void InitializePartial();
    }
}