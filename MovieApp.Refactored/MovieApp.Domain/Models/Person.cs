using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieApp.Domain.Enums;

namespace MovieApp.Domain.Models
{
    public class Person
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        public List<Genre> Genres { get; set; }

        public Role Role { get; set; }
    }
}
