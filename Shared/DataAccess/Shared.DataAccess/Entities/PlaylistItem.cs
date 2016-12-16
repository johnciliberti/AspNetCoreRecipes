// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier

//using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.DatabaseGeneratedOption;

namespace Mvc6Recipes.Shared.DataAccess
{
    // PlaylistItem
    public partial class PlaylistItem
    {
        public int PlaylistItemId { get; set; } // PlaylistItemId (Primary key)

        public int PlayListId { get; set; } // PlayListId

        public int SongId { get; set; } // SongId

        public int DisplayOrder { get; set; } // DisplayOrder

        // Foreign keys
        public virtual PlayList PlayList { get; set; } // FK_PlaylistItem_PayList

        public virtual Song Song { get; set; } // FK_PlaylistItem_Song

        public PlaylistItem()
        {
            DisplayOrder = 0;
            InitializePartial();
        }

        partial void InitializePartial();
    }
}