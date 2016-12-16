using System;

namespace Mvc6Recipes.Shared.DataAccess
{
    // ArtistBand
    public partial class ArtistBand
    {
        public int ArtistBandId { get; set; } // ArtistBandId (Primary key)

        public int ArtistId { get; set; } // ArtistId

        public int? BandId { get; set; } // BandId

        public string Role { get; set; } // Role

        public DateTime JoinedDate { get; set; } // JoinedDate

        public bool IsActiveMember { get; set; } // IsActiveMember

        public DateTime? DeactivateDate { get; set; } // DeactivateDate

        public bool AllowEditBand { get; set; } // AllowEditBand

        public bool IsMemberAdmin { get; set; } // IsMemberAdmin

        // Foreign keys
        public virtual Artist Artist { get; set; } // FK_ArtistBand_ToArtist

        public virtual Band Band { get; set; } // FK_ArtistBand_ToBand

        public ArtistBand()
        {
            IsActiveMember = true;
            AllowEditBand = false;
            IsMemberAdmin = false;
            InitializePartial();
        }

        partial void InitializePartial();
    }
}