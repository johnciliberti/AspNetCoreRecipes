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
    // PlayList
    public partial class PlayList
    {
        public int PlaylistId { get; set; } // PlaylistId (Primary key)

        public string Title { get; set; } // Title

        public int? ArtistId { get; set; } // ArtistId

        public int? BandId { get; set; } // BandId

        public bool IsSitePlaylist { get; set; } // IsSitePlaylist

        public bool IsDefaultPlaylist { get; set; } // IsDefaultPlaylist

        // Reverse navigation
        public virtual ICollection<PlaylistItem> PlaylistItems { get; set; } // PlaylistItem.FK_PlaylistItem_PayList

        // Foreign keys
        public virtual Artist Artist { get; set; } // FK_Playlist_Artist

        public virtual Band Band { get; set; } // FK_PlayList_Band

        public PlayList()
        {
            IsSitePlaylist = false;
            IsDefaultPlaylist = false;
            PlaylistItems = new List<PlaylistItem>();
            InitializePartial();
        }

        partial void InitializePartial();
    }
}