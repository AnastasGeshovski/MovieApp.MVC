using System.Collections.Generic;
using System.Linq;
using MovieApp.Domain.Models;

namespace MovieApp.DataAccess.Repositories.EntityRepositories
{
    public class MovieEntityRepository : IRepository<Movie>
    {
        private MovieDbContext _context;
        public MovieEntityRepository(MovieDbContext context)
        {
            _context = context;
        }

        public void DeleteById(int id)
        {
            Movie movie = _context.Movies.FirstOrDefault(x => x.Id == id);
            if (movie != null) _context.Movies.Remove(movie);
            _context.SaveChanges();
        }

        public List<Movie> GetAll()
        {
            return _context.Movies.ToList();
        }

        public Movie GetById(int id)
        {
            return _context.Movies.FirstOrDefault(x => x.Id == id);
        }

        public int Insert(Movie entity)
        {
            _context.Movies.Add(entity);
            int id = _context.SaveChanges();
            return id;
        }

        public void Update(Movie entity)
        {
            Movie movie = _context.Movies.FirstOrDefault(x => x.Id == entity.Id);
            if (movie != null)
            {
                entity.Id = movie.Id;
                _context.Movies.Update(entity);
            }
        }
    }
}