using System.Collections.Generic;
using MovieApp.Domain.Enums;
using MovieApp.Domain.Models;

namespace MovieApp.Services.Services
{
    public interface IMovieGenreService
    {
        List<Genre> GetAllGenres();

        Genre GetGenreById(int id);

        void AddNewGenre(Genre genre);

        List<Movie> GetAllMovies();
        Movie GetMovieById(int id);

        void AddNewMovie(Movie movie);
    }
}