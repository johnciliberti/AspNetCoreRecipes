// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier

using Mvc6Recipes.Shared.DataAccess.Util;
using System;
using System.Collections.Generic;

//using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.DatabaseGeneratedOption;

namespace Mvc6Recipes.Shared.DataAccess
{
    // Artist
    public partial class Artist
    {
        public int ArtistId { get; set; } // ArtistId (Primary key)

        public Guid? OldUserId { get; set; } // OldUserId

        public string UserName { get; set; } // UserName

        public string Country { get; set; } // Country

        public string Province { get; set; } // Provence

        public string City { get; set; } // City

        public DateTime CreateDate { get; set; } // CreateDate

        public DateTime ModifiedDate { get; set; } // ModifiedDate

        public string WebSite { get; set; } // WebSite

        public byte ProfilePrivacyLevel { get; set; } // ProfilePrivacyLevel

        public byte ContactPrivacyLevel { get; set; } // ContactPrivacyLevel

        public long ProfileViews { get; set; } // ProfileViews

        public DateTime? ProfileLastViewDate { get; set; } // ProfileLastViewDate

        public byte? Rating { get; set; } // Rating

        public string AvatarUrl { get; set; }

        public string AvatarUrlSample
        {
            get
            {
#if DEBUG
                return DebugDataSubstitute.GetRandomImagePath();
#else
                return AvatarUrl;
#endif
            }
        }

        public string EmailAddress { get; set; } // EmailAddress

        public int FileUploadsInBytes { get; set; } // FileUploadsInBytes

        public int FileUploadQuotaInBytes { get; set; } // FileUploadQuotaInBytes

        public DateTime LastActivityDate { get; set; } // LastActivityDate

        public bool ShowChatStatus { get; set; } // ShowChatStatus

        public bool AllowChatSounds { get; set; } // AllowChatSounds

        public virtual string Id { get; set; }

        // Reverse navigation
        public virtual ArtistProfile ArtistProfile { get; set; } // ArtistProfile.FK_ArtistProfile_Artist

        public virtual ICollection<AlertSubscription> AlertSubscriptions { get; set; } // AlertSubscription.FK_AlertSubscription_Artist

        public virtual ICollection<ArtistBand> ArtistBands { get; set; } // ArtistBand.FK_ArtistBand_ToArtist

        public virtual ICollection<ArtistBlock> ArtistBlocks { get; set; } // ArtistBlock.FK_ArtistBlock_Artist

        public virtual ICollection<ArtistCollaborationSpace> ArtistCollaborationSpaces { get; set; } // ArtistCollaborationSpaces.FK_ArtistCollaborationSpaces_ToTable

        public virtual ICollection<ArtistFavorite> ArtistFavorites { get; set; } // ArtistFavorites.FK_ArtistFavorites_Artist

        public virtual ICollection<ArtistSkill> ArtistSkills { get; set; } // ArtistSkill.FK_ArtistSkill_Artist

        public virtual ICollection<BandAudition> BandAuditions { get; set; } // BandAudition.FK_BandAudition_Artist

        public virtual ICollection<BandAuditionComment> BandAuditionComments { get; set; } // BandAuditionComment.FK_BandAuditionComment_Artist

        public virtual ICollection<CollaborationSpaceAlert> CollaborationSpaceAlerts { get; set; } // CollaborationSpaceAlerts.FK_CollaborationSpaceAlerts_Artist

        public virtual ICollection<CollaborationSpaceComment> CollaborationSpaceComments { get; set; } // CollaborationSpaceComment.FK_CollaborationSpaceComment_Artist

        public virtual ICollection<CollaborationSpaceInvite> CollaborationSpaceInvites { get; set; } // CollaborationSpaceInvite.FK_CollaborationSpaceInvite_Artist

        public virtual ICollection<Medium> Media { get; set; } // Media.FK_Media_ToTable

        public virtual ICollection<Message> Messages { get; set; } // Message.FK_Message_Artist

        public virtual ICollection<MessageRecipient> MessageRecipients { get; set; } // MessageRecipient.FK_MessageRecipient_Artist

        public virtual ICollection<PlayList> PlayLists { get; set; } // PlayList.FK_Playlist_Artist

        public virtual ICollection<Task> Tasks { get; set; } // Task.FK_Task_Artist

        public virtual ICollection<WebpagesRoles> WebpagesRoles { get; set; } // Many to many mapping

        public Artist()
        {
            CreateDate = System.DateTime.Now;
            ModifiedDate = System.DateTime.Now;
            ProfilePrivacyLevel = 0;
            ContactPrivacyLevel = 0;
            ProfileViews = 0;
            Rating = 3;
            FileUploadsInBytes = 0;
            FileUploadQuotaInBytes = 0;
            LastActivityDate = System.DateTime.Now;
            ShowChatStatus = true;
            AllowChatSounds = true;
            AlertSubscriptions = new List<AlertSubscription>();
            ArtistBands = new List<ArtistBand>();
            ArtistBlocks = new List<ArtistBlock>();
            ArtistCollaborationSpaces = new List<ArtistCollaborationSpace>();
            ArtistFavorites = new List<ArtistFavorite>();
            ArtistSkills = new List<ArtistSkill>();
            BandAuditions = new List<BandAudition>();
            BandAuditionComments = new List<BandAuditionComment>();
            CollaborationSpaceAlerts = new List<CollaborationSpaceAlert>();
            CollaborationSpaceComments = new List<CollaborationSpaceComment>();
            CollaborationSpaceInvites = new List<CollaborationSpaceInvite>();
            Media = new List<Medium>();
            Messages = new List<Message>();
            MessageRecipients = new List<MessageRecipient>();
            PlayLists = new List<PlayList>();
            Tasks = new List<Task>();
            WebpagesRoles = new List<WebpagesRoles>();
            Id = OldUserId.ToString();
            InitializePartial();
        }

        partial void InitializePartial();
    }
}