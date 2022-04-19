using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using MovieApp.Domain.Models;
using MovieApp.Domain.Enums;
using System;

namespace MovieApp.DataAccess
{
   public class MovieDbContext : DbContext
   {
      public MovieDbContext(DbContextOptions<MovieDbContext> options)
         : base(options)
      {
      }

      public DbSet<Person> Persons { get; set; }
      public DbSet<Movie> Movies { get; set; }
      public DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // CONFIGURATIONS
            modelBuilder.Entity<Genre>()
               .HasMany(x => x.MovieGenres)
               .WithOne(x => x.Genre)
               .HasForeignKey(x => x.GenreId);
            modelBuilder.Entity<Movie>()
               .HasMany(x => x.MovieGenres)
               .WithOne(x => x.Movie)
               .HasForeignKey(x => x.MovieId);
            modelBuilder.Entity<Person>()
               .HasMany(x => x.Genres)
               .WithOne(x => x.Person)
               .HasForeignKey(x => x.PersonId);

            // SEEDING
            modelBuilder.Entity<Person>()
            .HasData(
               new Person()
               {
                   Id = 1,
                   FirstName = "Bill",
                   LastName = "Murray",
                   Role = Role.Actor
               },
               new Person()
               {
                   Id = 2,
                   FirstName = "Rob",
                   LastName = "Reiner",
                   Role = Role.Director
               },
                new Person()
                {
                    Id = 3,
                    FirstName = "Jules",
                    LastName = "Furthman",
                    Role = Role.Writer
                });

            modelBuilder.Entity<Movie>()
               .HasData(
                 new Movie()
                 {
                     Id = 1,
                     Title = "When Harry met Sally",
                     ReleaseDate = DateTime.Parse("1989-01-01"),
                     Type = TypeOfMovies.Romantic,
                     Role = Role.Director

                 },
             new Movie()
             {
                 Id = 2,
                 Title = "Ghostbusters",
                 ReleaseDate = DateTime.Parse("1989-01-01"),
                 Type = TypeOfMovies.Comedy,
                 Role = Role.Actor

             },
             new Movie()
             {
                 Id = 2,
                 Title = "Rio Bravo",
                 ReleaseDate = DateTime.Parse("1959-01-01"),
                 Type = TypeOfMovies.Western,
                 Role = Role.Writer
             });

            modelBuilder.Entity<Genre>()
            .HasData(
               new Genre()
               {
                   Id = 1,
                   Type = TypeOfMovies.Romantic,
                   PersonId = 1
               },
               new Genre()
               {
                   Id = 2,
                   Type = TypeOfMovies.Comedy,
                   PersonId = 2
               },
               new Genre()
               {
                   Id = 3,
                   Type = TypeOfMovies.Western,
                   PersonId = 3
               });

            modelBuilder.Entity<MovieGenre>()
           .HasData(
              new MovieGenre()
              {
                  Id = 1,
                  GenreId = 1,
                  MovieId = 1
              },

               new MovieGenre()
               {
                   Id = 1,
                   GenreId = 1,
                   MovieId = 1
               },
               new MovieGenre()
               {
                   Id = 2,
                   GenreId = 1,
                   MovieId = 3
               },
               new MovieGenre()
               {
                   Id = 3,
                   GenreId = 2,
                   MovieId = 1
               },
               new MovieGenre()
               {
                   Id = 4,
                   GenreId = 3,
                   MovieId = 2
               });

        }
    }
}