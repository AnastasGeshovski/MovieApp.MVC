using MovieApp.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace MovieApp.DataAccess.Repositories.CacheRepositories
{
    public class PersonRepository : IRepository<Person>
    {
        public void DeleteById(int id)
        {
            var person = CacheDb.Persons.FirstOrDefault(p => p.Id == id);

            if (person != null)
            {
                CacheDb.Persons.Remove(person);
            }
        }

        public List<Person> GetAll()
        {
            return CacheDb.Persons;
        }

        public Person GetById(int id)
        {
            return CacheDb.Persons.FirstOrDefault(person => person.Id == id);
        }

        public int Insert(Person entity)
        {
            CacheDb.PersonId++;

            entity.Id = CacheDb.PersonId;

            CacheDb.Persons.Add(entity);

            return entity.Id;
        }

        public void Update(Person entity)
        {
            var person = CacheDb.Persons.FirstOrDefault(p => p.Id == entity.Id);

            if (person != null)
            {
                var index = CacheDb.Persons.IndexOf(entity);

                CacheDb.Persons[index] = entity;
            }
        }
    }
}