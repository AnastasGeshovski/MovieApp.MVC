using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Models
{
    public class MovieViewModel
    {
        public int? Id { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        [Display(Name="Release Date")]
        public DateTime ReleaseDate { get; set; }

        public List<Genre> Genre { get; set; }
        public List<Person> Person { get; set; }

    }
}
