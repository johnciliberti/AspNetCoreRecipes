using System;
using System.Collections.Generic;



namespace AspNetCoreMvcRecipes.Shared.DataAccess
{
    /// <summary>
    /// Contains meta data for a song uploaded so that it can  be played on the On-line Radio  station, an Artist profile, or a band profile
    /// </summary>
    public partial class Song
    {
        /// <summary>
        /// The unique ID for the song
        /// </summary>
        public int SongId { get; set; } // SongId (Primary key)

        /// <summary>
        /// Id of the media element
        /// </summary>
        public int MediaId { get; set; } // MediaId

        /// <summary>
        /// The title of the song. Will be displayed in play lists
        /// </summary>
        public string SongTitle { get; set; } // SongTitle

        /// <summary>
        /// The year the song was first released
        /// </summary>
        public int? ReleaseYear { get; set; } // ReleaseYear

        /// <summary>
        /// URL of image file that will be used as artwork for the song
        /// </summary>
        public string ArtworkUrl { get; set; } // ArtworkURL

        /// <summary>
        /// The song lyrics
        /// </summary>
        public string Lyrics { get; set; } // Lyrics

        /// <summary>
        /// The story of the song. How it was written and recorded and what inspired it
        /// </summary>
        public string SongDescription { get; set; } // SongDescription

        /// <summary>
        /// ID of the main genre this song is assoicated with
        /// </summary>
        public int? GenreId { get; set; } // GenreId

        /// <summary>
        /// The date the record was created 
        /// </summary>
        public DateTime CreateDate { get; set; } // CreateDate

        /// <summary>
        /// If true, the song will be shown in the on-line radio
        /// </summary>
        public bool ShowInLibrary { get; set; } // ShowInLibrary

        // Reverse navigation
        /// <summary>
        /// Reverse navigation to BandAuditions   BandAudition.FK_BandAudition_Song
        /// </summary>
        public virtual ICollection<BandAudition> BandAuditions { get; set; }

        // Reverse navigation
        /// <summary>
        /// Reverse navigation to PlaylistItems   PlaylistItem.FK_PlaylistItem_Song
        /// </summary>
        public virtual ICollection<PlaylistItem> PlaylistItems { get; set; } // PlaylistItem.FK_PlaylistItem_Song

        /// <summary>
        /// Reverse navigation to SongComments SongComment.FK_SongComment_Song
        /// </summary>
        public virtual ICollection<SongComment> SongComments { get; set; } 

        /// <summary>
        ///  FK_Song_Media
        /// </summary>
        public virtual Media Medium { get; set; } 

        /// <summary>
        /// Constructor initializes object and populates default values
        /// </summary>
        public Song()
        {
            GenreId = 21;
            CreateDate = System.DateTime.Now;
            ShowInLibrary = true;
            BandAuditions = new List<BandAudition>();
            PlaylistItems = new List<PlaylistItem>();
            SongComments = new List<SongComment>();
            InitializePartial();
        }

        partial void InitializePartial();
    }
}