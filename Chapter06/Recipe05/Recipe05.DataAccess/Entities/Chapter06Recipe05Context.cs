using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Recipe05.DataAccess.Entities
{
    public partial class Chapter06Recipe05Context : DbContext
    {
        public virtual DbSet<Bands> Bands { get; set; }
        public virtual DbSet<Events> Events { get; set; }
        public virtual DbSet<Venues> Venues { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            optionsBuilder.UseSqlServer(@"Server=.;Database=Chapter06Recipe05;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bands>(entity =>
            {
                entity.HasKey(e => e.BandId)
                    .HasName("PK_Bands");

                entity.Property(e => e.Genre).HasColumnType("varchar(50)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Events>(entity =>
            {
                entity.HasKey(e => e.EventId)
                    .HasName("PK_Events");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(500)");

                entity.Property(e => e.EventDate).HasColumnType("smalldatetime");

                entity.HasOne(d => d.Band)
                    .WithMany(p => p.Events)
                    .HasForeignKey(d => d.BandId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Events_Events_Bands");

                entity.HasOne(d => d.Venue)
                    .WithMany(p => p.Events)
                    .HasForeignKey(d => d.VenueId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Events_Venues");
            });

            modelBuilder.Entity<Venues>(entity =>
            {
                entity.HasKey(e => e.VenueId)
                    .HasName("PK_Venues");

                entity.Property(e => e.Address).HasColumnType("varchar(100)");

                entity.Property(e => e.City).HasColumnType("varchar(100)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ZipCode).HasColumnType("varchar(10)");
            });
        }
    }
}