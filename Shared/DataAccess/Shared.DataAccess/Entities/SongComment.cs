// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier

using System;

//using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.DatabaseGeneratedOption;

namespace Mvc6Recipes.Shared.DataAccess
{
    // SongComment
    public partial class SongComment
    {
        public int SongCommentId { get; set; } // SongCommentId (Primary key)

        public int? SongId { get; set; } // SongId

        public string Comment { get; set; } // Comment

        public int Rating { get; set; } // Rating

        public DateTime? CreateDate { get; set; } // CreateDate

        public bool IsApproved { get; set; } // IsApproved

        public bool IsAnonymous { get; set; } // IsAnonymous

        public string Name { get; set; } // Name

        public string EmailAddress { get; set; } // EmailAddress

        // Foreign keys
        public virtual Song Song { get; set; } // FK_SongComment_Song

        public SongComment()
        {
            Rating = 3;
            IsApproved = false;
            IsAnonymous = false;
            InitializePartial();
        }

        partial void InitializePartial();
    }
}