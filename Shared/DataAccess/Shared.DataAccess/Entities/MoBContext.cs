using Microsoft.EntityFrameworkCore;

namespace AspNetCoreMvcRecipes.Shared.DataAccess
{
    public partial class MoBContext : DbContext, IMoBContext
    {
        public MoBContext(DbContextOptions<MoBContext> options)
            : base(options) { }
        public MoBContext() { }

        // note for EF 7, the name defined here is used as the DB table name
        // EF 7 does not allow you to change the pluralization conventions

        public DbSet<Alert> Alerts { get; set; } // Alert

        public DbSet<AlertSubscription> AlertSubscriptions { get; set; } // AlertSubscription

        public DbSet<AlertTag> AlertTags { get; set; } // AlertTag

        public DbSet<Artist> Artists { get; set; } // Artist

        public DbSet<ArtistBand> ArtistBands { get; set; } // ArtistBand

        public DbSet<ArtistBlock> ArtistBlocks { get; set; } // ArtistBlock

        public DbSet<ArtistCollaborationSpace> ArtistCollaborationSpaces { get; set; } // ArtistCollaborationSpaces

        public DbSet<ArtistFavorite> ArtistFavorites { get; set; } // ArtistFavorites

        public DbSet<ArtistProfile> ArtistProfiles { get; set; } // ArtistProfile

        public DbSet<ArtistSkill> ArtistSkills { get; set; } // ArtistSkill

        public DbSet<Band> Bands { get; set; } // Band

        public DbSet<BandAudition> BandAuditions { get; set; } // BandAudition

        public DbSet<BandAuditionComment> BandAuditionComments { get; set; } // BandAuditionComment

        public DbSet<BandGenre> BandGenres { get; set; } // BandGenre

        public DbSet<BannedEmailAddress> BannedEmailAddresses { get; set; } // BannedEmailAddress

        public DbSet<CollaborationSpace> CollaborationSpaces { get; set; } // CollaborationSpace

        public DbSet<CollaborationSpaceAlert> CollaborationSpaceAlerts { get; set; } // CollaborationSpaceAlerts

        public DbSet<CollaborationSpaceComment> CollaborationSpaceComments { get; set; } // CollaborationSpaceComment

        public DbSet<CollaborationSpaceFile> CollaborationSpaceFiles { get; set; } // CollaborationSpaceFile

        public DbSet<CollaborationSpaceGenre> CollaborationSpaceGenres { get; set; } // CollaborationSpaceGenre

        public DbSet<CollaborationSpaceInvite> CollaborationSpaceInvites { get; set; } // CollaborationSpaceInvite

        public DbSet<CollaborationSpaceMedia> CollaborationSpaceMedias { get; set; } // CollaborationSpaceMedia

        public DbSet<EmailOptOut> EmailOptOuts { get; set; } // EmailOptOut

        public DbSet<EmailVerification> EmailVerifications { get; set; } // EmailVerification

        public DbSet<GenreLookUp> GenreLookUps { get; set; } // GenreLookUp

        public DbSet<Media> Media { get; set; } // Media

        public DbSet<Message> Messages { get; set; } // Message

        public DbSet<MessageRecipient> MessageRecipients { get; set; } // MessageRecipient

        public DbSet<MessageSpam> MessageSpams { get; set; } // MessageSpam

        public DbSet<OpenPosition> OpenPositions { get; set; } // OpenPosition

        public DbSet<PlayList> PlayLists { get; set; } // PlayList

        public DbSet<PlaylistItem> PlaylistItems { get; set; } // PlaylistItem


        public DbSet<Song> Songs { get; set; } // Song

        public DbSet<SongComment> SongComments { get; set; } // SongComment

        public DbSet<Task> Tasks { get; set; } // Task

        public DbSet<WebpagesMembership> WebpagesMemberships { get; set; } // webpages_Membership

        public DbSet<WebpagesOAuthMembership> WebpagesOAuthMemberships { get; set; } // webpages_OAuthMembership

        public DbSet<WebpagesRoles> WebpagesRoles { get; set; } // webpages_Roles



        partial void InitializePartial();

        protected override void OnModelCreating(ModelBuilder builder)
        {
            
            // also has a property called Id, EF can't figure out which one to use
            builder.Entity<Artist>().HasKey(a => a.ArtistId);
            builder.Entity<Artist>().Ignore(a => a.Id);

            // These are computed fields that are not present in the database
            builder.Entity<Artist>().Ignore(a => a.AvatarUrlSample);

            // Many to many relationships that could not be determined automatically
            builder.Entity<Artist>().HasMany(a => a.WebpagesRoles);
            builder.Entity<WebpagesRoles>().HasMany(a => a.Artists);
            builder.Entity<ArtistProfile>().HasKey(a => a.ArtistId);

            //does not match the convention so need to add custom primary key
            builder.Entity<ArtistSkill>().HasKey(a => a.ArtistTalentId);
            builder.Entity<BannedEmailAddress>().HasKey(a => a.EmailAddress);
            builder.Entity<EmailOptOut>().HasKey(a => a.EmailAddress);
            builder.Entity<WebpagesMembership>().HasKey(a => a.UserId);
            builder.Entity<WebpagesOAuthMembership>().HasKey(a => new { a.Provider, a.ProviderUserId }); // composite primary key
            builder.Entity<WebpagesRoles>().HasKey(a => a.RoleId);

            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            base.OnConfiguring(options);
            //var builder = new ConfigurationBuilder()
            //    .AddJsonFile("ConnStrings.json");
            //var config = builder.Build();
            //var constr = config["ConnectionStrings:DefaultConnection"];
            //options.UseSqlServer(constr);
            //base.OnConfiguring(options);

        }

        

    }
}