using System;
using System.Collections.Generic;
using MovieApp.Domain.Enums;
using MovieApp.Domain.Models;


namespace MovieApp.DataAccess
{
    public static class CacheDb
    {
        public static List<Person> Persons;

        public static List<Genre> Genres;

        public static List<Movie> Movies;

        public static int PersonId;

        public static int GenreId;

        public static int MovieId;

        static CacheDb()
        {
            Persons = new List<Person>
         {
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
            }
         };
            Movies = new List<Movie>
         {
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
            },
            };
            Genres = new List<Genre>()
            {
                new Genre()
                {
                Id = 1,
                Type = TypeOfMovies.Romantic,
                },
                 new Genre()
                {
                Id = 2,
                Type = TypeOfMovies.Comedy
                },
                  new Genre()
                {
                Id = 3,
                Type = TypeOfMovies.Western
                }
            };
        }
    }
}
