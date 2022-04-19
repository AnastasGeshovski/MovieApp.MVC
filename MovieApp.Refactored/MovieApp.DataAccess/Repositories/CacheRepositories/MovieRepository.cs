using MovieApp.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace MovieApp.DataAccess.Repositories.CacheRepositories
{
    public class MovieRepository : IRepository<Movie>
    {
        public void DeleteById(int id)
        {
            var movie = CacheDb.Movies.FirstOrDefault(m => m.Id == id);

            if (movie != null)
            {
                CacheDb.Movies.Remove(movie);
            }
        }

        public List<Movie> GetAll()
        {
            return CacheDb.Movies;
        }

        public Movie GetById(int id)
        {
            return CacheDb.Movies.FirstOrDefault(movie => movie.Id == id);
        }

        public int Insert(Movie entity)
        {
            CacheDb.MovieId++;

            entity.Id = CacheDb.MovieId;

            CacheDb.Movies.Add(entity);

            return entity.Id;
        }

        public void Update(Movie entity)
        {
            var movie = CacheDb.Movies.FirstOrDefault(m => m.Id == entity.Id);

            if (movie != null)
            {
                int index = CacheDb.Movies.IndexOf(entity);

                CacheDb.Movies[index] = entity;
            }
        }
    }
}