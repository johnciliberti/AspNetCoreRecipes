using Microsoft.EntityFrameworkCore;
using Recipe04.DataAccess.Entities;


namespace Recipe04.DataAccess.Context
{
    public class ArtistContext : DbContext
    {
        public ArtistContext(DbContextOptions<ArtistContext> options) : base(options)
        {

        }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<ArtistSkill> ArtistSkill { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Artist
            builder.Entity<Artist>().Property(x => x.City).HasMaxLength(50);
            builder.Entity<Artist>().Property(x => x.Country).HasMaxLength(50);
            builder.Entity<Artist>().Property(x => x.Provence).HasMaxLength(50);
            builder.Entity<Artist>().Property(x => x.UserName).IsRequired(true).HasMaxLength(50);
            builder.Entity<Artist>().Property(x => x.WebSite).HasMaxLength(255);

            // ArtistSkill
            builder.Entity<ArtistSkill>().Property(x => x.Details).HasMaxLength(255);
            builder.Entity<ArtistSkill>().Property(x => x.TalentName).IsRequired(true).HasMaxLength(50);
            builder.Entity<ArtistSkill>().Property(x => x.Styles).HasMaxLength(255);

        }
    }

}
