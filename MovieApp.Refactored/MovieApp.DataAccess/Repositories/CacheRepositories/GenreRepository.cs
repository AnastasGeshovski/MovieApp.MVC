using MovieApp.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace MovieApp.DataAccess.Repositories.CacheRepositories
{
    public class GenreRepository : IRepository<Genre>
    {
        public void DeleteById(int id)
        {
            var genre = CacheDb.Genres.FirstOrDefault(g => g.Id == id);

            if (genre != null)
            {
                CacheDb.Genres.Remove(genre);
            }
        }

        public List<Genre> GetAll()
        {
            return CacheDb.Genres;
        }

        public Genre GetById(int id)
        {
            return CacheDb.Genres.FirstOrDefault(genre => genre.Id == id);
        }

        public int Insert(Genre entity)
        {
            CacheDb.GenreId++;

            entity.Id = CacheDb.GenreId;

            CacheDb.Genres.Add(entity);

            return entity.Id;
        }

        public void Update(Genre entity)
        {
            var genre = CacheDb.Genres.FirstOrDefault(g => g.Id == entity.Id);

            if (genre != null)
            {
                var index = CacheDb.Genres.IndexOf(entity);

                CacheDb.Genres[index] = entity;
            }
        }
    }
}