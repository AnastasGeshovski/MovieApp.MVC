using System.Collections.Generic;
using System.Linq;
using MovieApp.DataAccess.Repositories;
using MovieApp.Domain.Models;

namespace MovieApp.Services.Services
{
    public class PersonService : IPersonService
    {
        private IRepository<Person> _personRepository;

        public PersonService(IRepository<Person> personRepository)
        {
            _personRepository = personRepository;
        }

        public int AddNewPerson(Person person)
        {
            return _personRepository.Insert(person);
        }

        public List<Person> GetAllPersons()
        {
            return _personRepository.GetAll();
        }

        public Person GetPersonById(int id)
        {
            return _personRepository.GetById(id);
        }
    }
}