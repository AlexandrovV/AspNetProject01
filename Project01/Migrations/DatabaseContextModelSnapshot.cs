﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project01.Data;

namespace Project01.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("Project01.Models.Actor", b =>
                {
                    b.Property<int>("ActorId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("ActorId");

                    b.ToTable("Actors");

                    b.HasData(
                        new
                        {
                            ActorId = -1,
                            Name = "Bradley Pitt"
                        },
                        new
                        {
                            ActorId = -2,
                            Name = "Thomas Hardy"
                        });
                });

            modelBuilder.Entity("Project01.Models.Director", b =>
                {
                    b.Property<int>("DirectorId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("DirectorId");

                    b.ToTable("Directors");

                    b.HasData(
                        new
                        {
                            DirectorId = -1,
                            Name = "Quentin Tarantino"
                        },
                        new
                        {
                            DirectorId = -2,
                            Name = "Guy Ritchie"
                        });
                });

            modelBuilder.Entity("Project01.Models.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("GenreId");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            GenreId = -1,
                            Name = "Drama"
                        },
                        new
                        {
                            GenreId = -2,
                            Name = "Thriller"
                        });
                });

            modelBuilder.Entity("Project01.Models.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DirectorId");

                    b.Property<string>("Name");

                    b.Property<string>("ShortDescription");

                    b.Property<int>("StudioId");

                    b.HasKey("MovieId");

                    b.HasIndex("DirectorId");

                    b.HasIndex("StudioId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            MovieId = -1,
                            DirectorId = -1,
                            Name = "Once Upon a Time in… Hollywood",
                            ShortDescription = "Once Upon a Time in Hollywood is a 2019 comedy-drama film written and directed by Quentin Tarantino.",
                            StudioId = -1
                        },
                        new
                        {
                            MovieId = -2,
                            DirectorId = -2,
                            Name = "RocknRolla",
                            ShortDescription = "RocknRolla is a 2008 action crime film written and directed by Guy Ritchie, and starring Gerard Butler, Tom Wilkinson, Thandie Newton, Mark Strong, Idris Elba, Tom Hardy, Gemma Arterton and Toby Kebbell.",
                            StudioId = -2
                        });
                });

            modelBuilder.Entity("Project01.Models.MovieActor", b =>
                {
                    b.Property<int>("MovieId");

                    b.Property<int>("ActorId");

                    b.HasKey("MovieId", "ActorId");

                    b.HasIndex("ActorId");

                    b.ToTable("MovieActor");
                });

            modelBuilder.Entity("Project01.Models.MovieGenre", b =>
                {
                    b.Property<int>("MovieId");

                    b.Property<int>("GenreId");

                    b.HasKey("MovieId", "GenreId");

                    b.HasIndex("GenreId");

                    b.ToTable("MovieGenre");
                });

            modelBuilder.Entity("Project01.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("MovieId");

                    b.Property<int>("ReviewerId");

                    b.Property<string>("Text");

                    b.HasKey("ReviewId");

                    b.HasIndex("MovieId");

                    b.HasIndex("ReviewerId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            ReviewId = -1,
                            MovieId = -1,
                            ReviewerId = -1,
                            Text = "Very nice movie"
                        },
                        new
                        {
                            ReviewId = -2,
                            MovieId = -2,
                            ReviewerId = -2,
                            Text = "Gorgeous movie"
                        });
                });

            modelBuilder.Entity("Project01.Models.Reviewer", b =>
                {
                    b.Property<int>("ReviewerId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("ReviewerId");

                    b.ToTable("Reviewers");

                    b.HasData(
                        new
                        {
                            ReviewerId = -1,
                            Name = "Vincent Canby"
                        },
                        new
                        {
                            ReviewerId = -2,
                            Name = "Dana Stevens"
                        });
                });

            modelBuilder.Entity("Project01.Models.Studio", b =>
                {
                    b.Property<int>("StudioId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("StudioId");

                    b.ToTable("Studios");

                    b.HasData(
                        new
                        {
                            StudioId = -1,
                            Name = "Warner Bros"
                        },
                        new
                        {
                            StudioId = -2,
                            Name = "Paramount Pictures"
                        });
                });

            modelBuilder.Entity("Project01.Models.Movie", b =>
                {
                    b.HasOne("Project01.Models.Director", "Director")
                        .WithMany("Movies")
                        .HasForeignKey("DirectorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Project01.Models.Studio", "Studio")
                        .WithMany("Movies")
                        .HasForeignKey("StudioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Project01.Models.MovieActor", b =>
                {
                    b.HasOne("Project01.Models.Actor", "Actor")
                        .WithMany("MovieActors")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Project01.Models.Movie", "Movie")
                        .WithMany("MovieActors")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Project01.Models.MovieGenre", b =>
                {
                    b.HasOne("Project01.Models.Genre", "Genre")
                        .WithMany("MovieGenres")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Project01.Models.Movie", "Movie")
                        .WithMany("MovieGenres")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Project01.Models.Review", b =>
                {
                    b.HasOne("Project01.Models.Movie", "Movie")
                        .WithMany("Reviews")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Project01.Models.Reviewer", "Reviewer")
                        .WithMany("Reviews")
                        .HasForeignKey("ReviewerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
