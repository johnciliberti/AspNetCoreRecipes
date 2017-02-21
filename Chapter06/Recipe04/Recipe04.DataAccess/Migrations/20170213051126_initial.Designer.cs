using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Recipe04.DataAccess.Context;

namespace Recipe04.DataAccess.Migrations
{
    [DbContext(typeof(ArtistContext))]
    [Migration("20170213051126_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Recipe04.DataAccess.Entities.Artist", b =>
                {
                    b.Property<int>("ArtistId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City")
                        .HasMaxLength(50);

                    b.Property<string>("Country")
                        .HasMaxLength(50);

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("Provence")
                        .HasMaxLength(50);

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("WebSite")
                        .HasMaxLength(255);

                    b.HasKey("ArtistId");

                    b.ToTable("Artists");
                });

            modelBuilder.Entity("Recipe04.DataAccess.Entities.ArtistSkill", b =>
                {
                    b.Property<int>("ArtistSkillId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ArtistId");

                    b.Property<string>("Details")
                        .HasMaxLength(255);

                    b.Property<int>("SkillLevel");

                    b.Property<string>("Styles")
                        .HasMaxLength(255);

                    b.Property<string>("TalentName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("ArtistSkillId");

                    b.HasIndex("ArtistId");

                    b.ToTable("ArtistSkill");
                });

            modelBuilder.Entity("Recipe04.DataAccess.Entities.ArtistSkill", b =>
                {
                    b.HasOne("Recipe04.DataAccess.Entities.Artist", "Artist")
                        .WithMany("ArtistSkills")
                        .HasForeignKey("ArtistId");
                });
        }
    }
}
