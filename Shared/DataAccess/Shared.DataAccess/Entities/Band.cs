using System;
using System.Collections.Generic;


namespace AspNetCoreMvcRecipes.Shared.DataAccess
{
    /// <summary>
    /// A group of artists who preform music together
    /// </summary>
    public partial class Band
    {
        /// <summary>
        /// The unique id for the band
        /// </summary>
        public int BandId { get; set; } // BandId (Primary key)

        /// <summary>
        /// The name of the band
        /// </summary>
        public string BandName { get; set; } // BandName

        /// <summary>
        /// The band's bio
        /// </summary>
        public string BandBio { get; set; } // BandBio

        /// <summary>
        /// An image with the band's logo
        /// </summary>
        public string BandLogoUrl { get; set; } // BandLogoUrl

        /// <summary>
        /// A background image to display on the band home page
        /// </summary>
        public string BandBackgroundImageUrl { get; set; } // BandBackgroundImageUrl

        /// <summary>
        /// A picture of the band to be displayed on band search and other pages
        /// </summary>
        public string BandDisplayPhotoUrl { get; set; } // BandDisplayPhotoUrl

        /// <summary>
        /// The date that this record was created
        /// </summary>
        public DateTime? CreateDate { get; set; } // CreateDate
        /// <summary>
        /// The date this record was last modified
        /// </summary>
        public DateTime? ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation
        /// <summary>
        /// The artists who are in the band
        /// </summary>
        public virtual ICollection<ArtistBand> ArtistBands { get; set; } // ArtistBand.FK_ArtistBand_ToBand

        /// <summary>
        /// List of  types of music that the band plays
        /// </summary>
        public virtual ICollection<BandGenre> BandGenres { get; set; } // BandGenre.FK_BandGenre_Band

        /// <summary>
        /// Collaboration spaces created by the band
        /// </summary>
        public virtual ICollection<CollaborationSpace> CollaborationSpaces { get; set; } // CollaborationSpace.FK_CollaborationSpace_ToTable

        /// <summary>
        /// List of play lists defined by the band
        /// </summary>
        public virtual ICollection<PlayList> PlayLists { get; set; } // PlayList.FK_PlayList_Band

        /// <summary>
        /// List of concerts that band has or will perform
        /// </summary>
        public virtual ICollection<BandEvent> BandConcerts { get; set; } // PlayList.FK_PlayList_Band

        /// <summary>
        /// Constructor - initializes object and populates default values
        /// </summary>
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