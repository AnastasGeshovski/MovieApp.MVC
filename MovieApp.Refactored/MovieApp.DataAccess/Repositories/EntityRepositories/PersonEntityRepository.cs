using MovieApp.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace MovieApp.DataAccess.Repositories.EntityRepositories
{
    public class PersonEntityRepository : IRepository<Person>
    {
        private MovieDbContext _context;

        public PersonEntityRepository(MovieDbContext context)
        {
            _context = context;
        }

        public void DeleteById(int id)
        {
            var person = _context.Persons.FirstOrDefault(p => p.Id == id);

            if (person != null)
            {
                _context.Persons.Remove(person);
            }

            _context.SaveChanges();
        }

        public List<Person> GetAll()
        {
            return _context.Persons.ToList();
        }

        public Person GetById(int id)
        {
            return _context.Persons.FirstOrDefault(person => person.Id == id);
        }

        public int Insert(Person entity)
        {
            _context.Persons.Add(entity);

            return _context.SaveChanges();
        }

        public void Update(Person entity)
        {
            var person = _context.Persons.FirstOrDefault(u => u.Id == entity.Id);

            if (person != null)
            {
                person.FirstName = entity.FirstName;
                person.LastName = entity.LastName;
                person.Role = entity.Role;

                if (entity.Genres != null)
                {
                    person.Genres = entity.Genres;
                }

                _context.Persons.Update(person);
            }
        }
    }
}