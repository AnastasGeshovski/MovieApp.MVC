using MovieApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Models
{
    public class MovieGenreViewModel
    {
        public List<Movie> Movies { get; set; }
        public List<Genre> Genre { get; set; }
        public MovieGenre MovieGenre { get; set; }
        public string SearchString { get; set; }
    }
}
