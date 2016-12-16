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
    // CollaborationSpaceComment
    public partial class CollaborationSpaceComment
    {
        public int CollaborationSpaceCommentId { get; set; } // CollaborationSpaceCommentId (Primary key)

        public int CollaborationSpaceId { get; set; } // CollaborationSpaceID

        public int ArtistId { get; set; } // ArtistId

        public int? CollabortationSpaceFileId { get; set; } // CollabortationSpaceFileId

        public string CommentTitle { get; set; } // CommentTitle

        public string CommentBody { get; set; } // CommentBody

        public int ThreadId { get; set; } // ThreadId

        public int ParentId { get; set; } // ParentId

        public int NestLevel { get; set; } // NestLevel

        public string Path { get; set; } // Path

        public DateTime CreateDate { get; set; } // CreateDate

        // Foreign keys
        public virtual Artist Artist { get; set; } // FK_CollaborationSpaceComment_Artist

        public virtual CollaborationSpace CollaborationSpace { get; set; } // FK_CollaborationSpaceComment_CollaborationSpace

        public virtual CollaborationSpaceFile CollaborationSpaceFile { get; set; } // FK_CollaborationSpaceComment_ToTable

        public CollaborationSpaceComment()
        {
            ThreadId = 0;
            ParentId = 0;
            NestLevel = 0;
            Path = "/";
            CreateDate = System.DateTime.Now;
            InitializePartial();
        }

        partial void InitializePartial();
    }
}