using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieApp.Domain.Enums;

namespace MovieApp.Domain.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public TypeOfMovies Type { get; set; }
        public List<MovieGenre> MovieGenres { get; set; }
        public List<Movie> Movies { get; set; }
        public Person Person { get; set; }
        public int PersonId { get; set; }
    }
}
