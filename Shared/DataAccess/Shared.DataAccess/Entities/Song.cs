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
    // Song
    public partial class Song
    {
        public int SongId { get; set; } // SongId (Primary key)

        public int MediaId { get; set; } // MediaId

        public string SongTitle { get; set; } // SongTitle

        public int? ReleaseYear { get; set; } // ReleaseYear

        public string ArtworkUrl { get; set; } // ArtworkURL

        public string Lyrics { get; set; } // Lyrics

        public string SongDescription { get; set; } // SongDescription

        public string ActionParameter { get; set; } // ActionParameter

        public string Action { get; set; } // Action

        public string Controller { get; set; } // Controller

        public int? GenreId { get; set; } // GenreId

        public DateTime CreateDate { get; set; } // CreateDate

        public bool ShowInLibrary { get; set; } // ShowInLibrary

        // Reverse navigation
        public virtual ICollection<BandAudition> BandAuditions { get; set; } // BandAudition.FK_BandAudition_Song

        public virtual ICollection<PlaylistItem> PlaylistItems { get; set; } // PlaylistItem.FK_PlaylistItem_Song

        public virtual ICollection<SongComment> SongComments { get; set; } // SongComment.FK_SongComment_Song

        // Foreign keys
        public virtual Medium Medium { get; set; } // FK_Song_Media

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