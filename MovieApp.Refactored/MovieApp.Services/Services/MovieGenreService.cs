using System;
using System.Collections.Generic;
using System.Linq;
using MovieApp.DataAccess.Repositories;
using MovieApp.Domain.Enums;
using MovieApp.Domain.Models;

namespace MovieApp.Services.Services
{
    public class MovieGenreService : IMovieGenreService
    {
        private IRepository<Genre> _genreRepository;
        private IRepository<Movie> _movieRepository;

        public void AddNewGenre(Genre genre)
        {
                _genreRepository.Insert(genre);
        }

        public void AddNewMovie(Movie movie)
        {
            _movieRepository.Insert(movie);
        }

        public List<Genre> GetAllGenres()
        {
                return _genreRepository.GetAll();
        }

        public Genre GetGenreById(int id)
        {
                return _genreRepository.GetById(id);
        }

        public Movie GetMovieById(int id)
        {
                return _movieRepository.GetById(id);
        }

        public List<Movie> GetAllMovies()
        {
                return _movieRepository.GetAll();
        }
    }
}