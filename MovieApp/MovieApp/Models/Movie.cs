using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MovieApp;

namespace MovieApp.Models
{
    public class Movie
    {
        public int? Id { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }

        public decimal Price { get; set; }

        public string Rating { get; set; }

    }
}
