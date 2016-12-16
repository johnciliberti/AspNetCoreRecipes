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
    // CollaborationSpace
    public partial class CollaborationSpace
    {
        public int CollaborationSpaceId { get; set; } // CollaborationSpaceId (Primary key)

        public string Title { get; set; } // Title

        public string Description { get; set; } // Description

        public bool RestrictContributorsToBand { get; set; } // RestrictContributorsToBand

        public int? BandId { get; set; } // BandId

        public bool AllowPublicView { get; set; } // AllowPublicView

        public ProjectCopyrightModel CopyrightModel { get; set; } // CopyrightModel

        public bool AllowContributorsToPublish { get; set; } // AllowContributorsToPublish

        public DateTime CreateDate { get; set; } // CreateDate

        public DateTime ModifiedDate { get; set; } // ModifiedDate

        public DateTime? LastPostDate { get; set; } // LastPostDate

        public DateTime? PublishedDate { get; set; } // PublishedDate

        public int NumberViews { get; set; } // NumberViews

        public int NumberComments { get; set; } // NumberComments

        public ProjectStatus Status { get; set; } // Status

        public int? ConceptId { get; set; } // ConceptId

        public string ConceptMediaType { get; set; } // ConceptMediaType

        // Reverse navigation
        public virtual ICollection<ArtistCollaborationSpace> ArtistCollaborationSpaces { get; set; } // ArtistCollaborationSpaces.FK_ArtistCollaborationSpaces_ToTable_1

        public virtual ICollection<CollaborationSpaceAlert> CollaborationSpaceAlerts { get; set; } // CollaborationSpaceAlerts.FK_CollaborationSpaceAlerts_CollaborationSpace

        public virtual ICollection<CollaborationSpaceComment> CollaborationSpaceComments { get; set; } // CollaborationSpaceComment.FK_CollaborationSpaceComment_CollaborationSpace

        public virtual ICollection<CollaborationSpaceFile> CollaborationSpaceFiles { get; set; } // CollaborationSpaceFile.FK_CollaborationSpaceFile_CollaborationSpace

        public virtual ICollection<CollaborationSpaceGenre> CollaborationSpaceGenres { get; set; } // CollaborationSpaceGenre.FK_CollaborationSpaceGenre_CollaborationSpace

        public virtual ICollection<CollaborationSpaceInvite> CollaborationSpaceInvites { get; set; } // CollaborationSpaceInvite.FK_CollaborationSpaceInvite_CollaborationSpace

        public virtual ICollection<CollaborationSpaceMedia> CollaborationSpaceMedias { get; set; } // CollaborationSpaceMedia.FK_CollaborationSpaceMedia_CollaborationSpace

        public virtual ICollection<OpenPosition> OpenPositions { get; set; }

        // Foreign keys
        public virtual Band Band { get; set; } // FK_CollaborationSpace_ToTable

        public CollaborationSpace()
        {
            RestrictContributorsToBand = false;
            AllowPublicView = true;
            CopyrightModel = 0;
            AllowContributorsToPublish = false;
            CreateDate = System.DateTime.Now;
            ModifiedDate = System.DateTime.Now;
            NumberViews = 0;
            NumberComments = 0;
            Status = 0;
            ArtistCollaborationSpaces = new List<ArtistCollaborationSpace>();
            CollaborationSpaceAlerts = new List<CollaborationSpaceAlert>();
            CollaborationSpaceComments = new List<CollaborationSpaceComment>();
            CollaborationSpaceFiles = new List<CollaborationSpaceFile>();
            CollaborationSpaceGenres = new List<CollaborationSpaceGenre>();
            CollaborationSpaceInvites = new List<CollaborationSpaceInvite>();
            CollaborationSpaceMedias = new List<CollaborationSpaceMedia>();
            OpenPositions = new List<OpenPosition>();
            InitializePartial();
        }

        partial void InitializePartial();
    }
}