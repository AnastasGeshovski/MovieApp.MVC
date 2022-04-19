using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MovieApp.Domain.Models;

namespace MovieApp.DataAccess.Repositories.EntityRepositories
{
    public class GenreEntityRepository : IRepository<Genre>
    {
        private MovieDbContext _context;
        public GenreEntityRepository(MovieDbContext context)
        {
            _context = context;
        }
        public void DeleteById(int id)
        {
            Genre genre = _context.Genres.FirstOrDefault(x => x.Id == id);
            if (genre != null) _context.Genres.Remove(genre);
            _context.SaveChanges();
        }

        public List<Genre> GetAll()
        {
            return _context.Genres
            .Include(x => x.MovieGenres)
            .ThenInclude(x => x.Movie)
            .Include(x => x.Person)
            .ToList();
        }

        public Genre GetById(int id)
        {
            return _context.Genres
            .Include(i => i.MovieGenres)
            .ThenInclude(i => i.Movie)
            .Include(i => i.Person)
            .FirstOrDefault(x => x.Id == id);
        }

        public int Insert(Genre entity)
        {
            _context.Genres.Add(entity);
            int id = _context.SaveChanges();
            return id;
        }

        public void Update(Genre entity)
        {
            Genre genre = _context.Genres.FirstOrDefault(x => x.Id == entity.Id);
            if (genre != null)
            {
                entity.Id = genre.Id;
                _context.Genres.Update(entity);
            }
        }
    }
}