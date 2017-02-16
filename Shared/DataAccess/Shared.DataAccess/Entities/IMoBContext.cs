using Microsoft.EntityFrameworkCore;
using System;

//using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.DatabaseGeneratedOption;

namespace AspNetCoreMvcRecipes.Shared.DataAccess
{
    public interface IMoBContext : IDisposable
    {
        DbSet<Alert> Alerts { get; set; } // Alert

        DbSet<AlertSubscription> AlertSubscriptions { get; set; } // AlertSubscription

        DbSet<AlertTag> AlertTags { get; set; } // AlertTag

        DbSet<Artist> Artists { get; set; } // Artist

        DbSet<ArtistBand> ArtistBands { get; set; } // ArtistBand

        DbSet<ArtistBlock> ArtistBlocks { get; set; } // ArtistBlock

        DbSet<ArtistCollaborationSpace> ArtistCollaborationSpaces { get; set; } // ArtistCollaborationSpaces

        DbSet<ArtistFavorite> ArtistFavorites { get; set; } // ArtistFavorites

        DbSet<ArtistProfile> ArtistProfiles { get; set; } // ArtistProfile

        DbSet<ArtistSkill> ArtistSkills { get; set; } // ArtistSkill

        DbSet<Band> Bands { get; set; } // Band

        DbSet<BandAudition> BandAuditions { get; set; } // BandAudition

        DbSet<BandAuditionComment> BandAuditionComments { get; set; } // BandAuditionComment

        DbSet<BandGenre> BandGenres { get; set; } // BandGenre

        DbSet<BannedEmailAddress> BannedEmailAddresses { get; set; } // BannedEmailAddress

        DbSet<CollaborationSpace> CollaborationSpaces { get; set; } // CollaborationSpace

        DbSet<CollaborationSpaceAlert> CollaborationSpaceAlerts { get; set; } // CollaborationSpaceAlerts

        DbSet<CollaborationSpaceComment> CollaborationSpaceComments { get; set; } // CollaborationSpaceComment

        DbSet<CollaborationSpaceFile> CollaborationSpaceFiles { get; set; } // CollaborationSpaceFile

        DbSet<CollaborationSpaceGenre> CollaborationSpaceGenres { get; set; } // CollaborationSpaceGenre

        DbSet<CollaborationSpaceInvite> CollaborationSpaceInvites { get; set; } // CollaborationSpaceInvite

        DbSet<CollaborationSpaceMedia> CollaborationSpaceMedias { get; set; } // CollaborationSpaceMedia

        DbSet<EmailOptOut> EmailOptOuts { get; set; } // EmailOptOut

        DbSet<EmailVerification> EmailVerifications { get; set; } // EmailVerification

        DbSet<GenreLookUp> GenreLookUps { get; set; } // GenreLookUp

        DbSet<Media> Media { get; set; } // Media

        DbSet<Message> Messages { get; set; } // Message

        DbSet<MessageRecipient> MessageRecipients { get; set; } // MessageRecipient

        DbSet<MessageSpam> MessageSpams { get; set; } // MessageSpam

        DbSet<OpenPosition> OpenPositions { get; set; } // OpenPosition

        DbSet<PlayList> PlayLists { get; set; } // PlayList

        DbSet<PlaylistItem> PlaylistItems { get; set; } // PlaylistItem


        DbSet<Song> Songs { get; set; } // Song

        DbSet<SongComment> SongComments { get; set; } // SongComment


        DbSet<Task> Tasks { get; set; } // Task

        int SaveChanges();
    }
}