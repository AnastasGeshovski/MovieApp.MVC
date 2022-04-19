using System.Collections.Generic;
using MovieApp.Domain.Models;

namespace MovieApp.Services.Services
{
    public interface IPersonService
    {
        Person GetPersonById(int id);

        int AddNewPerson(Person person);

        List<Person> GetAllPersons();
    }
}